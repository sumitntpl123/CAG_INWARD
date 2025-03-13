using System;
using System.Windows.Forms;
using NovaNet.Utils;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Data.Odbc;
using System.Data;

namespace CAG_INWARD
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mdiMain());
        }
    }
}
