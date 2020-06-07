using System;
using System.Threading;
using System.Windows.Forms;

namespace Insectia
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

            bool createNew;
            Mutex mut = new Mutex(false, Application.ProductName, out createNew);
            if (createNew)
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Aplikace je již spuštěna!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static readonly string message = "Kvůli následujícím chybám nebylo možné provést akci:\n";
    }
}
