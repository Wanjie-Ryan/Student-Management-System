using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Student_Management_System.Logics;
using BCrypt.Net;
using System.Data;

namespace Student_Management_System.Data_Layer
{
    internal class AuthDAL
    {

        public bool Register(AuthBLL b)
        {
            bool isSuccess = false;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {

                    string hashedpassword = BCrypt.Net.BCrypt.EnhancedHashPassword(b.password);
                    //string hashedPassword = BCrypt.EnhancedHashPassword(b.Password);

                    string sql = "INSERT INTO users ( first_name, last_name, username, reg_no, role, password) VALUES ( @first_name, @last_name, @username, @reg_no, @role, @password )";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    //cmd.Parameters.AddWithValue("@id", b.id);
                    cmd.Parameters.AddWithValue("@first_name", b.firstname);
                    cmd.Parameters.AddWithValue("@last_name", b.lastname); 
                    cmd.Parameters.AddWithValue("@username", b.username);
                    cmd.Parameters.AddWithValue("@reg_no", b.regno);
                    cmd.Parameters.AddWithValue("@role", b.role);
                    cmd.Parameters.AddWithValue("@password", hashedpassword);
                    conn.Open();

                    //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    //DataTable dt = new DataTable();
                    //adapter.Fill(dt);

                    //if (dt.Rows.Count>0)
                    //{
                    //    isSuccess = true;
                    //}
                    //else
                    //{
                    //    isSuccess = false;
                    //}

                    int rows = cmd.ExecuteNonQuery();
                    if(rows > 0)
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
    }
}
