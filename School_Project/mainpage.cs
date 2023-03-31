using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            studentsmarksform sm = new studentsmarksform();
            sm.ID = txtID.Text;
            sm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picbTeacher_Click(object sender, EventArgs e)
        {
            teacherform tf = new teacherform();
            tf.ID = txtID.Text;
            tf.Show();
            this.Hide();
        }
    }
}
