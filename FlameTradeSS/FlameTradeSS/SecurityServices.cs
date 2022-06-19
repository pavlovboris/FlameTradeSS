using System;
using System.Linq;

namespace FlameTradeSS
{
    public class SecurityService
    {


        public  FlameTradeDbEntities NewDatabaseEntity()
        {
            FlameTradeDbEntities db = new FlameTradeDbEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=FlameTradeDb;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;Timeout=3;";
            return db;

        }

        public  Users LoggedUser(FlameTradeDbEntities db,string userName, string password)
          {
            Users usr = (from user in db.Users where user.UserName == userName && user.Password == password select user).SingleOrDefault();

            if (usr != null )
            {
                return usr;
            } else
            {
                return null;
            }
          }
  

        public static bool ConnectionCheck(FlameTradeDbEntities db)
        {
            try
            {
                db.Database.Connection.Open();
                db.Dispose();
                return true;
            } catch
            {
                return false;
            }
        }
    }
}


