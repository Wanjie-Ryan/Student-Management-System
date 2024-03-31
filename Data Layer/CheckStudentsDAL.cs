using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Management_System.Data_Layer
{
    internal class CheckStudentsDAL
    {
        public DataTable Select()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql =
                        "SELECT id, username, role, first_name, last_name, reg_no FROM users WHERE role = 'student'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex)
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

        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql =
                        "SELECT id, username, role, first_name, last_name, reg_no FROM users WHERE username LIKE '%"
                        + keyword
                        + "%' OR first_name LIKE '%"
                        + keyword
                        + "%' OR last_name LIKE '%"
                        + keyword
                        + "%' OR reg_no LIKE '%"
                        + keyword
                        + "%' ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex)
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
    }
}
