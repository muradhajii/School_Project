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
    public partial class studentsmarksform : Form
    {
        public studentsmarksform()
        {
            InitializeComponent();
        }

        connection mycon = new connection();

        public string ID;
        private void studentsmarksform_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mycon.adress);

            con.Open();

            SqlCommand com = new SqlCommand("select l_name,exam1,exam2,exam3,avarage,status from marks \r\ninner join lessons on marks.l_id=lessons.l_id where s_id=@p1", con);
            com.Parameters.AddWithValue("@p1", ID);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand com2 = new SqlCommand("select s_name,s_sname from students where s_id=@p2", con);
            com2.Parameters.AddWithValue("@p2", ID);
            SqlDataReader dr = com2.ExecuteReader();
            while (dr.Read())
            {
                this.Text = dr[0].ToString() + dr[1].ToString();
            }
            con.Close();

            mainpage mp = new mainpage();
            mp.Show();
        }
    }
}
