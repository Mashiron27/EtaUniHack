using System;
using System.Windows.Forms;

namespace EasyTestApp
{
    static class Program
    {
        public static string DB_ConnectionString_EasyTestApp = @"Data Source=LPTVIVIANACSA\SQLSERVER01;Initial Catalog=EasyTestDB;Integrated Security=True";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sign_In());
        }
    }
}
