using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPAM.Task7.DAL;
using EPAM.Task7.DAL.Interface;
using EPAM.Task7.Entities;
using EPAM.Task7.Users.BLL.Interface;

namespace EPAM.Task7.BLL
{

        public class UserLogic : IUserLogic
        {
            private readonly IUserDao userDao;

            public UserLogic(IUserDao inpUserDao)
            {
                this.userDao = inpUserDao;
            }

            public void Add(User user)
            {
                this.userDao.Add(user);
            }

            public void Delete(int id)
            {
                this.userDao.Delete(id);
            }

            public User GetById(int id)
            {
                return this.userDao.GetById(id);
            }

            public IEnumerable<User> GetAll()
            {
                return this.userDao.GetAll();
            }
        }
}
