using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameTradeSS
{
    public partial class frmAdminTools : Form
    {
        public frmAdminTools()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsersManagement usersManagement = new frmUsersManagement();
            usersManagement.Show();
        }
    }
}
