namespace School_Project
{
    partial class mainpage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainpage));
            this.picbStudent = new System.Windows.Forms.PictureBox();
            this.picbTeacher = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // picbStudent
            // 
            this.picbStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbStudent.Image = ((System.Drawing.Image)(resources.GetObject("picbStudent.Image")));
            this.picbStudent.Location = new System.Drawing.Point(145, 12);
            this.picbStudent.Name = "picbStudent";
            this.picbStudent.Size = new System.Drawing.Size(157, 102);
            this.picbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbStudent.TabIndex = 0;
            this.picbStudent.TabStop = false;
            this.picbStudent.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picbTeacher
            // 
            this.picbTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbTeacher.Image = ((System.Drawing.Image)(resources.GetObject("picbTeacher.Image")));
            this.picbTeacher.Location = new System.Drawing.Point(393, 12);
            this.picbTeacher.Name = "picbTeacher";
            this.picbTeacher.Size = new System.Drawing.Size(157, 102);
            this.picbTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbTeacher.TabIndex = 1;
            this.picbTeacher.TabStop = false;
            this.picbTeacher.Click += new System.EventHandler(this.picbTeacher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teacher";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Moccasin;
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID.Location = new System.Drawing.Point(145, 168);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(405, 29);
            this.txtID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(654, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(704, 211);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbTeacher);
            this.Controls.Add(this.picbStudent);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "mainpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main page";
            ((System.ComponentModel.ISupportInitialize)(this.picbStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbStudent;
        private System.Windows.Forms.PictureBox picbTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

