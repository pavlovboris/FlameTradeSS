﻿using System;
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
    public partial class frmAdminTools : Form
    {
        public frmAdminTools()
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsersManagement usersManagement = new frmUsersManagement();
            usersManagement.Show();
        }

        private void btnFunctions_Click(object sender, EventArgs e)
        {
            frmFunctions functions = new frmFunctions();
            functions.Show();
        }

        private void btnFunctionRoles_Click(object sender, EventArgs e)
        {
            frmRolesFunctions frmRolesFunctions = new frmRolesFunctions();
            frmRolesFunctions.Show();
        }

        private void btnPersons_Click(object sender, EventArgs e)
        {
            frmPersons frmPersons = new frmPersons();
            frmPersons.Show();
        }

        private void frmAdminTools_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdminTools_Paint(object sender, PaintEventArgs e)
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

        private void btnRolesOdPersons_Click(object sender, EventArgs e)
        {
            frmRolesOfPersons frmRolesOfPersons = new frmRolesOfPersons();
            frmRolesOfPersons.Show();
        }

        private void btnPersonsRoleOfPersons_Click(object sender, EventArgs e)
        {
            frmPersonsRoleOfPersons frmPersonsRoleOfPersons = new frmPersonsRoleOfPersons();
            frmPersonsRoleOfPersons.Show();
        }
    }
}
