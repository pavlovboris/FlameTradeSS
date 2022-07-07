using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameTradeSS
{
    public partial class frmProjectsConfig : Form
    {
        public frmProjectsConfig()
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

        public Project project;
        private void frmPartnerGroups_Paint(object sender, PaintEventArgs e)
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

        private static readonly SecurityService securityService = new SecurityService();
        public FlameTradeDbEntities db;

        private void frmPartnerGroups_Load(object sender, EventArgs e)
        {
            UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, this);

            if (db == null)
            {
                db = securityService.NewDatabaseEntity();
            }
            if(project!=null)
            {
                projectAttachmentsBindingSource.DataSource = db.ProjectAttachments.Where(pa => pa.Project.ID == project.ID).ToList();
                lblProjectName.Text = project.ProjectName;
                txtProjectDescription.Text = project.ProjectDescription;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async  void btnSave_Click(object sender, EventArgs e)
        {
            bool proceed = true;
            int error = 0;
           

            if (proceed == true)
            {
                if (CommonTasks.SendWarningMsg("Сигурни ли сте, че искате да запазите промените") == true)
                {
                    try
                    {
                        await db.SaveChangesAsync();
                        CommonTasks.SendInfoMsg("Промените са запазени успешно");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        CommonTasks.SendErrorMsg("Промените НЕ бяха запаметени!!!");
                        if (CommonTasks.SendWarningMsg("Искате ли да видите детайлите") == true)
                        {
                            CommonTasks.SendErrorMsg(ex.Message);
                        }
                    }
                }
            } else
            {
                CommonTasks.SendErrorMsg("Необходимо е да попълните Име и Описание на обекта : " + error.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileDialog dialog = (FileDialog)sender;

            if (dialog.CheckFileExists == true)
            {
                try
                {
                    string filename = Path.GetFileName(dialog.FileName);
                    byte[] data = File.ReadAllBytes(dialog.FileName);

                    ProjectAttachments uploadedFiles = new ProjectAttachments();
                    uploadedFiles.FileName = filename;
                    uploadedFiles.FileData = data;
                    uploadedFiles.Project = project;
                    projectAttachmentsBindingSource.Add(uploadedFiles);
                    db.ProjectAttachments.Add(uploadedFiles);

                    MessageBox.Show("Файлът е качен успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProjectAttachments.CurrentRow != null && dgvProjectAttachments.CurrentRow.Index != -1 & dgvProjectAttachments.CurrentRow.DataBoundItem != null)
            {
                if (MessageBox.Show("Сигурни ли сте, че искате да изтриете файл :" + dgvProjectAttachments.CurrentRow.Cells[0].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProjectAttachments uploadedFile = dgvProjectAttachments.CurrentRow.DataBoundItem as ProjectAttachments;
                    projectAttachmentsBindingSource.Remove(uploadedFile);
                    db.ProjectAttachments.Remove(uploadedFile);
                }
            }

        }

        private void dgvProjectAttachments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvProjectAttachments.Rows[e.RowIndex].DataBoundItem != null)
            {
                ProjectAttachments uploadedFiles = new ProjectAttachments();
                uploadedFiles = dgvProjectAttachments.Rows[e.RowIndex].DataBoundItem as ProjectAttachments;
                byte[] bytes = uploadedFiles.FileData;

                saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.FileName = uploadedFiles.FileName;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveFileDialog1.FileName = saveFileDialog1.FileName;
                    try
                    {
                        FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                        fs.Write(bytes, 0, bytes.Length);

                        fs.Close();

                        if (MessageBox.Show("Искате ли да стартирате файл : " + saveFileDialog1.FileName, "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            try
                            {
                                Process.Start(saveFileDialog1.FileName);
                                MessageBox.Show("Файла е успешно записан", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("Възникна грешка при записшане на файла, файла не записан", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }

        }
    }
}
