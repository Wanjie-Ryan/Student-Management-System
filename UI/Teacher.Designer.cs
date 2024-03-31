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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            menuStripTeachers = new MenuStrip();
            assignmentsToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            lblTitleTeachers = new Label();
            lblAssignment = new Label();
            lblAssDesc = new Label();
            lblSubject = new Label();
            txtAssName = new TextBox();
            dataGridAssignments = new DataGridView();
            lblDeadline = new Label();
            cmbSubject = new ComboBox();
            dateTimePickerAssignment = new DateTimePicker();
            lblSearch = new Label();
            txtSearch = new TextBox();
            txtAssDesc = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            pbClose = new PictureBox();
            lblID = new Label();
            txtAssignmentID = new TextBox();
            menuStripTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAssignments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
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
            assignmentsToolStripMenuItem.Size = new Size(161, 26);
            assignmentsToolStripMenuItem.Text = "Check Students";
            assignmentsToolStripMenuItem.Click += assignmentsToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(14, 26);
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lblTitleTeachers
            // 
            lblTitleTeachers.AutoSize = true;
            lblTitleTeachers.Location = new Point(535, 42);
            lblTitleTeachers.Name = "lblTitleTeachers";
            lblTitleTeachers.Size = new Size(122, 22);
            lblTitleTeachers.TabIndex = 1;
            lblTitleTeachers.Text = "Assignments";
            // 
            // lblAssignment
            // 
            lblAssignment.AutoSize = true;
            lblAssignment.Location = new Point(12, 122);
            lblAssignment.Name = "lblAssignment";
            lblAssignment.Size = new Size(167, 22);
            lblAssignment.TabIndex = 2;
            lblAssignment.Text = "Assignment name";
            // 
            // lblAssDesc
            // 
            lblAssDesc.AutoSize = true;
            lblAssDesc.Location = new Point(12, 213);
            lblAssDesc.Name = "lblAssDesc";
            lblAssDesc.Size = new Size(225, 22);
            lblAssDesc.TabIndex = 3;
            lblAssDesc.Text = "Assignment Description";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(12, 291);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(76, 22);
            lblSubject.TabIndex = 4;
            lblSubject.Text = "Subject";
            // 
            // txtAssName
            // 
            txtAssName.Location = new Point(196, 115);
            txtAssName.Name = "txtAssName";
            txtAssName.Size = new Size(275, 29);
            txtAssName.TabIndex = 5;
            // 
            // dataGridAssignments
            // 
            dataGridAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAssignments.Location = new Point(584, 138);
            dataGridAssignments.Name = "dataGridAssignments";
            dataGridAssignments.RowHeadersWidth = 51;
            dataGridAssignments.Size = new Size(576, 237);
            dataGridAssignments.TabIndex = 8;
            dataGridAssignments.RowHeaderMouseClick += dataGridAssignments_RowHeaderMouseClick;
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Location = new Point(12, 338);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(91, 22);
            lblDeadline.TabIndex = 9;
            lblDeadline.Text = "Deadline";
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "Physics", "English", "Biology", "Chemistry", "History", "Mathematics", "Agriculture" });
            cmbSubject.Location = new Point(137, 283);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(203, 30);
            cmbSubject.TabIndex = 10;
            // 
            // dateTimePickerAssignment
            // 
            dateTimePickerAssignment.Location = new Point(128, 338);
            dateTimePickerAssignment.Name = "dateTimePickerAssignment";
            dateTimePickerAssignment.Size = new Size(250, 29);
            dateTimePickerAssignment.TabIndex = 11;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(584, 98);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(71, 22);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(675, 95);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(485, 29);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtAssDesc
            // 
            txtAssDesc.Location = new Point(262, 161);
            txtAssDesc.Multiline = true;
            txtAssDesc.Name = "txtAssDesc";
            txtAssDesc.Size = new Size(209, 74);
            txtAssDesc.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Olive;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(12, 423);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkGoldenrod;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(128, 423);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Khaki;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(246, 423);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(365, 423);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pbClose
            // 
            pbClose.Cursor = Cursors.Hand;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(1088, 0);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(37, 30);
            pbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClose.TabIndex = 18;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(12, 61);
            lblID.Name = "lblID";
            lblID.Size = new Size(145, 22);
            lblID.TabIndex = 19;
            lblID.Text = "Assignment ID";
            // 
            // txtAssignmentID
            // 
            txtAssignmentID.Cursor = Cursors.No;
            txtAssignmentID.Location = new Point(196, 58);
            txtAssignmentID.Name = "txtAssignmentID";
            txtAssignmentID.ReadOnly = true;
            txtAssignmentID.Size = new Size(275, 29);
            txtAssignmentID.TabIndex = 20;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 491);
            Controls.Add(txtAssignmentID);
            Controls.Add(lblID);
            Controls.Add(pbClose);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dateTimePickerAssignment);
            Controls.Add(cmbSubject);
            Controls.Add(lblDeadline);
            Controls.Add(dataGridAssignments);
            Controls.Add(txtAssDesc);
            Controls.Add(txtAssName);
            Controls.Add(lblSubject);
            Controls.Add(lblAssDesc);
            Controls.Add(lblAssignment);
            Controls.Add(lblTitleTeachers);
            Controls.Add(menuStripTeachers);
            Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripTeachers;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Teacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher";
            Load += Teacher_Load;
            menuStripTeachers.ResumeLayout(false);
            menuStripTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAssignments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripTeachers;
        private ToolStripMenuItem assignmentsToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private Label lblTitleTeachers;
        private Label lblAssignment;
        private Label lblAssDesc;
        private Label lblSubject;
        private TextBox txtAssName;
        private DataGridView dataGridAssignments;
        private Label lblDeadline;
        private ComboBox cmbSubject;
        private DateTimePicker dateTimePickerAssignment;
        private Label lblSearch;
        private TextBox txtSearch;
        private TextBox txtAssDesc;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private PictureBox pbClose;
        private Label lblID;
        private TextBox txtAssignmentID;
    }
}