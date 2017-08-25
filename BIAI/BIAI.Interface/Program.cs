using BIAI.Data;
using BIAI.Data.Model;
using System;
using System.Windows.Forms;

namespace BIAI.Interface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var db = new GlobalTerrorismContext())
            {
                db.Countries.Add(new Country());
            }
            Application.Run(new Form1());
        }
    }
}
