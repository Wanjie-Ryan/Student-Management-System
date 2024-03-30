using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_System.Data_Layer;
using Student_Management_System.Logics;

namespace Student_Management_System.UI
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        AuthBLL b = new AuthBLL();
        AuthDAL adal = new AuthDAL();

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            b.firstname = txtFirstname.Text;
            b.lastname = txtLastname.Text;
            b.username = txtusername.Text;
            b.regno = txtReg.Text;
            b.role = cmbRole.Text;
            b.password = txtPwd.Text;

            bool Success = adal.Register(b);

            if (Success == true)
            {
                MessageBox.Show(
                    "Registration Successful",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Login login = new Login();
                login.Show();
            }
            else
            {
                MessageBox.Show(
                    "Registration Failed",
                    "Failure",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void lblTxtLoginLink_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
        }
    }
}
