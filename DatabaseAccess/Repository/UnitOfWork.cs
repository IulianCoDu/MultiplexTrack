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
        public void SaveChangesContext()
        {
            context.SaveChanges();
        }
        public void DisposeContext()
        {
            context.Dispose();
        }
    }
}
