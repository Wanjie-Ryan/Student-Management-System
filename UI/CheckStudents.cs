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
        CheckStudentsBLL cb = new CheckStudentsBLL();
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

        private void dataGridCheckStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Clear()
        {
            txtStudentID.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtUsername.Text = "";
            txtRegno.Text = "";
            cmbRole.Text = "";
        }

        private void dataGridCheckStudents_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rows = e.RowIndex;
            txtStudentID.Text = dataGridCheckStudents.Rows[rows].Cells[0].Value.ToString();
            txtFirstname.Text = dataGridCheckStudents.Rows[rows].Cells[1].Value.ToString();
            txtLastname.Text = dataGridCheckStudents.Rows[rows].Cells[4].Value.ToString();
            txtUsername.Text = dataGridCheckStudents.Rows[rows].Cells[1].Value.ToString();
            txtRegno.Text = dataGridCheckStudents.Rows[rows].Cells[4].Value.ToString();
            cmbRole.Text = dataGridCheckStudents.Rows[rows].Cells[2].Value.ToString();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword != null)
            {
                DataTable dt = cdal.Search(keyword);
                dataGridCheckStudents.DataSource = dt;
            }
            else
            {
                DataTable dt = cdal.Select();
                dataGridCheckStudents.DataSource = dt;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
