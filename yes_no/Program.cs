using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using yes_no.Quection;
using yes_no.Answer;
using yes_no.Main;

namespace yes_no
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
            Application.Run(new Home ());
        }
    }
}
