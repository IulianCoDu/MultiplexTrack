using DatabaseAccess.Models;
using System.Collections.Generic;

namespace DatabaseAccess.Repository
{
    public class UserRepository : IRepository<Users>
    {
        private MultiplexTrackDbContext context;
        public UserRepository(MultiplexTrackDbContext context)
        {
            this.context = context;
        }

        public void Create(Users item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Users id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Users> GetAll()
        {
            return context.Users;
        }

        public void Update(Users itemOld, Users itemNew)
        {
            throw new System.NotImplementedException();
        }
    }
}
