using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPAM.Task7.Users.BLL;
using EPAM.Task7.Awards.BLL;
using EPAM.Task7.Awards.BLL.Interface;
using EPAM.Task7.BLL;
using EPAM.Task7.DAL;
using EPAM.Task7.DAL.Interface;
using EPAM.Task7.Users.BLL.Interface;

namespace EPAM.Task7.Common
{
    public static class DependencyResolver
    {
        private static IUserDao userDao;

        private static IUserLogic userLogic;

        private static IAwardDao awardDao;

        private static IAwardLogic awardLogic;

        public static IUserDao UserDao => userDao ?? (userDao = new UserSQLDao());

        public static IAwardDao AwardDao => awardDao ?? (awardDao = new AwardSQLDao());

        public static IAwardLogic AwardLogic => awardLogic ?? (awardLogic = new AwardLogic(AwardDao));

        public static IUserLogic UserLogic => userLogic ?? (userLogic = new UserLogic(UserDao));

        public static void SaveUserInfo()
        {
            UserDao.SaveUserStorage();
        }

        public static void SaveAwardInfo()
        {
            AwardDao.SaveAwardStorage();
        }

        public static void SaveAwardToUserInfo()
        {
            AwardDao.SaveAwardToUserStorage();
        }
    }
}
