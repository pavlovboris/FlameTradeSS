using System;
using System.Linq;

namespace FlameTradeSS
{
    public class SecurityService
    {
        FlameTradeDbEntities securityDb = new FlameTradeDbEntities();

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
               
                FlameTradeDbEntities loginLogs = NewDatabaseEntity();
                UsersLogInLogs usrLogin = new UsersLogInLogs();
                usrLogin.LogInTime = DateTime.Now;
                usrLogin.UserID = usr.ID;

                CurrentlyLoggedUsers currentlyLoggedUsers = new CurrentlyLoggedUsers();
                currentlyLoggedUsers = loginLogs.CurrentlyLoggedUsers.Where(c => c.UserID == usr.ID).SingleOrDefault();
                if (currentlyLoggedUsers!=null)
                {
                    CurrentSessionData.CurrentUser = usr;
                    CurrentSessionData.UsedForLoggInEntity = db;
                    currentlyLoggedUsers.UserIsCurrentlyLogged = 1;
                    usrLogin.IsLogIn = 1;
                    loginLogs.UsersLogInLogs.Add(usrLogin);
                    loginLogs.SaveChanges();
                    loginLogs.Dispose();

                    return usr;
                 
                } else
                {
                    CurrentSessionData.CurrentUser = usr;
                    CurrentSessionData.UsedForLoggInEntity = db;
                    currentlyLoggedUsers = new CurrentlyLoggedUsers();
                    currentlyLoggedUsers.UserID = usr.ID;
                    currentlyLoggedUsers.UserIsCurrentlyLogged = 1;
                    db.CurrentlyLoggedUsers.Add(currentlyLoggedUsers);
                    usrLogin.IsLogIn = 1;
                    loginLogs.UsersLogInLogs.Add(usrLogin);
                    db.SaveChanges();
                    loginLogs.Dispose();

                    return usr;
                }              
            } else
            {
                return null;
            }
          }

        public void userLogOut()
        {
            if (CurrentSessionData.CurrentUser != null)
            {
                //securityDb = new FlameTradeDbEntities();
                securityDb.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=FlameTradeDb;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;Timeout=3;";
                UsersLogInLogs usersLogInLogs = new UsersLogInLogs();
                usersLogInLogs.UserID = CurrentSessionData.CurrentUser.ID;
                usersLogInLogs.LogOutTime = DateTime.Now;
                usersLogInLogs.IsLogIn = 0;
                securityDb.UsersLogInLogs.Add(usersLogInLogs);
                CurrentlyLoggedUsers currentlyLoggedUsers = securityDb.CurrentlyLoggedUsers.Where(c => c.UserID == CurrentSessionData.CurrentUser.ID).SingleOrDefault();
                if (CurrentSessionData.CurrentUser.ID!=3)
                {
                    currentlyLoggedUsers.UserIsCurrentlyLogged = 0;
                }
                securityDb.SaveChanges();
                CurrentSessionData.CurrentfrmMain = null;
                CurrentSessionData.CurrentUser = null;
                CurrentSessionData.UsedForLoggInEntity = null;
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


