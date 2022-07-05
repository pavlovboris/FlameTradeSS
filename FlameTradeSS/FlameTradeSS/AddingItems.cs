using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameTradeSS
{
    internal class AddingItems
    {
        public void AddFlowLayoutItem(Panel panel1,FlameTradeDbEntities db,List<DocumentTransactions> documentTransactions,FinancialPlans financialPlans,BindingSource bindingSource)
        {

            foreach(DocumentTransactions trans in documentTransactions)
            {

                

                ContextMenuStrip flowContext = new ContextMenuStrip();
                flowContext.Items.Add(new ToolStripMenuItem { Text = "Премахни",Name = "remove" });
                flowContext.ItemClicked += FlowContext_ItemClicked;

                //Splitter resizeFlow = new Splitter();
                //resizeFlow.Dock = DockStyle.Bottom;
                //resizeFlow.Width = 370;
                //resizeFlow.Height = 170;
                
                //resizeFlow.Width = 370;
                //resizeFlow.Height = 167;

                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Width = 367;
                Size flowMaxSize = new Size();
                flowMaxSize.Width = 367;
                flowMaxSize.Height = 500;
                flowLayoutPanel.MaximumSize = flowMaxSize ;
                //flowLayoutPanel.Height = 167;
                flowLayoutPanel.AutoScroll = true;
                string color = (from clr in db.FinancialPlanColors where clr.TransactionTypeID == trans.TransactionTypeID select clr.FinancialColor).SingleOrDefault().ToString();
                flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(color));
                flowLayoutPanel.ContextMenuStrip = flowContext;
                flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                flowLayoutPanel.MouseDown += FlowLayoutPanel_MouseDown;
                flowLayoutPanel.MouseUp += FlowLayoutPanel_MouseUp;
                flowLayoutPanel.MouseMove += FlowLayoutPanel_MouseMove;
                flowLayoutPanel.Tag = trans;
                flowLayoutPanel.AutoSize = true;
                //flowLayoutPanel.Dock = DockStyle.Fill;
                panel1.Controls.Add(flowLayoutPanel);
               
               // resizeFlow.Show();
                //resizeFlow.Controls.Add(flowLayoutPanel);
                flowLayoutPanel.Show();                


                TextBox categoryName = new TextBox();
                categoryName.Text = trans.TransactionsType.TypeName.ToString();
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




               
               
                BindingSource bs = new BindingSource();
                bs.DataSource = typeof(FinancialPlanLines);

              //  List<TransactionLines> translines = new List<TransactionLines>();
               // translines = db.TransactionLines.Where(tl => tl.DocumentTransactions == trans).ToList();
             //  foreach(TransactionLines lines in trans.TransactionLines)
              //  {

             //   }
                

                foreach (TransactionLines transactionLines in trans.TransactionLines)
                {
                    if (transactionLines.FinancialCategoryID!=0)
                    {
                        bool exists = false;
                        foreach(FinancialPlanLines financialPlanLines in bs)
                        {
                            if (financialPlanLines.FinancialGroupID== transactionLines.FinancialCategoryID)
                            {
                                exists = true;
                                financialPlanLines.OfferValue += (transactionLines.Qty * transactionLines.SalePrice1);
                                //break;
                            }
                        }
                        if (exists == false)
                        {
                            FinancialPlanLines newFinancialLine = new FinancialPlanLines();

                            //newFinancialLine.FinancialCategories = transactionLines.FinancialCategories;
                            newFinancialLine.FinancialPlanID = financialPlans.ID;
                            newFinancialLine.FinancialGroupID = (int)transactionLines.FinancialCategoryID;
                            newFinancialLine.TransactionTypeID = transactionLines.DocumentTransactions.TransactionTypeID;
                            newFinancialLine.ProfitPercent = 0;
                            newFinancialLine.OfferValue = transactionLines.Qty * transactionLines.SalePrice1;
                            newFinancialLine.BudgetValue = 0;
                            newFinancialLine.RealValue = 0;

                            
                            bs.Add(newFinancialLine);
                            bindingSource.Add(newFinancialLine);

                            
                            BindingSource financialCategoryBindingSource = new BindingSource() { DataSource = db.FinancialCategories.ToList() };

                            ComboBox cmbFinancialGroup = new ComboBox();

                            cmbFinancialGroup.DataSource = financialCategoryBindingSource;
                            cmbFinancialGroup.ValueMember = "ID";
                            cmbFinancialGroup.DisplayMember = "CategoryName";
                            cmbFinancialGroup.Name = "cmbFinancialGroup";
                            cmbFinancialGroup.DataBindings.Add("SelectedValue",newFinancialLine, "FinancialGroupID");
                            cmbFinancialGroup.Tag = newFinancialLine.GetHashCode() ;
                            cmbFinancialGroup.SelectedItem = newFinancialLine.FinancialCategories;
                           
                            cmbFinancialGroup.Width = 200;
                            flowLayoutPanel.Controls.Add(cmbFinancialGroup);
                            cmbFinancialGroup.Show();

                            TextBox txtOfferValue = new TextBox();
                            txtOfferValue.Tag = newFinancialLine.GetHashCode();
                            txtOfferValue.Name = "txtOfferValue";
                          
                            txtOfferValue.TextChanged += TxtOfferValue_TextChanged;
                            txtOfferValue.Width = 30;
                            txtOfferValue.DataBindings.Add("Text",newFinancialLine,"OfferValue");
                            flowLayoutPanel.Controls.Add(txtOfferValue);
                            txtOfferValue.Show();

                            TextBox txtBudgetValue = new TextBox();
                            txtBudgetValue.Tag = newFinancialLine.GetHashCode();
                            txtBudgetValue.Width = 30;
                            txtBudgetValue.DataBindings.Add("Text", newFinancialLine, "BudgetValue");
                            flowLayoutPanel.Controls.Add(txtBudgetValue);
                            txtBudgetValue.Show();

                            TextBox txtRealValue = new TextBox();
                            txtRealValue.Tag = newFinancialLine.GetHashCode();
                            txtRealValue.Width = 30;
                            txtRealValue.DataBindings.Add("Text", newFinancialLine, "RealValue");
                            flowLayoutPanel.Controls.Add(txtRealValue);
                            txtRealValue.Show();

                            TextBox txtProfit = new TextBox();
                            txtProfit.Tag = newFinancialLine.GetHashCode();
                            txtProfit.Width = 30;
                            txtProfit.DataBindings.Add("Text", newFinancialLine, "ProfitPercent");
                            flowLayoutPanel.Controls.Add(txtProfit);
                            txtProfit.Show();
                        } 

                        foreach (TextBox textBox in flowLayoutPanel.Controls.OfType<TextBox>())
                        {
                            foreach (FinancialPlanLines financialPlanLines in bs)
                            {
                                if (textBox.Tag != null && (int)textBox.Tag == financialPlanLines.GetHashCode())
                                {
                                    switch (textBox.Name)

                                    {
                                        case "txtOfferValue":
                                            textBox.Text = financialPlanLines.OfferValue.ToString();
                                            break;
                                    }
                                }
                            }
                        }
                    }
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
