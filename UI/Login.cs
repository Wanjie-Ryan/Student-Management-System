using Student_Management_System.Data_Layer;
using Student_Management_System.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        LoginBLL b = new LoginBLL();
        LoginDAL logdal = new LoginDAL();


        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            b.username = txtusername.Text;



            //Dashboard dashboard = new Dashboard();
            //dashboard.Show();
        }
    }
}
