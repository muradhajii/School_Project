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
    public partial class teacherform : Form
    {
        public teacherform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clubform cf = new clubform();
            cf.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            mainpage mp = new mainpage();
            mp.Show();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        connection mycon = new connection();

        public string ID;

        private void btnTstudents_Click(object sender, EventArgs e)
        {
            studentoperationsform so = new studentoperationsform();
            this.Close();
            so.Show();
        }

        private void btnTexams_Click(object sender, EventArgs e)
        {
            examsform ef = new examsform();
            ef.Show();
            this.Close();
        }

        private void btnTlessons_Click(object sender, EventArgs e)
        {
            lessonsform lf = new lessonsform();
            lf.Show();
            this.Hide();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            teachersinfoform tif = new teachersinfoform();
            tif.Show();
        }
    }
}
