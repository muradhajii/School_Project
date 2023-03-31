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
    public partial class clubform : Form
    {
        public clubform()
        {
            InitializeComponent();
        }

        connection mycon = new connection();

        void list()
        {
            SqlConnection con = new SqlConnection(mycon.adress);

            SqlDataAdapter da = new SqlDataAdapter("select * from clubs order by c_id", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void clubform_Load(object sender, EventArgs e)
        {
            list();
        }

        private void btnClist_Click(object sender, EventArgs e)
        {
            list();
        }

        private void btnCadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mycon.adress);

            con.Open();
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand com = new SqlCommand("insert into clubs(c_name) values(@p1)", con);
                com.Parameters.AddWithValue("@p1", txtCname.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Club added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCname.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                list();
                txtCname.Clear();
            }
            con.Close();
            list();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnCdelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mycon.adress);

            con.Open();
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                SqlCommand com = new SqlCommand("delete from clubs where c_id = @p1", con);
                com.Parameters.AddWithValue("@p1", txtCid.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Club deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(dialogResult == DialogResult.No)
            {
                list();
            }
            con.Close();
            list();
        }

        private void btnCupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mycon.adress);

            con.Open();
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand com = new SqlCommand("update clubs set c_name=@p1 where c_id =@p2", con);
                com.Parameters.AddWithValue("@p1", txtCname.Text);
                com.Parameters.AddWithValue("@p2", txtCid.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Club updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
                txtCname.Clear();
            }
            else if(dialogResult == DialogResult.No)
            {
                list();
                txtCname.Clear();
            }
            con.Close();
            list();
        }
    }
}
