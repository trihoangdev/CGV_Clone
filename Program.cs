using CGV_Clone.Forms;
using System;
using System.Windows.Forms;

namespace CGV_Clone
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeFrm());
        }
    }
}
