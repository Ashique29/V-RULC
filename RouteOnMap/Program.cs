using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;

namespace RouteOnMap
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
            UserInput userInput = new UserInput();
            var f1 = new Form1();
            f1.UserInput = userInput;
            f1.ShowDialog();
            var f2 = new Form2();
            f2.UserInput = userInput;
            f2.ShowDialog();
            //Application.Run(new Form1());
        }
    }
}
