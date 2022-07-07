using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameTradeSS
{
    public partial class frmFunctions : Form
    {
        public frmFunctions()
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

        private static readonly SecurityService securityService = new SecurityService();
        static FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        private  void frmFunctions_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            functionsBindingSource.DataSource = db.Functions.ToList();

            List<AppForms> formsList = new List<AppForms>();
            Type formType = typeof(Form);
            formsList.Add(new AppForms() { Name = "" });

            List<AppForms> controlsList = new List<AppForms>();
            Type controlType = typeof(Control);

            controlsList.Add(new AppForms() { Name = "" });

            foreach (Type form in Assembly.GetExecutingAssembly().GetTypes())
            {
               if(formType.IsAssignableFrom(form))
                {
                    formsList.Add(new AppForms() {  Name=form.Name});

                    var controlsForm = Activator.CreateInstance(form) as Form ;

                    foreach (Control control in controlsForm.Controls)
                    {
                        AppForms currentControl = controlsList.Where(c => c.Name == control.Name).FirstOrDefault();
                        if (control.Controls.Count>0)
                        {
                            foreach (Control ctrl in control.Controls)
                            {
                                AppForms currentSubControl = controlsList.Where(c => c.Name == ctrl.Name).FirstOrDefault();
                                if (!controlsList.Contains(currentSubControl))
                                {
                                    controlsList.Add(new AppForms() { Name = ctrl.Name }) ;
                                }
                            }
                        }
                        if (!controlsList.Contains(currentControl))
                        {
                            controlsList.Add(new AppForms() { Name = control.Name });
                        }
                    }
                } 
            }
            formNameDataGridViewTextBoxColumn.DataSource = formsList;
            formNameDataGridViewTextBoxColumn.ValueMember = "Name";
            formNameDataGridViewTextBoxColumn.DisplayMember = "Name";

            controllNameDataGridViewTextBoxColumn.DataSource = controlsList;
            controllNameDataGridViewTextBoxColumn.ValueMember = "Name";
            controllNameDataGridViewTextBoxColumn.DisplayMember= "Name";

            try
            {
                CommonTasks.ReadDataGridViewSetting(dgvFunctions, Name + dgvFunctions.Name + CurrentSessionData.CurrentUser.UserName);
            } catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();
            functionsBindingSource.Add(functions);
            db.Functions.Add(functions);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Functions functions = dgvFunctions.CurrentRow.DataBoundItem as Functions;
            if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да премахнете избраната рестрикция : "+functions.FunctionName+"?")==true)
            {
                if (dgvFunctions.CurrentRow.Index != -1)
                {
                    if (functions != null)
                    {
                        functionsBindingSource.Remove(functions);
                        db.Functions.Remove(functions);
                    }
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да запазите промените")==true)
            {
                try
                {
                    await db.SaveChangesAsync();
                    CommonTasks.SendInfoMsg("Промените са запазени успешно");
                } catch (Exception ex)
                {
                    CommonTasks.SendErrorMsg("Промените НЕ бяха запаметени!!! \n Ако сте премахнали функция, възможно е тя да е присвоена на Роля и за това да не може да бъде изтрита");
                    if(CommonTasks.SendWarningMsg("Искате ли да видите детайлите")==true)
                    {
                        CommonTasks.SendErrorMsg(ex.Message);
                    }
                }                
            }
        }

        private void frmFunctions_Paint(object sender, PaintEventArgs e)
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

        private void frmFunctions_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CommonTasks.WriteGrideViewSetting(dgvFunctions, Name + dgvFunctions.Name + CurrentSessionData.CurrentUser.UserName);
            } catch { }
        }
    }
}
