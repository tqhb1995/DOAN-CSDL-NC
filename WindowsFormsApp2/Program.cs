using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace WindowsFormsApp2
{
    
    public  class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       public static string username = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TimKiemKhachSan());
        }
    }
}
