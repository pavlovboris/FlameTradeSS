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
    public partial class frmItems : Form
    {
        public frmItems()
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
                CommonTasks.WriteGrideViewSetting(dgvItems, Name + dgvItems.Name + CurrentSessionData.CurrentUser.UserName);
            }
            catch { }

            Properties.Settings.Default.frmItemsState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.frmItemsLocation = this.Location;
                Properties.Settings.Default.frmItemsSize = this.Size;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.frmItemsLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.frmItemsSize = this.RestoreBounds.Size;
            }

            // don't forget to save the settings
            Properties.Settings.Default.Save();
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

            
            CommonTasks.RestoreForm(this, Properties.Settings.Default.frmItemsSize, Properties.Settings.Default.frmItemsState, Properties.Settings.Default.frmItemsLocation);

            cmbIsInactive.SelectedIndex= 0;

            itemsBindingSource.DataSource = db.Items.ToList();
            partnersBindingSource.DataSource = db.Partners.ToList();
            itemsGroupsBindingSource.DataSource = db.ItemsGroups.ToList();
            itemCategoryBindingSource.DataSource = db.ItemCategory.ToList();
            partitionsBindingSource.DataSource = db.Partitions.ToList();
            muBindingSource.DataSource = db.Mu.ToList();
            itemCategoryBindingSource1.DataSource = db.ItemCategory.ToList();
            surfacesBindingSource.DataSource = db.Surfaces.ToList();

            ItemCategory nullItemCategory = new ItemCategory();
            nullItemCategory.CategoryName = "All";
            itemCategoryBindingSource1.Add(nullItemCategory);

            cmbCategory.SelectedItem = nullItemCategory;

            try
            {
                CommonTasks.ReadDataGridViewSetting(dgvItems, Name + dgvItems.Name + CurrentSessionData.CurrentUser.UserName);
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

            cmbCategory.Width = itemCategoryDataGridViewTextBoxColumn.Width;
            cmbIsInactive.Width = isInactiveDataGridViewTextBoxColumn.Width;


            Rectangle pointIsInactive = new Rectangle();
            Rectangle pointCategory = new Rectangle();

            pointIsInactive = dgvItems.GetColumnDisplayRectangle(isInactiveDataGridViewTextBoxColumn.Index, false);
            pointCategory = dgvItems.GetColumnDisplayRectangle(itemCategoryDataGridViewTextBoxColumn.Index, false);

            pointIsInactive.Y += 100;
            pointIsInactive.X += 12;

            pointCategory.Y += 100;
            pointCategory.X += 12;

            cmbIsInactive.Location = pointIsInactive.Location;
            cmbCategory.Location = pointCategory.Location;

            if (isInactiveDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbIsInactive.Visible = false;
            }
            else { cmbIsInactive.Visible = true; }

            if (itemCategoryDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbCategory.Visible = false;
            }
            else { cmbCategory.Visible = true; }
        }

        private void dgvDocuments_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle pointIsInactive = new Rectangle();
            Rectangle pointCategory = new Rectangle();

            pointIsInactive = dgvItems.GetColumnDisplayRectangle(isInactiveDataGridViewTextBoxColumn.Index, false);
            pointCategory = dgvItems.GetColumnDisplayRectangle(itemCategoryDataGridViewTextBoxColumn.Index, false);

            pointIsInactive.Y += 100;
            pointIsInactive.X += 12;

            pointCategory.Y += 100;
            pointCategory.X += 12;

            cmbIsInactive.Location = pointIsInactive.Location;
            cmbCategory.Location = pointCategory.Location;

            if (isInactiveDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbIsInactive.Visible = false;
            }
            else { cmbIsInactive.Visible = true; }

            if (itemCategoryDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbCategory.Visible = false;
            }
            else { cmbCategory.Visible = true; }
        }

        private void dgvDocuments_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle pointIsInactive = new Rectangle();
            Rectangle pointCategory = new Rectangle();

            pointIsInactive = dgvItems.GetColumnDisplayRectangle(isInactiveDataGridViewTextBoxColumn.Index, false);
            pointCategory = dgvItems.GetColumnDisplayRectangle(itemCategoryDataGridViewTextBoxColumn.Index, false);

            pointIsInactive.Y += 100;
            pointIsInactive.X += 12;

            pointCategory.Y += 100;
            pointCategory.X += 12;

            cmbIsInactive.Location = pointIsInactive.Location;
            cmbCategory.Location = pointCategory.Location;

            if (isInactiveDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbIsInactive.Visible = false;
            }
            else { cmbIsInactive.Visible = true; }

            if (itemCategoryDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbCategory.Visible = false;
            }
            else { cmbCategory.Visible = true; }

        }

        private void frmDocuments_SizeChanged(object sender, EventArgs e)
        {
            Rectangle pointIsInactive = new Rectangle();
            Rectangle pointCategory = new Rectangle();

            pointIsInactive = dgvItems.GetColumnDisplayRectangle(isInactiveDataGridViewTextBoxColumn.Index, false);
            pointCategory = dgvItems.GetColumnDisplayRectangle(itemCategoryDataGridViewTextBoxColumn.Index, false);

            pointIsInactive.Y += 100;
            pointIsInactive.X += 12;

            pointCategory.Y += 100;
            pointCategory.X += 12;

            cmbIsInactive.Location = pointIsInactive.Location;
            cmbCategory.Location = pointCategory.Location;

            if (isInactiveDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbIsInactive.Visible = false;
            }
            else { cmbIsInactive.Visible = true; }

            if (itemCategoryDataGridViewTextBoxColumn.Displayed == false)
            {
                cmbCategory.Visible = false;
            }
            else { cmbCategory.Visible = true; }
        }

        private void cmbIsCanceled_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCategory.SelectedValue == null || cmbCategory.SelectedValue.ToString()=="0" )
            {
                if (string.IsNullOrEmpty(txtFilter.Text))
                {

                    switch (cmbIsInactive.Text)
                    {
                        case "Не":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 0).ToList();
                            break;
                        case "Да":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 1).ToList();
                            break;
                        case "Всички":
                            itemsBindingSource.DataSource = db.Items.ToList();
                            break;
                    }
                }
                else
                {
                    switch (cmbIsInactive.Text)
                    {
                        case "Не":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 0 && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                        case "Да":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 1 && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                        case "Всички":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                    }
                }
            }
            else
            {
                ItemCategory itemCategory = cmbCategory.SelectedItem as ItemCategory;

                if (string.IsNullOrEmpty(txtFilter.Text))
                {

                    switch (cmbIsInactive.Text)
                    {
                        case "Не":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 0 && d.ItemCategory == itemCategory.ID).ToList();
                            break;
                        case "Да":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 1 && d.ItemCategory == itemCategory.ID).ToList();
                            break;
                        case "Всички":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.ItemCategory == itemCategory.ID).ToList();
                            break;
                    }
                }
                else
                {
                    switch (cmbIsInactive.Text)
                    {
                        case "Не":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 0 && d.ItemCategory == itemCategory.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                        case "Да":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 1 && d.ItemCategory == itemCategory.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                        case "Всички":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.ItemCategory == itemCategory.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                    }
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue == null || cmbCategory.SelectedValue.ToString() == "0")
            {
                if (string.IsNullOrEmpty(txtFilter.Text))
                {

                    switch (cmbIsInactive.Text)
                    {
                        case "Не":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 0).ToList();
                            break;
                        case "Да":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 1).ToList();
                            break;
                        case "Всички":
                            itemsBindingSource.DataSource = db.Items.ToList();
                            break;
                    }
                }
                else
                {
                    switch (cmbIsInactive.Text)
                    {
                        case "Не":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 0 && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                        case "Да":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 1 && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                        case "Всички":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                    }
                }
            }
            else
            {
                ItemCategory itemCategory = cmbCategory.SelectedItem as ItemCategory;

                if (string.IsNullOrEmpty(txtFilter.Text))
                {

                    switch (cmbIsInactive.Text)
                    {
                        case "Не":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 0 && d.ItemCategory == itemCategory.ID).ToList();
                            break;
                        case "Да":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 1 && d.ItemCategory == itemCategory.ID).ToList();
                            break;
                        case "Всички":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.ItemCategory == itemCategory.ID).ToList();
                            break;
                    }
                }
                else
                {
                    switch (cmbIsInactive.Text)
                    {
                        case "Не":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 0 && d.ItemCategory == itemCategory.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                        case "Да":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 1 && d.ItemCategory == itemCategory.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                        case "Всички":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.ItemCategory == itemCategory.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                    }
                }
            }
        }

        private void cmbSequence_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue == null || cmbCategory.SelectedValue.ToString() == "0")
            {
                if (string.IsNullOrEmpty(txtFilter.Text))
                {

                    switch (cmbIsInactive.Text)
                    {
                        case "Не":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 0).ToList();
                            break;
                        case "Да":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 1).ToList();
                            break;
                        case "Всички":
                            itemsBindingSource.DataSource = db.Items.ToList();
                            break;
                    }
                }
                else
                {
                    switch (cmbIsInactive.Text)
                    {
                        case "Не":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 0 && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                        case "Да":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 1 && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                        case "Всички":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                    }
                }
            }
            else
            {
                ItemCategory itemCategory = cmbCategory.SelectedItem as ItemCategory;

                if (string.IsNullOrEmpty(txtFilter.Text))
                {

                    switch (cmbIsInactive.Text)
                    {
                        case "Не":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 0 && d.ItemCategory == itemCategory.ID).ToList();
                            break;
                        case "Да":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 1 && d.ItemCategory == itemCategory.ID).ToList();
                            break;
                        case "Всички":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.ItemCategory == itemCategory.ID).ToList();
                            break;
                    }
                }
                else
                {
                    switch (cmbIsInactive.Text)
                    {
                        case "Не":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 0 && d.ItemCategory == itemCategory.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                        case "Да":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.IsInactive == 1 && d.ItemCategory == itemCategory.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                        case "Всички":
                            itemsBindingSource.DataSource = db.Items.Where(d => d.ItemCategory == itemCategory.ID && d.Partners.Partner_name.Contains(txtFilter.Text) | d.Code.ToString().Contains(txtFilter.Text) | d.Description.Contains(txtFilter.Text)).ToList();
                            break;
                    }
                }
            }
        }

        private void dgvDocuments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvItems.Rows[e.RowIndex].DataBoundItem != null)
            {
                frmItemsAddEdit frmItemsAddEdit = new frmItemsAddEdit();
                frmItemsAddEdit.newItem = dgvItems.CurrentRow.DataBoundItem as Items;
                frmItemsAddEdit.db = db;
              
                CommonTasks.OpenForm(frmItemsAddEdit);
            }
        }
    }
}
