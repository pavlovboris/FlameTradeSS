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
                    var restriction = (from rest in db.FunctionRoles where rest.FunctionID == f.ID && user.RoleID == rest.RoleID select rest).SingleOrDefault();
                    if (restriction != null)
                    {
                       form.Controls.RemoveByKey(f.ControllName);
                    }
                }
            }
        }


    }
}
