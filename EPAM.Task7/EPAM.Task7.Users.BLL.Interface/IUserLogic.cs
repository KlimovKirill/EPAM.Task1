using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPAM.Task7.Entities;

namespace EPAM.Task7.Users.BLL.Interface
{
    public interface IUserLogic
    {
        void Add(User user);

        void Delete(int id);

        User GetById(int id);

        IEnumerable<User> GetAll();
    }
}
