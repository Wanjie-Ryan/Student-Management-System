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
            pbClose = new PictureBox();
            lblStudentDashboard = new Label();
            groupBoxFees = new GroupBox();
            groupBoxGrade = new GroupBox();
            lblFeeStatement = new Label();
            lblActualFee = new Label();
            lblGradeStatement = new Label();
            lblActualGrade = new Label();
            panelTopDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            groupBoxFees.SuspendLayout();
            groupBoxGrade.SuspendLayout();
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
            // lblStudentDashboard
            // 
            lblStudentDashboard.AutoSize = true;
            lblStudentDashboard.Location = new Point(536, 9);
            lblStudentDashboard.Name = "lblStudentDashboard";
            lblStudentDashboard.Size = new Size(181, 22);
            lblStudentDashboard.TabIndex = 0;
            lblStudentDashboard.Text = "Student Dashboard";
            // 
            // groupBoxFees
            // 
            groupBoxFees.Controls.Add(lblActualFee);
            groupBoxFees.Controls.Add(lblFeeStatement);
            groupBoxFees.Location = new Point(0, 52);
            groupBoxFees.Name = "groupBoxFees";
            groupBoxFees.Size = new Size(1135, 210);
            groupBoxFees.TabIndex = 1;
            groupBoxFees.TabStop = false;
            groupBoxFees.Text = "Fee";
            // 
            // groupBoxGrade
            // 
            groupBoxGrade.Controls.Add(lblActualGrade);
            groupBoxGrade.Controls.Add(lblGradeStatement);
            groupBoxGrade.Location = new Point(0, 273);
            groupBoxGrade.Name = "groupBoxGrade";
            groupBoxGrade.Size = new Size(1135, 221);
            groupBoxGrade.TabIndex = 2;
            groupBoxGrade.TabStop = false;
            groupBoxGrade.Text = "Grade";
            // 
            // lblFeeStatement
            // 
            lblFeeStatement.AutoSize = true;
            lblFeeStatement.Location = new Point(376, 94);
            lblFeeStatement.Name = "lblFeeStatement";
            lblFeeStatement.Size = new Size(264, 22);
            lblFeeStatement.TabIndex = 0;
            lblFeeStatement.Text = "Your have a Fee Balance of:";
            // 
            // lblActualFee
            // 
            lblActualFee.AutoSize = true;
            lblActualFee.ForeColor = Color.Red;
            lblActualFee.Location = new Point(646, 94);
            lblActualFee.Name = "lblActualFee";
            lblActualFee.Size = new Size(63, 22);
            lblActualFee.TabIndex = 1;
            lblActualFee.Text = "label1";
            // 
            // lblGradeStatement
            // 
            lblGradeStatement.AutoSize = true;
            lblGradeStatement.Location = new Point(400, 88);
            lblGradeStatement.Name = "lblGradeStatement";
            lblGradeStatement.Size = new Size(125, 22);
            lblGradeStatement.TabIndex = 0;
            lblGradeStatement.Text = "You scored a";
            // 
            // lblActualGrade
            // 
            lblActualGrade.AutoSize = true;
            lblActualGrade.ForeColor = Color.Green;
            lblActualGrade.Location = new Point(531, 88);
            lblActualGrade.Name = "lblActualGrade";
            lblActualGrade.Size = new Size(63, 22);
            lblActualGrade.TabIndex = 1;
            lblActualGrade.Text = "label1";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 495);
            Controls.Add(groupBoxGrade);
            Controls.Add(groupBoxFees);
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
            groupBoxFees.ResumeLayout(false);
            groupBoxFees.PerformLayout();
            groupBoxGrade.ResumeLayout(false);
            groupBoxGrade.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopDashboard;
        private Label lblStudentDashboard;
        private PictureBox pbClose;
        private GroupBox groupBoxFees;
        private GroupBox groupBoxGrade;
        private Label lblActualFee;
        private Label lblFeeStatement;
        private Label lblActualGrade;
        private Label lblGradeStatement;
    }
}