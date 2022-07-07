using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameTradeSS
{
    internal class LoadingItems
    {
        public void LoadFlowLayoutItem(Panel panel1,FlameTradeDbEntities db,List<TransactionsType> transactionTypes,FinancialPlans financialPlans,BindingSource bindingSource)
        {
           
            foreach(TransactionsType transTypes in transactionTypes)
            {
                ContextMenuStrip flowContext = new ContextMenuStrip();
                flowContext.Items.Add(new ToolStripMenuItem { Text = "Премахни", Name = "remove" });
                flowContext.ItemClicked += FlowContext_ItemClicked;

                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Width = 367;
                Size flowMaxSize = new Size();
                flowMaxSize.Width = 367;
                flowMaxSize.Height = 500;
                flowLayoutPanel.MaximumSize = flowMaxSize;
                flowLayoutPanel.AutoScroll = true;
                string color = (from clr in db.FinancialPlanColors where clr.TransactionTypeID == transTypes.ID select clr.FinancialColor).SingleOrDefault().ToString();
                flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(color));
                flowLayoutPanel.ContextMenuStrip = flowContext;
                flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                flowLayoutPanel.MouseDown += FlowLayoutPanel_MouseDown;
                flowLayoutPanel.MouseUp += FlowLayoutPanel_MouseUp;
                flowLayoutPanel.MouseMove += FlowLayoutPanel_MouseMove;
                flowLayoutPanel.Padding = new Padding(5, 20, 5, 20);
                flowLayoutPanel.Tag = transTypes;
                flowLayoutPanel.AutoSize = true;
                panel1.Controls.Add(flowLayoutPanel);
                flowLayoutPanel.Show();

                TextBox categoryName = new TextBox();
                categoryName.Text = transTypes.TypeName.ToString();
                categoryName.ReadOnly = true;
                categoryName.TextAlign = HorizontalAlignment.Center;
                categoryName.Width = flowLayoutPanel.Width - 5;
                flowLayoutPanel.Controls.Add(categoryName);
                categoryName.Show();

                Button buttonAdd = new Button();
                buttonAdd.Text = "Добави Категория";
                buttonAdd.Width = flowLayoutPanel.Width - 5;
                flowLayoutPanel.Controls.Add(buttonAdd);
                buttonAdd.Show();

                Label lblFinancialGroup = new Label();
                lblFinancialGroup.Width = 200;
                lblFinancialGroup.Text = "Категория";
                lblFinancialGroup.TextAlign = ContentAlignment.MiddleCenter;
                flowLayoutPanel.Controls.Add(lblFinancialGroup);

                Label lblOffer = new Label();
                lblOffer.Width = 30;
                lblOffer.Text = "О";
                lblOffer.TextAlign = ContentAlignment.MiddleCenter;
                flowLayoutPanel.Controls.Add(lblOffer);
                lblOffer.Show();

                Label lblBudget = new Label();
                lblBudget.Width = 30;
                lblBudget.Text = "Б";
                lblBudget.TextAlign = ContentAlignment.MiddleCenter;
                flowLayoutPanel.Controls.Add(lblBudget);
                lblBudget.Show();

                Label lblReal = new Label();
                lblReal.Width = 30;
                lblReal.Text = "Р";
                lblReal.TextAlign = ContentAlignment.MiddleCenter;
                flowLayoutPanel.Controls.Add(lblReal);
                lblReal.Show();

                Label lblProfit = new Label();
                lblProfit.Width = 30;
                lblProfit.Text = "%";
                lblProfit.TextAlign = ContentAlignment.MiddleCenter;
                flowLayoutPanel.Controls.Add(lblProfit);
                lblProfit.Show();
                BindingSource bsFinancialLines = new BindingSource() { DataSource = typeof(FinancialPlanLines) };
                bsFinancialLines.DataSource = db.FinancialPlanLines.Where(fpl => fpl.FinancialPlanID == financialPlans.ID && fpl.TransactionTypeID==transTypes.ID).ToList();

                foreach (FinancialPlanLines financialPlanLine in bsFinancialLines)
                {
                    BindingSource financialCategoryBindingSource = new BindingSource() { DataSource = db.FinancialCategories.ToList() };

                    ComboBox cmbFinancialGroup = new ComboBox();

                    cmbFinancialGroup.DataSource = financialCategoryBindingSource;
                    cmbFinancialGroup.ValueMember = "ID";
                    cmbFinancialGroup.DisplayMember = "CategoryName";
                    cmbFinancialGroup.Name = "cmbFinancialGroup";
                    cmbFinancialGroup.DataBindings.Add("SelectedValue", financialPlanLine, "FinancialGroupID");
                    cmbFinancialGroup.Tag = financialPlanLine.GetHashCode();
                    cmbFinancialGroup.SelectedItem = financialPlanLine.FinancialCategories;

                    cmbFinancialGroup.Width = 200;
                    flowLayoutPanel.Controls.Add(cmbFinancialGroup);
                    cmbFinancialGroup.Show();

                    TextBox txtOfferValue = new TextBox();
                    txtOfferValue.Tag = financialPlanLine.GetHashCode();
                    txtOfferValue.Name = "txtOfferValue";
                    txtOfferValue.TextChanged += TxtOfferValue_TextChanged;
                    txtOfferValue.Width = 30;
                    txtOfferValue.DataBindings.Add("Text", financialPlanLine, "OfferValue");
                    flowLayoutPanel.Controls.Add(txtOfferValue);
                    txtOfferValue.Show();

                    TextBox txtBudgetValue = new TextBox();
                    txtBudgetValue.Tag = financialPlanLine.GetHashCode();
                    txtBudgetValue.Width = 30;
                    txtBudgetValue.DataBindings.Add("Text", financialPlanLine, "BudgetValue");
                    flowLayoutPanel.Controls.Add(txtBudgetValue);
                    txtBudgetValue.Show();

                    TextBox txtRealValue = new TextBox();
                    txtRealValue.Tag = financialPlanLine.GetHashCode();
                    txtRealValue.Width = 30;
                    txtRealValue.DataBindings.Add("Text", financialPlanLine, "RealValue");
                    flowLayoutPanel.Controls.Add(txtRealValue);
                    txtRealValue.Show();

                    TextBox txtProfit = new TextBox();
                    txtProfit.Tag = financialPlanLine.GetHashCode();
                    txtProfit.Width = 30;
                    txtProfit.DataBindings.Add("Text", financialPlanLine, "ProfitPercent");
                    flowLayoutPanel.Controls.Add(txtProfit);
                    txtProfit.Show();
                }
            }
        }

       

        private void TxtOfferValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            
            FinancialPlanLines financialPlanLines = textBox.DataBindings[0].DataSource as FinancialPlanLines;
            //List<FinancialPlanLines> planLines = new List<FinancialPlanLines>();
            
            financialPlanLines.OfferValue = Convert.ToInt32(textBox.Text);
        }

        private void FlowContext_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ContextMenuStrip contextMenuStrip = sender as ContextMenuStrip;
            if (e.ClickedItem != null)
            {
                if (contextMenuStrip.Items[contextMenuStrip.Items.IndexOfKey("remove")]==e.ClickedItem)
                {
                    contextMenuStrip.SourceControl.Dispose();
                }
            }
        }

        private Point pointMouse = new Point();
        private Control ctrlMoved = new Control();
        private bool bMoving = false;

        private void FlowLayoutPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //if not being moved or left mouse button not used, exit
            if (!bMoving || e.Button != MouseButtons.Left)
            {
                return;
            }
            //get control reference
            ctrlMoved = (Control)sender;
            //set control's position based upon mouse's position change
            ctrlMoved.Left += e.X - pointMouse.X;
            ctrlMoved.Top += e.Y - pointMouse.Y;
        }

        private void FlowLayoutPanel_MouseUp(object sender, MouseEventArgs e)
        {
            FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)sender;

            flowLayoutPanel.ResumeLayout();
            bMoving = false;

        }

        private void FlowLayoutPanel_MouseDown(object sender, MouseEventArgs e)
        {
           // Control control = (Control)sender;
            //control.BringToFront();
            //if not left mouse button, exit
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            // save cursor location
            FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)sender;  
            
            flowLayoutPanel.BringToFront();
            flowLayoutPanel.SuspendLayout();

            pointMouse = e.Location;
            //remember that we're moving
            bMoving = true;
        }
    }
}
