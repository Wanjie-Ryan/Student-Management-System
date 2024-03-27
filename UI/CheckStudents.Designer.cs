namespace Student_Management_System.UI
{
    partial class CheckStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckStudents));
            menuStripStudents = new MenuStrip();
            ChecStudentsToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            pbClose = new PictureBox();
            lblStudentsTitle = new Label();
            lblStudentname = new Label();
            lblRegno = new Label();
            lblGrade = new Label();
            lblFees = new Label();
            textBox1 = new TextBox();
            menuStripStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // menuStripStudents
            // 
            menuStripStudents.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStripStudents.ImageScalingSize = new Size(20, 20);
            menuStripStudents.Items.AddRange(new ToolStripItem[] { ChecStudentsToolStripMenuItem, studentsToolStripMenuItem });
            menuStripStudents.Location = new Point(0, 0);
            menuStripStudents.Name = "menuStripStudents";
            menuStripStudents.Size = new Size(1200, 30);
            menuStripStudents.TabIndex = 1;
            menuStripStudents.Text = "menuStrip1";
            // 
            // ChecStudentsToolStripMenuItem
            // 
            ChecStudentsToolStripMenuItem.Name = "ChecStudentsToolStripMenuItem";
            ChecStudentsToolStripMenuItem.Size = new Size(173, 26);
            ChecStudentsToolStripMenuItem.Text = "Post Assignment";
            ChecStudentsToolStripMenuItem.Click += ChecStudentsToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(14, 26);
            // 
            // pbClose
            // 
            pbClose.Cursor = Cursors.Hand;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(1035, 0);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(31, 30);
            pbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClose.TabIndex = 19;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // lblStudentsTitle
            // 
            lblStudentsTitle.AutoSize = true;
            lblStudentsTitle.Location = new Point(488, 44);
            lblStudentsTitle.Name = "lblStudentsTitle";
            lblStudentsTitle.Size = new Size(211, 22);
            lblStudentsTitle.TabIndex = 20;
            lblStudentsTitle.Text = "Input Fees and Grades";
            // 
            // lblStudentname
            // 
            lblStudentname.AutoSize = true;
            lblStudentname.Location = new Point(12, 92);
            lblStudentname.Name = "lblStudentname";
            lblStudentname.Size = new Size(132, 22);
            lblStudentname.TabIndex = 21;
            lblStudentname.Text = "Student name";
            // 
            // lblRegno
            // 
            lblRegno.AutoSize = true;
            lblRegno.Location = new Point(12, 156);
            lblRegno.Name = "lblRegno";
            lblRegno.Size = new Size(155, 22);
            lblRegno.TabIndex = 22;
            lblRegno.Text = "Registration no.";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(12, 216);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(63, 22);
            lblGrade.TabIndex = 23;
            lblGrade.Text = "Grade";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Location = new Point(12, 289);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(49, 22);
            lblFees.TabIndex = 24;
            lblFees.Text = "Fees";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 29);
            textBox1.TabIndex = 25;
            // 
            // CheckStudents
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 495);
            Controls.Add(textBox1);
            Controls.Add(lblFees);
            Controls.Add(lblGrade);
            Controls.Add(lblRegno);
            Controls.Add(lblStudentname);
            Controls.Add(lblStudentsTitle);
            Controls.Add(pbClose);
            Controls.Add(menuStripStudents);
            Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CheckStudents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckStudents";
            menuStripStudents.ResumeLayout(false);
            menuStripStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripStudents;
        private ToolStripMenuItem ChecStudentsToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private PictureBox pbClose;
        private Label lblStudentsTitle;
        private Label lblStudentname;
        private Label lblRegno;
        private Label lblGrade;
        private Label lblFees;
        private TextBox textBox1;
    }
}