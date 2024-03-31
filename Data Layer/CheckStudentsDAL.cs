using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Data_Layer
{
    internal class CheckStudentsDAL
    {
        public DataTable Select()
        {
            DataTable dt = new DataTable();

            using(MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "SELECT id, username, role, first_name, last_name, reg_no FROM users";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
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
    }
}
