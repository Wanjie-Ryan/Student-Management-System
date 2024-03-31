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
            lblFirstname = new Label();
            lblRegno = new Label();
            lblRole = new Label();
            lblLastname = new Label();
            txtFirstname = new TextBox();
            txtRegno = new TextBox();
            cmbGrade = new ComboBox();
            txtLastname = new TextBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dataGridCheckStudents = new DataGridView();
            btnDelete = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtStudentID = new TextBox();
            lblStudentID = new Label();
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
            lblStudentsTitle.Size = new Size(244, 22);
            lblStudentsTitle.TabIndex = 20;
            lblStudentsTitle.Text = "Check Students in School ";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(16, 106);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(107, 22);
            lblFirstname.TabIndex = 21;
            lblFirstname.Text = "First name";
            // 
            // lblRegno
            // 
            lblRegno.AutoSize = true;
            lblRegno.Location = new Point(12, 272);
            lblRegno.Name = "lblRegno";
            lblRegno.Size = new Size(155, 22);
            lblRegno.TabIndex = 22;
            lblRegno.Text = "Registration no.";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(16, 329);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(51, 22);
            lblRole.TabIndex = 23;
            lblRole.Text = "Role";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(16, 157);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(103, 22);
            lblLastname.TabIndex = 24;
            lblLastname.Text = "Last name";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(183, 99);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(184, 29);
            txtFirstname.TabIndex = 25;
            // 
            // txtRegno
            // 
            txtRegno.Location = new Point(183, 265);
            txtRegno.Name = "txtRegno";
            txtRegno.Size = new Size(184, 29);
            txtRegno.TabIndex = 26;
            txtRegno.TextChanged += txtRegno_TextChanged;
            // 
            // cmbGrade
            // 
            cmbGrade.FormattingEnabled = true;
            cmbGrade.Items.AddRange(new object[] { "Student" });
            cmbGrade.Location = new Point(183, 321);
            cmbGrade.Name = "cmbGrade";
            cmbGrade.Size = new Size(184, 30);
            cmbGrade.TabIndex = 27;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(183, 154);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(184, 29);
            txtLastname.TabIndex = 28;
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
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(16, 210);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(98, 22);
            lblUsername.TabIndex = 36;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(183, 210);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(184, 29);
            txtUsername.TabIndex = 37;
            // 
            // txtStudentID
            // 
            txtStudentID.Cursor = Cursors.No;
            txtStudentID.Location = new Point(183, 44);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.ReadOnly = true;
            txtStudentID.Size = new Size(184, 29);
            txtStudentID.TabIndex = 38;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(16, 51);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(110, 22);
            lblStudentID.TabIndex = 39;
            lblStudentID.Text = "Student ID";
            // 
            // CheckStudents
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 473);
            Controls.Add(lblStudentID);
            Controls.Add(txtStudentID);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridCheckStudents);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtLastname);
            Controls.Add(cmbGrade);
            Controls.Add(txtRegno);
            Controls.Add(txtFirstname);
            Controls.Add(lblLastname);
            Controls.Add(lblRole);
            Controls.Add(lblRegno);
            Controls.Add(lblFirstname);
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
        private Label lblFirstname;
        private Label lblRegno;
        private Label lblRole;
        private Label lblLastname;
        private TextBox txtFirstname;
        private TextBox txtRegno;
        private ComboBox cmbGrade;
        private TextBox txtLastname;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dataGridCheckStudents;
        private Button btnDelete;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnAdd;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtStudentID;
        private Label lblStudentID;
    }
}