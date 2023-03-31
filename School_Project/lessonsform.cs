using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Project
{
    public partial class lessonsform : Form
    {
        public lessonsform()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.lessonsTableAdapter ds = new DataSet1TableAdapters.lessonsTableAdapter();

        private void lessonsform_Load(object sender, EventArgs e)
        {
              dataGridView1.DataSource = ds.lessonlist();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            teacherform tf = new teacherform();
            tf.Show();
            this.Close();
        }

        private void btnLlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.lessonlist();
        }

        private void btnLadd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ds.lessonadd(txtLname.Text);
                MessageBox.Show("Lesson added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLname.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                dataGridView1.DataSource = ds.lessonlist();
                txtLname.Clear();
                txtLid.Clear();
            }
        }

        private void btnLupdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ds.lessonupdate(txtLname.Text,byte.Parse(txtLid.Text));
                MessageBox.Show("Lesson updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLname.Clear();
                txtLid.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                dataGridView1.DataSource = ds.lessonlist();
                txtLname.Clear();
                txtLid.Clear();
            }
        }

        private void btnLdelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ds.lessondelete(byte.Parse (txtLname.Text));
                MessageBox.Show("Lesson deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLname.Clear();
                txtLid.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                dataGridView1.DataSource = ds.lessonlist();
                txtLname.Clear();
                txtLid.Clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
