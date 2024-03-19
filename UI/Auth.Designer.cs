namespace Student_Management_System.UI
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            panelAuth = new Panel();
            pbClose = new PictureBox();
            lblregHeader = new Label();
            groupBoxReg = new GroupBox();
            btnReg = new Button();
            txtPwd = new TextBox();
            cmbRole = new ComboBox();
            txtReg = new TextBox();
            textBox1 = new TextBox();
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            lblPwd = new Label();
            lblRole = new Label();
            lblRegNo = new Label();
            lblUsername = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            panelAuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            groupBoxReg.SuspendLayout();
            SuspendLayout();
            // 
            // panelAuth
            // 
            panelAuth.BackColor = Color.Coral;
            panelAuth.Controls.Add(pbClose);
            panelAuth.Controls.Add(lblregHeader);
            panelAuth.Cursor = Cursors.Hand;
            panelAuth.Dock = DockStyle.Top;
            panelAuth.Location = new Point(0, 0);
            panelAuth.Name = "panelAuth";
            panelAuth.Size = new Size(1000, 65);
            panelAuth.TabIndex = 0;
            // 
            // pbClose
            // 
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(936, 14);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(35, 34);
            pbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClose.TabIndex = 1;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // lblregHeader
            // 
            lblregHeader.AutoSize = true;
            lblregHeader.Location = new Point(352, 26);
            lblregHeader.Name = "lblregHeader";
            lblregHeader.Size = new Size(266, 22);
            lblregHeader.TabIndex = 0;
            lblregHeader.Text = "Student Management System";
            // 
            // groupBoxReg
            // 
            groupBoxReg.BackColor = Color.WhiteSmoke;
            groupBoxReg.Controls.Add(btnReg);
            groupBoxReg.Controls.Add(txtPwd);
            groupBoxReg.Controls.Add(cmbRole);
            groupBoxReg.Controls.Add(txtReg);
            groupBoxReg.Controls.Add(textBox1);
            groupBoxReg.Controls.Add(txtLastname);
            groupBoxReg.Controls.Add(txtFirstname);
            groupBoxReg.Controls.Add(lblPwd);
            groupBoxReg.Controls.Add(lblRole);
            groupBoxReg.Controls.Add(lblRegNo);
            groupBoxReg.Controls.Add(lblUsername);
            groupBoxReg.Controls.Add(lblLastName);
            groupBoxReg.Controls.Add(lblFirstName);
            groupBoxReg.Location = new Point(303, 86);
            groupBoxReg.Name = "groupBoxReg";
            groupBoxReg.Size = new Size(399, 452);
            groupBoxReg.TabIndex = 2;
            groupBoxReg.TabStop = false;
            groupBoxReg.Text = "Registration";
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.Sienna;
            btnReg.Cursor = Cursors.Hand;
            btnReg.ForeColor = SystemColors.ButtonFace;
            btnReg.Location = new Point(122, 412);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(138, 34);
            btnReg.TabIndex = 3;
            btnReg.Text = "Registration";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnReg_Click;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(122, 359);
            txtPwd.MaxLength = 10;
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(193, 29);
            txtPwd.TabIndex = 11;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Teacher", "Student" });
            cmbRole.Location = new Point(84, 298);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(87, 30);
            cmbRole.TabIndex = 10;
            // 
            // txtReg
            // 
            txtReg.Location = new Point(170, 234);
            txtReg.MaxLength = 10;
            txtReg.Name = "txtReg";
            txtReg.Size = new Size(193, 29);
            txtReg.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 29);
            textBox1.TabIndex = 8;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(134, 106);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(181, 29);
            txtLastname.TabIndex = 7;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(134, 48);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(181, 29);
            txtFirstname.TabIndex = 6;
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.Location = new Point(6, 362);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(94, 22);
            lblPwd.TabIndex = 5;
            lblPwd.Text = "Password";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(6, 298);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(51, 22);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role";
            // 
            // lblRegNo
            // 
            lblRegNo.AutoSize = true;
            lblRegNo.Location = new Point(6, 241);
            lblRegNo.Name = "lblRegNo";
            lblRegNo.Size = new Size(158, 22);
            lblRegNo.TabIndex = 3;
            lblRegNo.Text = "Registration No.";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(6, 176);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(98, 22);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(6, 106);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 22);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "LastName";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(6, 48);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(104, 22);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FirstName";
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1000, 550);
            Controls.Add(groupBoxReg);
            Controls.Add(panelAuth);
            Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Auth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auth";
            panelAuth.ResumeLayout(false);
            panelAuth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            groupBoxReg.ResumeLayout(false);
            groupBoxReg.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAuth;
        private Label lblregHeader;
        private PictureBox pbClose;
        private Label lblTitle;
        private GroupBox groupBoxReg;
        private Label lblRole;
        private Label lblRegNo;
        private Label lblUsername;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private Label lblPwd;
        private TextBox textBox1;
        private Button btnReg;
        private TextBox txtPwd;
        private ComboBox cmbRole;
        private TextBox txtReg;
    }
}