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
    public partial class frmDocuments : Form
    {
        public frmDocuments()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
        }

       

        private void frmDocuments_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CommonTasks.WriteGrideViewSetting(dgvDocuments, Name + dgvDocuments.Name + CurrentSessionData.CurrentUser.UserName);
            }
            catch { }

            Properties.Settings.Default.frmDocumentsState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.frmDocumentsLocation = this.Location;
                Properties.Settings.Default.frmDocumentsSize = this.Size;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.frmDocumentsLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.frmDocumentsSize = this.RestoreBounds.Size;
            }

            // don't forget to save the settings
            Properties.Settings.Default.Save();
            dgvDocuments.Dispose();
        }

        private const int cGrip = 10;      // Grip size
        private const int cCaption = 600;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            // create  a  pen object with which to draw
            Pen p = new Pen(Color.LightBlue, 2);  // draw the line
                                                  // call a member of the graphics class
                                                  // g.DrawLine(p,2,2, Size.Width-4,2);
                                                  //g.DrawLine(p,2,2,2,Size.Height-4);
            Rectangle r = new Rectangle(2, 2, Size.Width - 4, Size.Height - 4);
            g.DrawRectangle(p, r);

            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            // rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            //  e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
            
        }

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
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private static readonly SecurityService securityService = new SecurityService();
        FlameTradeDbEntities db = securityService.NewDatabaseEntity();


        private void frmDocuments_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Hide();
            
            CommonTasks.RestoreForm(this, Properties.Settings.Default.frmDocumentsSize, Properties.Settings.Default.frmDocumentsState, Properties.Settings.Default.frmDocumentsLocation);

            cmbIsCanceled.SelectedIndex= 0;

            dgvDocuments.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDocuments.RowHeadersVisible = false;

            

            documentsBindingSource.DataSource = db.Documents.ToList();
            partnersBindingSource.DataSource = db.Partners.ToList();
            costingModelsBindingSource.DataSource = db.CostingModels.ToList();
            usersBindingSource.DataSource = db.Users.ToList();
            documentSequencesBindingSource.DataSource = db.DocumentSequences.ToList();
            documentSequencesBindingSource1.DataSource = db.DocumentSequences.ToList();
            DocumentSequences nullDocumentSequence = new DocumentSequences();
            nullDocumentSequence.SequenceName = "All";
            documentSequencesBindingSource1.Add(nullDocumentSequence);
            //dgvDocuments.RowHeadersVisible = true;
            
            
            
            //dgvDocuments.Refresh();
            
            cmbSequence.SelectedItem = nullDocumentSequence;

           

            Cursor.Current = Cursors.Default;
            Show();

            try
            {
                CommonTasks.ReadDataGridViewSetting(dgvDocuments, Name + dgvDocuments.Name + CurrentSessionData.CurrentUser.UserName);
            }
            catch
            {

            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {


            Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

            }
            else
            {
                WindowState = FormWindowState.Maximized;
                
            }
        }

        private void dgvDocuments_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {

            cmbSequence.Width = documentSequenceIDDataGridViewTextBoxColumn.Width;
            cmbIsCanceled.Width = isCanceledDataGridViewTextBoxColumn.Width;


            Rectangle pointIsCanceled = new Rectangle();
            Rectangle pointSequence = new Rectangle();

            pointIsCanceled = dgvDocuments.GetColumnDisplayRectangle(isCanceledDataGridViewTextBoxColumn.Index, false);
            pointSequence = dgvDocuments.GetColumnDisplayRectangle(documentSequenceIDDataGridViewTextBoxColumn.Index, false);

            pointIsCanceled.Y += 100;
            pointIsCanceled.X += 12;

            pointSequence.Y += 100;
            pointSequence.X += 12;

            cmbIsCanceled.Location = pointIsCanceled.Location;
            cmbSequence.Location = pointSequence.Location;

            if (isCanceledDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbIsCanceled.Visible = false;
            }
            else { cmbIsCanceled.Visible = true; }

            if (documentSequenceIDDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbSequence.Visible = false;
            }
            else { cmbSequence.Visible = true; }
        }

        private void dgvDocuments_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle pointIsCanceled = new Rectangle();
            Rectangle pointSequence = new Rectangle();

            pointIsCanceled = dgvDocuments.GetColumnDisplayRectangle(isCanceledDataGridViewTextBoxColumn.Index, false);
            pointSequence = dgvDocuments.GetColumnDisplayRectangle(documentSequenceIDDataGridViewTextBoxColumn.Index, false);

            pointIsCanceled.Y += 100;
            pointIsCanceled.X += 12;

            pointSequence.Y += 100;
            pointSequence.X += 12;

            cmbIsCanceled.Location = pointIsCanceled.Location;
            cmbSequence.Location = pointSequence.Location;

            if (isCanceledDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbIsCanceled.Visible = false;
            }
            else { cmbIsCanceled.Visible = true; }

            if (documentSequenceIDDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbSequence.Visible = false;
            }
            else { cmbSequence.Visible = true; }
        }

        private void dgvDocuments_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle pointIsCanceled = new Rectangle();
            Rectangle pointSequence = new Rectangle();

            pointIsCanceled = dgvDocuments.GetColumnDisplayRectangle(isCanceledDataGridViewTextBoxColumn.Index, false);
            pointSequence = dgvDocuments.GetColumnDisplayRectangle(documentSequenceIDDataGridViewTextBoxColumn.Index, false);

            pointIsCanceled.Y += 100;
            pointIsCanceled.X += 12;

            pointSequence.Y += 100;
            pointSequence.X += 12;

            cmbIsCanceled.Location = pointIsCanceled.Location;
            cmbSequence.Location = pointSequence.Location;

            if (isCanceledDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbIsCanceled.Visible = false;
            }
            else { cmbIsCanceled.Visible = true; }

            if (documentSequenceIDDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbSequence.Visible = false;
            }
            else { cmbSequence.Visible = true; }

        }

        private void frmDocuments_SizeChanged(object sender, EventArgs e)
        {
            Rectangle pointIsCanceled = new Rectangle();
            Rectangle pointSequence = new Rectangle();

            pointIsCanceled = dgvDocuments.GetColumnDisplayRectangle(isCanceledDataGridViewTextBoxColumn.Index, false);
            pointSequence = dgvDocuments.GetColumnDisplayRectangle(documentSequenceIDDataGridViewTextBoxColumn.Index, false);

            pointIsCanceled.Y += 100;
            pointIsCanceled.X += 12;

            pointSequence.Y += 100;
            pointSequence.X += 12;

            cmbIsCanceled.Location = pointIsCanceled.Location;
            cmbSequence.Location = pointSequence.Location;

            if (isCanceledDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbIsCanceled.Visible = false;
            }
            else { cmbIsCanceled.Visible = true; }

            if (documentSequenceIDDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbSequence.Visible = false;
            }
            else { cmbSequence.Visible = true; }
        }

        private void cmbIsCanceled_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbSequence.SelectedValue == null || cmbSequence.SelectedValue.ToString()=="0" )
            {
                if (string.IsNullOrEmpty(txtFilter.Text))
                {

                    switch (cmbIsCanceled.Text)
                    {
                        case "Не":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 0).ToList();
                            break;
                        case "Да":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 1).ToList();
                            break;
                        case "Всички":
                            documentsBindingSource.DataSource = db.Documents.ToList();
                            break;
                    }
                }
                else
                {
                    switch (cmbIsCanceled.Text)
                    {
                        case "Не":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 0 && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                        case "Да":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 1 && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                        case "Всички":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                    }
                }
            }
            else
            {
                DocumentSequences documentSequences = cmbSequence.SelectedItem as DocumentSequences;

                if (string.IsNullOrEmpty(txtFilter.Text))
                {

                    switch (cmbIsCanceled.Text)
                    {
                        case "Не":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 0 && d.DocumentSequenceID == documentSequences.ID).ToList();
                            break;
                        case "Да":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 1 && d.DocumentSequenceID == documentSequences.ID).ToList();
                            break;
                        case "Всички":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.DocumentSequenceID == documentSequences.ID).ToList();
                            break;
                    }
                }
                else
                {
                    switch (cmbIsCanceled.Text)
                    {
                        case "Не":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 0 && d.DocumentSequenceID == documentSequences.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                        case "Да":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 1 && d.DocumentSequenceID == documentSequences.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                        case "Всички":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.DocumentSequenceID == documentSequences.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                    }
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (cmbSequence.SelectedValue == null || cmbSequence.SelectedValue.ToString() == "0")
            {
                if (string.IsNullOrEmpty(txtFilter.Text))
                {

                    switch (cmbIsCanceled.Text)
                    {
                        case "Не":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 0).ToList();
                            break;
                        case "Да":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 1).ToList();
                            break;
                        case "Всички":
                            documentsBindingSource.DataSource = db.Documents.ToList();
                            break;
                    }
                }
                else
                {
                    switch (cmbIsCanceled.Text)
                    {
                        case "Не":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 0 && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                        case "Да":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 1 && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                        case "Всички":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                    }
                }
            }
            else
            {
                DocumentSequences documentSequences = cmbSequence.SelectedItem as DocumentSequences;

                if (string.IsNullOrEmpty(txtFilter.Text))
                {

                    switch (cmbIsCanceled.Text)
                    {
                        case "Не":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 0 && d.DocumentSequenceID == documentSequences.ID).ToList();
                            break;
                        case "Да":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 1 && d.DocumentSequenceID == documentSequences.ID).ToList();
                            break;
                        case "Всички":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.DocumentSequenceID == documentSequences.ID).ToList();
                            break;
                    }
                }
                else
                {
                    switch (cmbIsCanceled.Text)
                    {
                        case "Не":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 0 && d.DocumentSequenceID == documentSequences.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                        case "Да":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 1 && d.DocumentSequenceID == documentSequences.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                        case "Всички":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.DocumentSequenceID == documentSequences.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                    }
                }
            }
        }

        private void cmbSequence_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbSequence.SelectedValue == null || cmbSequence.SelectedValue.ToString() == "0")
            {
                if (string.IsNullOrEmpty(txtFilter.Text))
                {

                    switch (cmbIsCanceled.Text)
                    {
                        case "Не":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 0).ToList();
                            break;
                        case "Да":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 1).ToList();
                            break;
                        case "Всички":
                            documentsBindingSource.DataSource = db.Documents.ToList();
                            break;
                    }
                }
                else
                {
                    switch (cmbIsCanceled.Text)
                    {
                        case "Не":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 0 && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                        case "Да":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 1 && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                        case "Всички":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                    }
                }
            } else
            {
                DocumentSequences documentSequences = cmbSequence.SelectedItem as DocumentSequences;

                if (string.IsNullOrEmpty(txtFilter.Text))
                {

                    switch (cmbIsCanceled.Text)
                    {
                        case "Не":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 0 && d.DocumentSequenceID==documentSequences.ID).ToList();
                            break;
                        case "Да":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 1 && d.DocumentSequenceID == documentSequences.ID).ToList();
                            break;
                        case "Всички":
                            documentsBindingSource.DataSource = db.Documents.Where(d=> d.DocumentSequenceID==documentSequences.ID).ToList();
                            break;
                    }
                }
                else
                {
                    switch (cmbIsCanceled.Text)
                    {
                        case "Не":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 0 && d.DocumentSequenceID == documentSequences.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                        case "Да":
                            documentsBindingSource.DataSource = db.Documents.Where(d => d.IsCanceled == 1 && d.DocumentSequenceID == documentSequences.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                        case "Всички":
                            documentsBindingSource.DataSource = db.Documents.Where(d =>d.DocumentSequenceID == documentSequences.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.DocumentNumber.ToString().Contains(txtFilter.Text)).ToList();
                            break;
                    }
                }
            }

           
        }

        private void dgvDocuments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvDocuments.Rows[e.RowIndex].DataBoundItem != null)
            {
                frmEditDocument frmEditDocument = new frmEditDocument();
                frmEditDocument.newDocument = dgvDocuments.CurrentRow.DataBoundItem as Documents;
                frmEditDocument.db = db;
                

                foreach (Control mdicontrol in frmEditDocument.Controls)
                {
                    MdiClient mdiClient = mdicontrol as MdiClient;
                    if (mdiClient != null)
                    {
                        mdiClient.BackColor = Color.White;
                        break;
                    }
                }
                CommonTasks.OpenForm(frmEditDocument);
            }
        }

        private void contextMenuStripDocument_Opening(object sender, CancelEventArgs e)
        {
            if (dgvDocuments.SelectedRows == null)
            {
                e.Cancel = true;
            }
        }

        private void contextMenuStripDocument_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Documents currentRowBI = dgvDocuments.CurrentRow.DataBoundItem as Documents;
            if (e.ClickedItem == toolStripMenuAddFinancialPlan)
            {
                if (dgvDocuments.CurrentRow.DataBoundItem != null)
                {
                    List<DocumentTransactions> transaction = new List<DocumentTransactions>();
                    
                    foreach (DocumentTransactions currentDocTrans in currentRowBI.DocumentTransactions)
                    {
                        if (currentDocTrans.TransactionsType.IsFinancialType == 1)
                        {
                            transaction.Add(currentDocTrans);
                        }

                    }
                    frmFinancialPlans frmFinancialPlans = new frmFinancialPlans();
                    frmFinancialPlans.transactionsType = transaction;
                    frmFinancialPlans.financialPlans = new FinancialPlans();
                    frmFinancialPlans.documents = currentRowBI;

                    if (currentRowBI.DocumentsProjects.Count > 0)
                    {
                        frmFinancialPlans.financialPlans.ProjectID = currentRowBI.DocumentsProjects.FirstOrDefault().ProjectID;
                    } else
                    {
                        frmFinancialPlans.financialPlans.ProjectID = 1;
                    }
                    frmFinancialPlans.financialPlans.CreationDate = DateTime.Now;

                    CommonTasks.OpenForm(frmFinancialPlans);                    
                }
            } else if (e.ClickedItem == toolStripMenuEditFinancialPlan)
            {
                if (dgvDocuments.CurrentRow.DataBoundItem != null)
                {
                    frmFinancialPlansList frmFinancialPlansList = new frmFinancialPlansList();
                    frmFinancialPlansList.senderDocument = currentRowBI;
                    CommonTasks.OpenForm(frmFinancialPlansList);
                }
            } else if (e.ClickedItem == toolStripMenuDocumentTransformations)
            {
                if (dgvDocuments.CurrentRow.DataBoundItem !=null)
                {
                    frmDocumentTransformation frmDocumentTransformation = new frmDocumentTransformation();
                    frmDocumentTransformation.document = currentRowBI;
                    frmDocumentTransformation.db = db;
                    frmDocumentTransformation.Show();
                }
            }
        }
    }
}
