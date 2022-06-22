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
    public partial class frmPartnersPersons : Form
    {
        public frmPartnersPersons()
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


        static SecurityService securityService = new SecurityService();
        FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        private void frmPartnersPersons_Paint(object sender, PaintEventArgs e)
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

        private void frmPartnersPersons_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            partnersBindingSource.DataSource = db.Partners.ToList();
            personsFullNameViewBindingSource.DataSource = db.PersonsFullNameView.ToList();
            personsBindingSource.DataSource = db.Persons.ToList();

            Partners partners = cmbPartner.SelectedItem as Partners;
            if(partners!=null)
            {
                partnerPersonsBindingSource.DataSource = db.PartnerPersons.Where(pp=> pp.PartnerID == partners.ID).ToList();
            }

            try
            {
                CommonTasks.ReadDataGridViewSetting(dgvLeft, Name + dgvLeft.Name + CurrentSessionData.CurrentUser.UserName);
                CommonTasks.ReadDataGridViewSetting(dgvRight, Name + dgvRight.Name + CurrentSessionData.CurrentUser.UserName);
            } catch
            {

            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbPartner_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Partners partners = cmbPartner.SelectedItem as Partners;
            if (partners != null)
            {
                partnerPersonsBindingSource.DataSource = db.PartnerPersons.Where(pp => pp.PartnerID == partners.ID).ToList();
            }
        }

        private async void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (partnerPersonsBindingSource.DataSource!=null)
            {
                Partners partners = cmbPartner.SelectedItem as Partners;
                if (partners != null)
                {
                    foreach (DataGridViewRow dgvr in dgvLeft.SelectedRows)
                    {
                        Persons p = dgvr.DataBoundItem as Persons;
                        if (p != null)
                        {
                            PartnerPersons pp = db.PartnerPersons.Where(prp => prp.PersonID == p.ID & prp.PartnerID == partners.ID).SingleOrDefault();
                            if (pp == null)
                            {
                                PartnerPersons newPP = new PartnerPersons() { PartnerID = partners.ID, PersonID = p.ID };
                                db.PartnerPersons.Add(newPP);
                                partnerPersonsBindingSource.Add(newPP);
                            }
                        }
                    }
                    try
                    {
                        await db.SaveChangesAsync();
                    }
                    catch { CommonTasks.SendErrorMsg("Нещо се обърка, промените НЕ са запаметени"); }
                }
            }
        }

        private async void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (partnerPersonsBindingSource.DataSource != null)
            {
                Partners partners = cmbPartner.SelectedItem as Partners;
                if (partners != null)
                {
                    foreach (DataGridViewRow dgvr in dgvRight.SelectedRows)
                    {
                        PartnerPersons partnerPersons = dgvr.DataBoundItem as PartnerPersons;
                        if (partnerPersons != null)
                        {
                            db.PartnerPersons.Remove(partnerPersons);
                            partnerPersonsBindingSource.Remove(partnerPersons);
                        }
                    }
                    try
                    {
                        await db.SaveChangesAsync();
                    } catch { CommonTasks.SendErrorMsg("Нещо се обърка, промените НЕ са запаметени"); }
                }
            }
        }

        private void frmPartnersPersons_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CommonTasks.WriteGrideViewSetting(dgvLeft, Name + dgvLeft.Name + CurrentSessionData.CurrentUser.UserName);
                CommonTasks.WriteGrideViewSetting(dgvRight, Name + dgvRight.Name + CurrentSessionData.CurrentUser.UserName);
            }
            catch
            {

            }
        }
    }
}
