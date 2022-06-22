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
    public partial class frmPersonsRoleOfPersons : Form
    {
        public frmPersonsRoleOfPersons()
        {
            InitializeComponent();
        }

        static SecurityService securityService = new SecurityService();
        FlameTradeDbEntities db = securityService.NewDatabaseEntity();

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPersonsRoleOfPersons_Paint(object sender, PaintEventArgs e)
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

        private void frmPersonsRoleOfPersons_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            personsFullNameViewBindingSource.DataSource = db.PersonsFullNameView.ToList();
            roleOfPersonsBindingSource.DataSource = db.RoleOfPersons.ToList();

            PersonsFullNameView persons = cmbPerson.SelectedItem as PersonsFullNameView;
            if (persons!=null)
            {
                personsRolesOfPersonsBindingSource.DataSource = db.PersonsRolesOfPersons.Where(pr=> pr.PersonsID==persons.ID).ToList();
            }
        }

        private void cmbPerson_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PersonsFullNameView persons = cmbPerson.SelectedItem as PersonsFullNameView;
            if (persons!=null)
            {
                personsRolesOfPersonsBindingSource.DataSource = db.PersonsRolesOfPersons.Where(pr => pr.PersonsID == persons.ID).ToList();
            }
        }

        private async void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (personsRolesOfPersonsBindingSource.DataSource!=null)
            {
                PersonsFullNameView persons = cmbPerson.SelectedItem as PersonsFullNameView;
                if (persons!=null)
                {
                    foreach (DataGridViewRow dgvr in dgvLeft.SelectedRows)
                    {
                        RoleOfPersons roleOfPersons = (RoleOfPersons)dgvr.DataBoundItem;
                        if (roleOfPersons!=null)
                        {
                            PersonsRolesOfPersons personsRolesOfPersons = db.PersonsRolesOfPersons.Where(prp => prp.RoleOfPersonID == roleOfPersons.ID && prp.PersonsID == persons.ID).SingleOrDefault();
                            if (personsRolesOfPersons==null)
                            {
                                PersonsRolesOfPersons personsRolesOfPersons1 = new PersonsRolesOfPersons() { PersonsID=persons.ID, RoleOfPersonID=roleOfPersons.ID };
                                db.PersonsRolesOfPersons.Add(personsRolesOfPersons1);
                            }
                        }
                    }
                    await db.SaveChangesAsync();
                    personsRolesOfPersonsBindingSource.DataSource = db.PersonsRolesOfPersons.Where(pr => pr.PersonsID == persons.ID).ToList();
                }
            }
        }

        private async void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (personsRolesOfPersonsBindingSource.DataSource!=null)
            {
                PersonsFullNameView persons = cmbPerson.SelectedItem as PersonsFullNameView;
                if (persons!=null)
                {
                    foreach (DataGridViewRow dgvr in dgvRight.SelectedRows)
                    {
                        PersonsRolesOfPersons personsRolesOfPersons = (PersonsRolesOfPersons)dgvr.DataBoundItem;
                        if (personsRolesOfPersons!=null)
                        {
                            personsRolesOfPersonsBindingSource.Remove(personsRolesOfPersons);
                            db.PersonsRolesOfPersons.Remove(personsRolesOfPersons );
                        }
                    }
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}
