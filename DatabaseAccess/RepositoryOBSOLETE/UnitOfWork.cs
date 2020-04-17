using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Repository
{
    public class UnitOfWork : IDisposable
    {
        private MultiplexTrackDbContext context = new MultiplexTrackDbContext();
        private UserRepository _userRepository;

        public UserRepository GetUser
        {
            get 
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(context);
                }
                return _userRepository; 
            }
        }

        public void SaveChangesCustom()
        {
            context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public UserRepository User
        { get
            {
                return _userRepository;                
            } }
    }
}
