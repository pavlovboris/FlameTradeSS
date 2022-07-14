using CrystalDecisions.Shared;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameTradeSS
{
    public partial class frmCrystalReportsViewer : Form
    {
        public frmCrystalReportsViewer()
        {
            InitializeComponent();
        }

        public FlameTradeDbEntities db;
        public Documents document;

        private void crystalReportViewer_Load(object sender, EventArgs e)
        {

            Partners mainCompany = db.Partners.Where(p => p.PartnerGroups.GroupName == "Main Company").FirstOrDefault();

           // crystalReportViewer.ReportSource = null;
            rptSingleDocumentOffer1.SetParameterValue(0, document.ID);
            crystalReportViewer.ReportSource = rptSingleDocumentOffer1;
            rptSingleDocumentOffer1.DataDefinition.FormulaFields["MainCompany"].Text = "\""+mainCompany.Partner_name+"\"";
           
        }

    }
}
