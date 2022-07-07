using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlameTradeSS
{
    internal class UserRestrictions
    {
        static FlameTradeDbEntities db = CurrentSessionData.UsedForLoggInEntity;
        public static void ApplyUserRestrictions(Users user, Form form)
        {
            foreach(Functions f in db.Functions)
            {
                if (f.FormName==form.Name)
                {
                    var restriction = (from rest in db.FunctionRoles where rest.FunctionID == f.ID && user.RoleID == rest.RoleID && user.RoleID!=1 select rest).SingleOrDefault();
                    if (restriction != null)
                    {
                        switch (f.ControlAction)
                        {
                            case "Remove":
                                try
                                {
                                    form.Controls[form.Controls.IndexOfKey(f.ControllName)].Dispose();
                                    break;
                                } catch { }
                                try
                                {
                                    Type panel = typeof(Panel);

                                    foreach (Control ctrll in form.Controls)
                                    {

                                        if (ctrll.GetType() == panel)
                                        {
                                            Panel pnl = ctrll as Panel;
                                            foreach (Control control in pnl.Controls)
                                            {
                                                pnl.Controls[pnl.Controls.IndexOfKey(f.ControllName)].Dispose();
                                            }
                                        }
                                    }
                                }
                                catch { };

                                break;
                            case "Disable":
                                try
                                {
                                    form.Controls[form.Controls.IndexOfKey(f.ControllName)].Enabled = false;
                                    break;
                                }
                                catch { }
                                try
                                {
                                    Type panel = typeof(Panel);

                                    foreach (Control ctrll in form.Controls)
                                    {

                                        if(ctrll.GetType()==panel)
                                        {
                                            Panel pnl = ctrll as Panel;
                                            foreach(Control control in pnl.Controls)
                                            {
                                                pnl.Controls[pnl.Controls.IndexOfKey(f.ControllName)].Enabled = false;
                                            }
                                        }
                                    }
                                }
                                catch { };
                                break;
                        }
                    }
                }
            }
        }
    }
}
