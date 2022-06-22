using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FlameTradeSS
{
    internal class CommonTasks
    {
        public static void ExitApplication()
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да затворите " + Application.ProductName.ToString(), "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        public static void SendErrorMsg(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void SendInfoMsg(string message)
        {
            MessageBox.Show(message, "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool SendWarningMsg(string message)
        {
            if(MessageBox.Show(message,"Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static void OpenForm(Form form)
        {
            List<Form> openForms = new List<Form>();

            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                openForms.Add(f);
            }

            foreach(Form f in openForms)
            {
                if (f.Name == form.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen==false)
            {
                form.Show();
                UserRestrictions.ApplyUserRestrictions(frmLogin.Instance.UserInfo, form);
            }
        }

        public static void ReadDataGridViewSetting(DataGridView dgv, string FileName)
        {

            //declare the xmldocument object  
            XmlDocument xmldoc = new XmlDocument();
            //and also xmllistnode  
            XmlNodeList xmlnode;
            //declare the filestream for reading and accessing the xml file  
            FileStream fs = new FileStream("..\\XML\\" + FileName + ".xml", FileMode.Open, FileAccess.Read);
            //pass the filestreanm as object for xmlnode load event  
            xmldoc.Load(fs);
            //in this line we actuallty find our setting root name which i set it as column name sth look like this  
            //<setting>  
            //<column>  
            //<innernodes>ect....  
            //</column>  
            //<column>  
            //<innernodes>ect....  
            //</column>  
            //</setting>  
            xmlnode = xmldoc.GetElementsByTagName("column");
            for (int i = 0; i <= xmlnode.Count - 1; i++)
            {
                //read the first node of the current column node and set it datagrideview name'  
                //and we are going to use it in our code for setting the columns properties  
                string columnName = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                int width = int.Parse(xmlnode[i].ChildNodes.Item(1).InnerText.Trim());
                string headertext = xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                int displayindex = int.Parse(xmlnode[i].ChildNodes.Item(3).InnerText.Trim());
                Boolean visible = Convert.ToBoolean(xmlnode[i].ChildNodes.Item(4).InnerText.Trim());
                //after finding and perparing data now i set the grid properties  
                //set the witdh  
                dgv.Columns[columnName].Width = width;
                //set the headertext  
                dgv.Columns[columnName].HeaderText = headertext;
                //set the column index it means the order of the column  
                dgv.Columns[columnName].DisplayIndex = displayindex;
                //set the visibility  
                dgv.Columns[columnName].Visible = visible;
            }
            fs.Close();
        }

        public static void WriteGrideViewSetting(DataGridView dgv, string FileName)
        {
            //declaring teh xmlwritter object  
            XmlTextWriter settingwriter = new XmlTextWriter("..\\XML\\" + FileName + ".xml", null);

            //starting the root node which in this example i set the gridview name for this starting node  
            //<setting>  
            //<column>  
            //<innernodes>ect....  
            //</column>  
            //<column>  
            //<innernodes>ect....  
            //</column>  
            //</setting>  
            // the line blow declare the setting tag of the current example and specify the name for the this tag  
            settingwriter.WriteStartDocument();
            settingwriter.WriteStartElement(dgv.Name);
            int count = dgv.Columns.Count;
            //count the gridview column  
            for (int i = 0; i < count; i++)
            {
                //now create the column root node  
                settingwriter.WriteStartElement("column");
                //then creat the name node and fill the value in this node  
                settingwriter.WriteStartElement("Name");
                settingwriter.WriteString(dgv.Columns[i].Name);
                // close the name node  
                settingwriter.WriteEndElement();
                //these three node are declared similar to previous node  
                settingwriter.WriteStartElement("width");
                settingwriter.WriteString(dgv.Columns[i].Width.ToString());
                settingwriter.WriteEndElement();
                settingwriter.WriteStartElement("headertext");
                settingwriter.WriteString(dgv.Columns[i].HeaderText);
                settingwriter.WriteEndElement();
                settingwriter.WriteStartElement("displayindex");
                settingwriter.WriteString(dgv.Columns[i].DisplayIndex.ToString());
                settingwriter.WriteEndElement();
                settingwriter.WriteStartElement("visible");
                settingwriter.WriteString(dgv.Columns[i].Visible.ToString());
                settingwriter.WriteEndElement();
                //end the column node  
                settingwriter.WriteEndElement();
            }
            //end the main root of the xml file which is datagrid name  
            settingwriter.WriteEndElement();
            //end the settingwritter  
            settingwriter.WriteEndDocument();
            //the close the wriiter  
            settingwriter.Close();
        }
    }
}
