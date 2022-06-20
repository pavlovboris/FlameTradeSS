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

        private static readonly SecurityService securityService = new SecurityService();
        static FlameTradeDbEntities db = securityService.NewDatabaseEntity();

        private  void frmFunctions_Load(object sender, EventArgs e)
        {
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
        }
    }
}
