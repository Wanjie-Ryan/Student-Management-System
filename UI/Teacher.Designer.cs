namespace Student_Management_System.UI
{
    partial class Teacher
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
            menuStripTeachers = new MenuStrip();
            assignmentsToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            menuStripTeachers.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripTeachers
            // 
            menuStripTeachers.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStripTeachers.ImageScalingSize = new Size(20, 20);
            menuStripTeachers.Items.AddRange(new ToolStripItem[] { assignmentsToolStripMenuItem, studentsToolStripMenuItem });
            menuStripTeachers.Location = new Point(0, 0);
            menuStripTeachers.Name = "menuStripTeachers";
            menuStripTeachers.Size = new Size(1200, 30);
            menuStripTeachers.TabIndex = 0;
            menuStripTeachers.Text = "menuStrip1";
            // 
            // assignmentsToolStripMenuItem
            // 
            assignmentsToolStripMenuItem.Name = "assignmentsToolStripMenuItem";
            assignmentsToolStripMenuItem.Size = new Size(106, 24);
            assignmentsToolStripMenuItem.Text = "Assignments";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(101, 26);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            Controls.Add(menuStripTeachers);
            Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripTeachers;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Teacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher";
            menuStripTeachers.ResumeLayout(false);
            menuStripTeachers.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripTeachers;
        private ToolStripMenuItem assignmentsToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
    }
}