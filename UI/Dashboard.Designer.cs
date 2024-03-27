namespace Student_Management_System.UI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStripDashboard = new MenuStrip();
            teacherToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            pbDashClose = new PictureBox();
            pictureBoxSchool = new PictureBox();
            menuStripDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDashClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSchool).BeginInit();
            SuspendLayout();
            // 
            // menuStripDashboard
            // 
            menuStripDashboard.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStripDashboard.ImageScalingSize = new Size(20, 20);
            menuStripDashboard.Items.AddRange(new ToolStripItem[] { teacherToolStripMenuItem, studentToolStripMenuItem });
            menuStripDashboard.Location = new Point(0, 0);
            menuStripDashboard.Name = "menuStripDashboard";
            menuStripDashboard.Size = new Size(1170, 30);
            menuStripDashboard.TabIndex = 0;
            // 
            // teacherToolStripMenuItem
            // 
            teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            teacherToolStripMenuItem.Size = new Size(95, 26);
            teacherToolStripMenuItem.Text = "Teacher";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(93, 26);
            studentToolStripMenuItem.Text = "Student";
            // 
            // pbDashClose
            // 
            pbDashClose.Cursor = Cursors.Hand;
            pbDashClose.Image = (Image)resources.GetObject("pbDashClose.Image");
            pbDashClose.Location = new Point(1110, 0);
            pbDashClose.Name = "pbDashClose";
            pbDashClose.Size = new Size(47, 30);
            pbDashClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDashClose.TabIndex = 3;
            pbDashClose.TabStop = false;
            pbDashClose.Click += pbDashClose_Click;
            // 
            // pictureBoxSchool
            // 
            pictureBoxSchool.Image = (Image)resources.GetObject("pictureBoxSchool.Image");
            pictureBoxSchool.Location = new Point(281, 92);
            pictureBoxSchool.Name = "pictureBoxSchool";
            pictureBoxSchool.Size = new Size(735, 356);
            pictureBoxSchool.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSchool.TabIndex = 4;
            pictureBoxSchool.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 497);
            Controls.Add(pictureBoxSchool);
            Controls.Add(pbDashClose);
            Controls.Add(menuStripDashboard);
            Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripDashboard;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboardcs";
            menuStripDashboard.ResumeLayout(false);
            menuStripDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDashClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSchool).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripDashboard;
        private ToolStripMenuItem teacherToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private PictureBox pbDashClose;
        private PictureBox pictureBoxSchool;
    }
}