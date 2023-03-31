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
using System.Data.SqlClient;

namespace School_Project
{
    public partial class examsform : Form
    {
        public examsform()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.marksTableAdapter mt = new DataSet1TableAdapters.marksTableAdapter();
        private void btnsearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mt.marklist(int.Parse(txtSid.Text));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            teacherform tf = new teacherform();
            tf.Show();
        }

        connection mycon = new connection();
       
        private void examsform_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mycon.adress);

            con.Open();
            SqlCommand com = new SqlCommand("select * from lessons", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmblesson.DisplayMember = "l_name";
            cmblesson.ValueMember = "l_id";
            cmblesson.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            markID =int.Parse(txtSid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtSid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtexam1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtexam2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtexam3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtaverage.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtstatus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        int exam1, exam2, exam3;
        double average;
        private void btncalculate_Click(object sender, EventArgs e)
        {
            exam1 = Convert.ToInt32(txtexam1.Text);
            exam2 = Convert.ToInt32(txtexam2.Text);
            exam3 = Convert.ToInt32(txtexam3.Text);
            average = (exam1 + exam2 + exam3) / 3;
            txtaverage.Text = average.ToString();

            if (average > 50 & average <= 71)
            {
                txtstatus.Text = "Not bad!";
            }
            if (average > 70 & average <= 81)
            {
                txtstatus.Text = "Good!";
            }
            if (average > 80 & average <= 91)
            {
                txtstatus.Text = "Very good!";
            }
            if(average > 90 & average <=100)
            {
                txtstatus.Text = "Excellent!";
            }
            else if(average<=50)
            {
                txtstatus.Text = "Very bad!";
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtSid.Text = "";
            txtexam1.Text = "";
            txtexam2.Text = "";
            txtexam3.Text = "";
            txtaverage.Text = "";
            txtstatus.Text = "";
            cmblesson.Text = "";
        }

        int markID;
        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                mt.markupdate(byte.Parse(cmblesson.SelectedValue.ToString()), int.Parse(txtSid.Text), byte.Parse(txtexam1.Text), byte.Parse(txtexam2.Text), byte.Parse(txtexam3.Text), decimal.Parse(txtaverage.Text), bool.Parse(txtstatus.Text), markID);
                MessageBox.Show("Mark updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(dialogResult == DialogResult.No)
            {
                txtSid.Text = "";
                txtexam1.Text = "";
                txtexam2.Text = "";
                txtexam3.Text = "";
                txtaverage.Text = "";
                txtstatus.Text = "";
                cmblesson.Text = "";
            }
        }
    }
}
