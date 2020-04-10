using DatabaseAccess.Models;
using System.Collections.Generic;

namespace DatabaseAccess.Repository
{
    public class UserRepository : IRepository<User>
    {
        private MultiplexTrackDbContext context;
        public UserRepository(MultiplexTrackDbContext context)
        {
            this.context = context;
        }

        public void Create(User item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(User id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return context.Users;
        }

        public void Update(User itemOld, User itemNew)
        {
            throw new System.NotImplementedException();
        }
    }
}
