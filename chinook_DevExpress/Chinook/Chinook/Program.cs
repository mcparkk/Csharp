using Chinook.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook
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
            //Application.Run(new AlbumListForm());
            //Application.Run(new TemplatePracticeForm());
            Application.Run(new Form1());
            //Application.Run(new AlbumChartForm());
            //Application.Run(new AlbumForm(null));
        }
    }
}
