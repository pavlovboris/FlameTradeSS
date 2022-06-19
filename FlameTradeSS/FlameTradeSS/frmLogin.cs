using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FlameTradeSS.SecurityService;

namespace FlameTradeSS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private const int cCaption = 300;   // Caption bar height;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private static frmLogin _instance;

        public Users UserInfo { get; set; }

        public static frmLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmLogin();
                return _instance;
            }
        }
       
        public static SecurityService securityService = new SecurityService();

        FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string userName = "su";
            string password = "cscs";

            Users result = securityService.LoggedUser(db, userName, password);

            if (result != null)
            {
                UserInfo = result;

            } else
            {
                MessageBox.Show("Потребителското име или паролата са изписани грешно, моля опитайте отново", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
