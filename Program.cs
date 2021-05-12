using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiHocThem.Pages;

namespace QuanLiHocThem
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
            //Application.Run(new frmAdminClassDetail(1));
            //Application.Run(new frmQuanLiLopHoc());
            //Application.Run(new frmLogin());
            Application.Run(new frmMainAdmin());
            //Application.Run(new frmAdminClass());
        }
    }
}
