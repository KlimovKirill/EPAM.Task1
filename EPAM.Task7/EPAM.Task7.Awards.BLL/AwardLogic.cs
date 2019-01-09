using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPAM.Task7.Awards.BLL.Interface;
using EPAM.Task7.DAL;
using EPAM.Task7.DAL.Interface;
using EPAM.Task7.Entities;

namespace EPAM.Task7.Awards.BLL
{
    public class AwardLogic : IAwardLogic
    {
        private readonly IAwardDao awardDao;

        public AwardLogic(IAwardDao inpAwardDao)
        {
            this.awardDao = inpAwardDao;
        }

        public void Add(Award award)
        {
            this.awardDao.Add(award);
        }

        public void Delete(int id)
        {
            this.awardDao.Delete(id);
        }

        public Award GetById(int id)
        {
            return this.awardDao.GetById(id);
        }

        public void AddAwardToUser(int awardId, int userId)
        {
            this.awardDao.AddAwardToUser(awardId, userId);
        }

        public Dictionary<int, List<int>> GetDictOfAwardsAndUsers()
        {
            return this.awardDao.GetDictOfAwardsAndUsers();
        }

        public IEnumerable<Award> GetAll()
        {
            return this.awardDao.GetAll();
        }
    }
}
