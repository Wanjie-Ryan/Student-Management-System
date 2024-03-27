namespace Student_Management_System.UI
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            panelTopDashboard = new Panel();
            lblStudentDashboard = new Label();
            pbClose = new PictureBox();
            panelTopDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // panelTopDashboard
            // 
            panelTopDashboard.Controls.Add(pbClose);
            panelTopDashboard.Controls.Add(lblStudentDashboard);
            panelTopDashboard.Dock = DockStyle.Top;
            panelTopDashboard.Location = new Point(0, 0);
            panelTopDashboard.Name = "panelTopDashboard";
            panelTopDashboard.Size = new Size(1135, 46);
            panelTopDashboard.TabIndex = 0;
            // 
            // lblStudentDashboard
            // 
            lblStudentDashboard.AutoSize = true;
            lblStudentDashboard.Location = new Point(536, 9);
            lblStudentDashboard.Name = "lblStudentDashboard";
            lblStudentDashboard.Size = new Size(181, 22);
            lblStudentDashboard.TabIndex = 0;
            lblStudentDashboard.Text = "Student Dashboard";
            // 
            // pbClose
            // 
            pbClose.Cursor = Cursors.Hand;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(1069, 9);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(31, 30);
            pbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClose.TabIndex = 20;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 495);
            Controls.Add(panelTopDashboard);
            Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            panelTopDashboard.ResumeLayout(false);
            panelTopDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopDashboard;
        private Label lblStudentDashboard;
        private PictureBox pbClose;
    }
}