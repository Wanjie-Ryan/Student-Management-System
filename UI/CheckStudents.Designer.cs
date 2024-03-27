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
            txtStudentname = new TextBox();
            txtRegno = new TextBox();
            cmbGrade = new ComboBox();
            txtFees = new TextBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dataGridCheckStudents = new DataGridView();
            btnDelete = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            menuStripStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCheckStudents).BeginInit();
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
            // txtStudentname
            // 
            txtStudentname.Location = new Point(183, 92);
            txtStudentname.Name = "txtStudentname";
            txtStudentname.Size = new Size(184, 29);
            txtStudentname.TabIndex = 25;
            // 
            // txtRegno
            // 
            txtRegno.Location = new Point(183, 156);
            txtRegno.Name = "txtRegno";
            txtRegno.Size = new Size(184, 29);
            txtRegno.TabIndex = 26;
            // 
            // cmbGrade
            // 
            cmbGrade.FormattingEnabled = true;
            cmbGrade.Items.AddRange(new object[] { "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-" });
            cmbGrade.Location = new Point(183, 225);
            cmbGrade.Name = "cmbGrade";
            cmbGrade.Size = new Size(184, 30);
            cmbGrade.TabIndex = 27;
            // 
            // txtFees
            // 
            txtFees.Location = new Point(183, 289);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(184, 29);
            txtFees.TabIndex = 28;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(661, 96);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(485, 29);
            txtSearch.TabIndex = 30;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(570, 99);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(71, 22);
            lblSearch.TabIndex = 29;
            lblSearch.Text = "Search";
            // 
            // dataGridCheckStudents
            // 
            dataGridCheckStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCheckStudents.Location = new Point(570, 140);
            dataGridCheckStudents.Name = "dataGridCheckStudents";
            dataGridCheckStudents.RowHeadersWidth = 51;
            dataGridCheckStudents.Size = new Size(576, 237);
            dataGridCheckStudents.TabIndex = 31;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(369, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Khaki;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(250, 376);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 34;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkGoldenrod;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(132, 376);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Olive;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(16, 376);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // CheckStudents
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 473);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridCheckStudents);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtFees);
            Controls.Add(cmbGrade);
            Controls.Add(txtRegno);
            Controls.Add(txtStudentname);
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
            ((System.ComponentModel.ISupportInitialize)dataGridCheckStudents).EndInit();
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
        private TextBox txtStudentname;
        private TextBox txtRegno;
        private ComboBox cmbGrade;
        private TextBox txtFees;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dataGridCheckStudents;
        private Button btnDelete;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnAdd;
    }
}