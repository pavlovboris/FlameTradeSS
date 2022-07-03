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
        public void AddFlowLayoutItem(Panel panel1,FlameTradeDbEntities db,List<DocumentTransactions> transactionsType)
        {

            foreach(DocumentTransactions trans in transactionsType)
            {
                
                ContextMenuStrip flowContext = new ContextMenuStrip();
                flowContext.Items.Add(new ToolStripMenuItem { Text = "Премахни",Name = "remove" });
                flowContext.ItemClicked += FlowContext_ItemClicked;

                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Width = 367;
                flowLayoutPanel.Height = 267;
                flowLayoutPanel.AutoScroll = true;
                string color = (from clr in db.FinancialPlanColors where clr.TransactionTypeID == trans.TransactionTypeID select clr.FinancialColor).SingleOrDefault().ToString();
                flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(color));
                flowLayoutPanel.ContextMenuStrip = flowContext;
                flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                flowLayoutPanel.MouseDown += FlowLayoutPanel_MouseDown;
                flowLayoutPanel.MouseUp += FlowLayoutPanel_MouseUp;
                flowLayoutPanel.MouseMove += FlowLayoutPanel_MouseMove;
                flowLayoutPanel.Tag = trans;
                //flowContext.Parent = flowLayoutPanel;
                panel1.Controls.Add(flowLayoutPanel);
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
            }
            



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
