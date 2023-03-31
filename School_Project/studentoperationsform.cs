using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class studentoperationsform : Form
    {
        public studentoperationsform()
        {
            InitializeComponent();
        }

        connection mycon = new connection();
        private void studentoperationsform_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mycon.adress);

            dataGridView1.DataSource = st.studentlist();

            con.Open();
            SqlCommand com = new SqlCommand("select * from clubs", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbSclub.DisplayMember = "c_name";
            cmbSclub.ValueMember = "c_id";
            cmbSclub.DataSource = dt;
            con.Close();
        }

        DataSet1TableAdapters.studentsTableAdapter st = new DataSet1TableAdapters.studentsTableAdapter();
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            teacherform tf = new teacherform();
            this.Close();
            tf.Show();
        }

        string s = "";
        private void btnSadd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                st.studentadd(txtSname.Text, txtSsname.Text, byte.Parse(cmbSclub.Text), s);
                MessageBox.Show("Student added!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = st.studentlist();
            }
            else if(dialogResult == DialogResult.No)
            {
                dataGridView1.DataSource = st.studentlist();
                txtSname.Clear();
                txtSid.Clear();
                txtSsname.Clear();
                cmbSclub.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }

        private void btnSupdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                st.studentupdate(txtSname.Text, txtSsname.Text, byte.Parse(cmbSclub.SelectedValue.ToString()), s, int.Parse(txtSid.Text));
                MessageBox.Show("Student updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = st.studentlist();
            }
            else if (dialogResult == DialogResult.No)
            {
                dataGridView1.DataSource = st.studentlist();
                txtSname.Clear();
                txtSid.Clear();
                txtSsname.Clear();
                cmbSclub.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }

        private void cmbSclub_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSid.Text = cmbSclub.SelectedValue.ToString();
        }

        private void btnSdelete_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    st.studentdelete(int.Parse(txtSid.Text));
                    MessageBox.Show("Student deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.DataSource = st.studentlist();
                }
                else if (dialogResult == DialogResult.No)
                {
                    dataGridView1.DataSource = st.studentlist();
                    txtSname.Clear();
                    txtSid.Clear();
                    txtSsname.Clear();
                    cmbSclub.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSsname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbSclub.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();


            if (dataGridView1.CurrentRow.Cells[3].Value.Equals("Male"))
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton1.Checked = false;
            }
            if (dataGridView1.CurrentRow.Cells[3].Value.Equals("Female"))
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton2.Checked = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                s = "Male";
            }
            else if (radioButton2.Checked == true)
            {
                s = "Female";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                s = "Male";
            }
            else if (radioButton2.Checked == true)
            {
                s = "Female";
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
          dataGridView1.DataSource = st.studentsearch(txtsearch.Text);
        }

        private void btnSlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = st.studentlist();
        }
    }
}
