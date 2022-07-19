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
    public partial class frmDocumentsEditsRequests : Form
    {
        public frmDocumentsEditsRequests()
        {
            InitializeComponent();
        }

        public LogsEditRestrictedDocuments newLogReason;
        public Documents document;
        public FlameTradeDbEntities db;

        private void frmDocumentsEditsRequests_Load(object sender, EventArgs e)
        {
            if (CurrentSessionData.CurrentUser.RoleID !=1)
            {
                if (allowed == false )
                {
                    newLogReason = db.LogsEditRestrictedDocuments.Where(lerd => lerd.DocumentID == document.ID && lerd.LogUserID == CurrentSessionData.CurrentUser.ID && lerd.AnswerStatus==1 | lerd.AnswerStatus==2 ).SingleOrDefault();
                    if (newLogReason != null && newLogReason.AnswerStatus == 1 )
                    {
                        isNew = false;
                        CommonTasks.SendInfoMsg("Вече имате изпратена заявка за удобрение, моля изчакайте промяна в статуса");
                        cancel = true;
                        Close();
                        
                    } else if (newLogReason != null && newLogReason.AnswerStatus == 2) 
                    {
                        isNew = false;
                        allowed = true;
                        CommonTasks.SendInfoMsg("Редакцията е разрешема");
                        newLogReason.AnswerStatus = 4;
                        cancel = false;
                        Close();
                    } else
                    {
                        newLogReason = new LogsEditRestrictedDocuments();
                        newLogReason.LogAction = 1;
                        newLogReason.LogUserID = CurrentSessionData.CurrentUser.ID;
                        newLogReason.Documents = document;
                        newLogReason.LogDate = DateTime.Now;
                        cmbRequestToRole.Visible = true;
                        checkBoxRequestNow.Visible = true;
                        foreach (Roles role in db.Roles)
                        {
                             rolesBindingSource.Add(role);
                        }
                    }
                } else
                {
                    newLogReason = new LogsEditRestrictedDocuments();
                    newLogReason.LogAction = 1;
                    newLogReason.LogUserID = CurrentSessionData.CurrentUser.ID;
                    newLogReason.Documents = document;
                    newLogReason.LogDate = DateTime.Now;
                }

            } else
            {
                newLogReason.LogAction = 1;
                newLogReason.LogUserID = CurrentSessionData.CurrentUser.ID;
                newLogReason.Documents = document;
                newLogReason.LogDate = DateTime.Now;

                allowed = true;
            }
        }

        public bool cancel = true;
        public bool allowed = false;
        public bool isNew = true;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cancel = false;
            
            if (allowed == false )
            {
                newLogReason.AnswerStatus = 1;
            }

            newLogReason.LogReason = txtReason.Text;
            Close();
        }

        private void checkBoxRequestNow_VisibleChanged(object sender, EventArgs e)
        {
            if (checkBoxRequestNow.Visible == true)
            {
                if (checkBoxRequestNow.Checked == true)
                {
                    newLogReason.SendRequestNow = 1;

                } else
                {
                    newLogReason.SendRequestNow = 0;
                }
            }
        }

        private void cmbRequestToRole_VisibleChanged(object sender, EventArgs e)
        {
            
            if (cmbRequestToRole.Items.Count>0)
            {
               
                cmbRequestToRole.SelectedIndex = 1;
            }
        }

        private void cmbRequestToRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            newLogReason.Roles = cmbRequestToRole.SelectedItem as Roles;
        }

        private void checkBoxRequestNow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRequestNow.Checked == true)
            {
                newLogReason.SendRequestNow = 1;
            }
            else
            {
                newLogReason.SendRequestNow = 0;
            }
        }
    }
}
