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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pbDashClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher teacherForm = new Teacher();
            teacherForm.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student studentForm = new Student();
            studentForm.Show();
        }
    }
}
