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
    public partial class frmPersons : Form
    {
        public frmPersons()
        {
            InitializeComponent();
        }

        private static readonly SecurityService securityService = new SecurityService();
        static FlameTradeDbEntities db = securityService.NewDatabaseEntity();


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

        private void frmPersons_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            personsBindingSource.DataSource = db.Persons.ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPersons_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            // create  a  pen object with which to draw
            Pen p = new Pen(Color.LightBlue, 2);  // draw the line
                                                  // call a member of the graphics class
                                                  // g.DrawLine(p,2,2, Size.Width-4,2);
                                                  //g.DrawLine(p,2,2,2,Size.Height-4);
            Rectangle r = new Rectangle(2, 2, Size.Width - 4, Size.Height - 4);
            g.DrawRectangle(p, r);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Persons persons = new Persons();
            personsBindingSource.Add(persons);
            db.Persons.Add(persons);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да запазите всички промени?")==true)
            {
                try
                {
                    personsBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                    CommonTasks.SendInfoMsg("Промените са запаметени успешно");
                }
                catch (Exception ex)
                {
                    CommonTasks.SendErrorMsg("Нещо се обърка, промените НЕ бяха запаметени!!!");
                    if (CommonTasks.SendWarningMsg("Искате ли да разгледате детайлите на грешката?") == true)
                    {
                        CommonTasks.SendErrorMsg(ex.Message);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Persons perosonForRemoving = dgvPersons.CurrentRow.DataBoundItem as Persons;
            if (CommonTasks.SendWarningMsg("Сугурни ли сте, че искате да маркираният потребител : " + perosonForRemoving.PersonName +" "+ perosonForRemoving.PersonSureName+ "?") == true)
            {
                personsBindingSource.Remove(perosonForRemoving);
                db.Persons.Remove(perosonForRemoving);
            }
        }
    }
}
