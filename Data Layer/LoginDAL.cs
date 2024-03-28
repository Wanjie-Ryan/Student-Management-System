using MySql.Data.MySqlClient;
using Student_Management_System.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using MySqlX.XDevAPI.Common;


namespace Student_Management_System.Data_Layer
{
    internal class LoginDAL
    {
        public bool Login(LoginBLL b)
        {
            bool isSuccess = false;

            using(MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "SELECT password FROM users WHERE username = @username ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@username", b.username);

                    conn.Open();

                    //string hashedPassword = cmd.ExecuteScalar().ToString();

                    //if (hashedPassword != null) // Check if matching user was found
                    //{
                    //    isSuccess = BCrypt.EnhancedVerify(b.password, hashedPassword); // Verify password
                    //}


                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string hashedPassword = result.ToString();

                        // Verify password
                        isSuccess = BCrypt.Net.BCrypt.Verify(b.password, hashedPassword);
                    }
                    else
                    {
                        // Username not found
                        Console.WriteLine("Username not found.");
                    }

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Message);
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
