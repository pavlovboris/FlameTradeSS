using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlameTradeSS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            
            SecurityService getDb = new SecurityService();
            FlameTradeDbEntities db = getDb.NewDatabaseEntity();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadExit += Application_ThreadExit;

            if (SecurityService.ConnectionCheck(db))
            {
                Application.Run(new frmLogin());
            } else
            {
                if (MessageBox.Show("Не може да бъде осъществена връзка с базата данни. Възможно е, проблем с интернет връзката да предизвиква тази грешка. \n Искате ли да опитате отново?", "FlameTradeSS.exe Critical Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    Application.Restart();
                } else
                {
                    Application.Exit();
                } ;
            }
        }

        private static void Application_ThreadExit(object sender, EventArgs e)
        {
            SecurityService securityService = new SecurityService();
            securityService.userLogOut();
        }
    }
}
