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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        AssignmentBLL b = new AssignmentBLL();
        AssignmentDAL d = new AssignmentDAL();

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void assignmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckStudents checkStudents = new CheckStudents();
            checkStudents.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            b.name = txtAssName.Text;
            b.description = txtAssDesc.Text;
            b.subject = cmbSubject.Text;
            b.deadline = dateTimePickerAssignment.Value;

            bool success = d.Insert(b);

            if (success == true)
            {
                MessageBox.Show(
                    "Assigned added",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                DataTable dt = d.Select();
                dataGridAssignments.DataSource = dt;
            }
            else
            {
                MessageBox.Show(
                    "Failed to add assignment",
                    "Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
