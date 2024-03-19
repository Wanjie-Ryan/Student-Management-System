namespace Student_Management_System.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panelLogin = new Panel();
            pbClose = new PictureBox();
            lblLogHeader = new Label();
            groupBoxLogin = new GroupBox();
            btnLogin = new Button();
            txtPwd = new TextBox();
            lblPwd = new Label();
            txtusername = new TextBox();
            lblUsername = new Label();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Coral;
            panelLogin.Controls.Add(pbClose);
            panelLogin.Controls.Add(lblLogHeader);
            panelLogin.Location = new Point(2, 2);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(896, 56);
            panelLogin.TabIndex = 0;
            // 
            // pbClose
            // 
            pbClose.Cursor = Cursors.Hand;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(861, 17);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(35, 34);
            pbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClose.TabIndex = 2;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // lblLogHeader
            // 
            lblLogHeader.AutoSize = true;
            lblLogHeader.Location = new Point(315, 17);
            lblLogHeader.Name = "lblLogHeader";
            lblLogHeader.Size = new Size(266, 22);
            lblLogHeader.TabIndex = 1;
            lblLogHeader.Text = "Student Management System";
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.BackColor = Color.WhiteSmoke;
            groupBoxLogin.Controls.Add(btnLogin);
            groupBoxLogin.Controls.Add(txtPwd);
            groupBoxLogin.Controls.Add(lblPwd);
            groupBoxLogin.Controls.Add(txtusername);
            groupBoxLogin.Controls.Add(lblUsername);
            groupBoxLogin.Location = new Point(283, 78);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(372, 285);
            groupBoxLogin.TabIndex = 1;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Sienna;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(106, 204);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(138, 34);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(126, 122);
            txtPwd.MaxLength = 10;
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(193, 29);
            txtPwd.TabIndex = 13;
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.Location = new Point(10, 125);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(94, 22);
            lblPwd.TabIndex = 12;
            lblPwd.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(128, 50);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(181, 29);
            txtusername.TabIndex = 10;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(6, 50);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(98, 22);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(900, 449);
            Controls.Add(groupBoxLogin);
            Controls.Add(panelLogin);
            Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label lblLogHeader;
        private PictureBox pbClose;
        private GroupBox groupBoxLogin;
        private TextBox txtusername;
        private Label lblUsername;
        private TextBox txtPwd;
        private Label lblPwd;
        private Button btnLogin;
    }
}