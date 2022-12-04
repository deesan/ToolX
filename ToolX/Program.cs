using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace ToolX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                string[] files = args;
                NotePad.NotePadMain mf = new NotePad.NotePadMain();
                mf.IsArgumentNull = false;
                mf.OpenAssociatedFiles_WhenApplicationStarts(files);
                Application.EnableVisualStyles();
                Application.Run(mf);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new NotePad.NotePadMain());
            }
        }
    }
}
