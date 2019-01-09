using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPAM.Task7.Entities;

namespace EPAM.Task7.DAL.Interface
{
    public interface IUserDao
    {
        void Add(User user);

        bool Delete(int id);

        User GetById(int id);

        IEnumerable<User> GetAll();

        void SaveUserStorage();
    }
}
