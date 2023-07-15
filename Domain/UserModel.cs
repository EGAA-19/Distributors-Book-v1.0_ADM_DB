using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        public List<Entity> ListDistributors(string NameCompany)
        {
            return userDao.ListDistributors(NameCompany);
        }

        public Entity ObtainDistributor(int Id)
        {
            return userDao.ObtainDistributor(Id);
        }

        public Entity UploadDistributor(Entity entity)
        {
            return userDao.UploadDistributor(entity);
        }

        public void DeleteDistributor(int Id)
        {
            userDao.DeleteUpdate(Id);
        }







    }
}
