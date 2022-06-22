using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            }
        }
    }
}
