using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Repository
{
    public class UnitOfWork
    {
        private EFDBEntities context = new EFDBEntities();
        private UserRepository userRepository;
        public void SaveChangesCustom()
        {
            context.SaveChanges();
        }
        public void DisposeCustom()
        {
            context.Dispose();
        }

        public UserRepository User
        { get
            {
                return userRepository;                
            } }
    }
}
