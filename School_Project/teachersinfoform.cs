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
    public partial class teachersinfoform : Form
    {
        public teachersinfoform()
        {
            InitializeComponent();
        }

        connection mycon = new connection();

        public string ID;
        private void teachersinfoform_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mycon.adress);

            con.Open();

            SqlCommand com = new SqlCommand("select t_id, t_fname from teachers", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
