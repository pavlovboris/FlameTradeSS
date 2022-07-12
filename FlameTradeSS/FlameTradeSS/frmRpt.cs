using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameTradeSS
{
    public partial class frmRpt : Form
    {
        public frmRpt()
        {
            InitializeComponent();
        }

        public FlameTradeDbEntities db;
        public Documents document;
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rptOffers crystalReport = new rptOffers();

            

            DataSet ds = new DataSet();

            using (var sqlCommand = db.Database.Connection.CreateCommand())
            {
                sqlCommand.CommandText = "Select * from Documents where Documents.ID="+document.ID+";Select * from DocumentsProjects; Select * from DocumentSequences;Select * from DocumentTransactions;Select * from Partners;Select * from Project;Select * from TransactionsType;Select * from TransactionLines;Select * from Surfaces";

                using (DbDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = sqlCommand;
                    da.Fill(ds);

                }
            }



            crystalReport.SetDatabaseLogon("CstmDBDefSol", "uncloak-TAIWAN-peccary-listless");
            crystalReport.Database.Tables["Documents"].SetDataSource(ds.Tables["Documents"]);
            crystalReport.Database.Tables["DocumentsProjects"].SetDataSource(ds.Tables["DocumentsProjects"]);
            crystalReport.Database.Tables["DocumentSequences"].SetDataSource(ds.Tables["DocumentSequences"]);
            crystalReport.Database.Tables["DocumentTransactions"].SetDataSource(ds.Tables["DocumentTransactions"]);
            crystalReport.Database.Tables["Partners"].SetDataSource(ds.Tables["Partners"]);
            crystalReport.Database.Tables["Project"].SetDataSource(ds.Tables["Project"]);
            crystalReport.Database.Tables["TransactionsType"].SetDataSource(ds.Tables["TransactionsType"]);
            crystalReport.Database.Tables["TransactionLines"].SetDataSource(ds.Tables["TransactionLines"]);
            crystalReport.Database.Tables["Surfaces"].SetDataSource(ds.Tables["Surfaces"]);

           

            crystalReportViewer1.ReportSource = crystalReport;
        }
    }
}
