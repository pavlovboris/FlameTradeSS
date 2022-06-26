using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlameTradeSS
{
    internal class CurrentSessionData
    {
        public static FlameTradeDbEntities UsedForLoggInEntity { get; set; }
        
        public static Users CurrentUser { get; set; }

        public static frmMain CurrentfrmMain { get; set; }


        public static bool CheckIfUserIsOnline (Users user)
        {
            if (UsedForLoggInEntity.CurrentlyLoggedUsers.Where(u => u.UserID==user.ID).SingleOrDefault().UserIsCurrentlyLogged==1)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static int Counter
        {
            get;
            set;
        }
    }
}
