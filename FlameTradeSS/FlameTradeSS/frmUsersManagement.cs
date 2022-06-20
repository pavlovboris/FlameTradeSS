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
    public partial class frmUsersManagement : Form
    {
        public frmUsersManagement()
        {
            InitializeComponent();
        }
        private static readonly SecurityService securityService = new SecurityService();   
        static FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
            if(CurrentSessionData.CurrentUser.RoleID!=1)
            {
                usersBindingSource.DataSource = db.Users.Where(u=> u.RoleID!=1).ToList();
            } else
            {
                usersBindingSource.DataSource = db.Users.ToList();
            }
 
            rolesBindingSource.DataSource = db.Roles.ToList();
            personsBindingSource.DataSource = db.Persons.ToList();
            
        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }
    }
}
