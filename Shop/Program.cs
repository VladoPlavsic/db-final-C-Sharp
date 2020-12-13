using System;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace Shop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Get configuration for database connection*/
            SQL.m_Source = ConfigurationManager.AppSettings.Get("Source");
            SQL.m_Catalog = ConfigurationManager.AppSettings.Get("Catalog");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage());
        }
    }
}
