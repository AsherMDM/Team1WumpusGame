using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1WumpusGame
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
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.ShowDialog();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.ShowDialog();
            Application.Run();
        }
    }
}
