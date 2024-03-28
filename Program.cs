using Student_Management_System.UI;
using System;
using System.Windows.Forms;

namespace Student_Management_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
         // Define connection string variables
        private static string server = "localhost";
        private static string database = "schoolmanagement";
        private static string username = "root";
        private static string password = "1234567890";

        public static string GetConnectionString()
        {
            // Construct and return the connection string
            return $"server={server};database={database};uid={username};password={password};";
        }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Auth());
        }
    }
}