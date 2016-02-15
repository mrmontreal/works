using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiTechDistribution
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
            //Application.Run(new GUI.ClientGUI.FormClient());
             //Application.Run(new GUI.OrderGUI.FormListOfOrder());
            Application.Run(new GUI.Main.fmLogin());
        }
    }
}
