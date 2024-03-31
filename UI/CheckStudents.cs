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
    public partial class CheckStudents : Form
    {
        public CheckStudents()
        {
            InitializeComponent();
        }
        CheckStudentsBLL cb =  new CheckStudentsBLL();
        CheckStudentsDAL cdal = new CheckStudentsDAL();

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChecStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher teacherForm = new Teacher();
            teacherForm.Show();
        }

        private void txtRegno_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckStudents_Load(object sender, EventArgs e)
        {
            DataTable dt = cdal.Select();
            dataGridCheckStudents.DataSource = dt;
        }
    }
}
