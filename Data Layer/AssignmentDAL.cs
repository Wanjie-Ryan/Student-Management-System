using MySql.Data.MySqlClient;
using Student_Management_System.Logics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Data_Layer
{
    internal class AssignmentDAL
    {

        public DataTable Select()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "SELECT * FROM assignment";
                    MySqlCommand cmd = new MySqlCommand(sql,conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return dt;
        }
       public bool Insert(AssignmentBLL b)
        {
            bool isSuccess = false;

            using(MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "INSERT INTO assignment (name, description, subject, deadline) VALUES (@name, @description, @subject, @deadline)";
                    MySqlCommand cmd = new MySqlCommand(sql,conn);

                    cmd.Parameters.AddWithValue("@name", b.name);
                    cmd.Parameters.AddWithValue("@description", b.description);
                    cmd.Parameters.AddWithValue("@subject", b.subject);
                    cmd.Parameters.AddWithValue("@deadline", b.deadline);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return isSuccess;
        }

        public bool Update(AssignmentBLL b)
        {
            bool isSuccess = false;

            using(MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return isSuccess;
        }
    }
}
