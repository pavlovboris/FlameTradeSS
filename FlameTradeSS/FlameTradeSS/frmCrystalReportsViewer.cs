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
           /* string connectionString = @"Data Source=definedsolutions-sql-server.database.windows.net;Initial Catalog=FlameTradeDb;User ID=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless;"; 


            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            SqlCommand mySqlCommand = new SqlCommand("select * from Documents;select * from DocumentSequences",mySqlConnection);
            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(mySqlCommand);

            DataSet ds = new DataSet();

            mySqlDataAdapter.Fill(ds);*/


           // rptLoadSingleDocument2.SetDatabaseLogon("CstmDBDefSol","uncloak-TAIWAN-peccary-listless");
            /*rptLoadSingleDocument1.Database.Tables["Documents"].SetDataSource(ds.Tables["Documents"]);
            rptLoadSingleDocument1.Database.Tables["DocumentSequences"].SetDataSource(ds.Tables["DocumentSequences"]);*/

        }
    }
}
