//This App was written by Kanwar Arora for CSC-499-A1- Capstone
//This project would have not been possible without the Guidance from the Web Pages below 
//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/
//https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient?view=netframework-4.8
//https://msdn.microsoft.com/en-us/
//https://stackoverflow.com/
//http://www.sqlcourse.com
//https://textcraft.net/ - for logos 
//https://csharp-video-tutorials.blogspot.com/
//https://www.youtube.com/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPOS
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
            Application.Run(new frmMainLogin());
        }
    }
}
