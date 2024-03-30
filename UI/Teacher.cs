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

        public void Clear()
        {
            txtAssignmentID.Text = "";
            txtAssName.Text = "";
            txtAssDesc.Text = "";
            cmbSubject.Text = "";
            dateTimePickerAssignment.Value = DateTime.Now;
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
                Clear();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            b.id = int.Parse(txtAssignmentID.Text);
            b.name = txtAssName.Text;
            b.description = txtAssDesc.Text;
            b.subject = cmbSubject.Text;
            b.deadline = dateTimePickerAssignment.Value;

            bool success = d.Update(b);

            if (success == true)
            {
                MessageBox.Show(
                    "Assignment updated",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                DataTable dt = d.Select();
                dataGridAssignments.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show(
                    "Failed to update assignment",
                    "Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dataGridAssignments_RowHeaderMouseClick(
            object sender,
            DataGridViewCellMouseEventArgs e
        )
        {
            int rowIndex = e.RowIndex;
            txtAssignmentID.Text = dataGridAssignments.Rows[rowIndex].Cells[0].Value.ToString();
            txtAssName.Text = dataGridAssignments.Rows[rowIndex].Cells[1].Value.ToString();
            txtAssDesc.Text = dataGridAssignments.Rows[rowIndex].Cells[2].Value.ToString();
            cmbSubject.Text = dataGridAssignments.Rows[rowIndex].Cells[3].Value.ToString();
            dateTimePickerAssignment.Value = Convert.ToDateTime(
                dataGridAssignments.Rows[rowIndex].Cells[4].Value
            );
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            DataTable dt = d.Select();
            dataGridAssignments.DataSource = dt;
        }
    }
}
