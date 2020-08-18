using System;
using System.Windows.Forms;

namespace BiosupCS
{
    static class BIOSUP_Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BIOSUP_GUI());
        }
    }
}
