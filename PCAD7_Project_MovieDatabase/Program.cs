using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCAD7_Project_MovieDatabase
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
            Application.Run(new Form2()); 
            /*changed the parameter to Form2 so that it'll display first when the programs starts.
            The reason I had to do this is because I built the welcome page after creating the main page with the all the functions.*/
        }
    }
}
