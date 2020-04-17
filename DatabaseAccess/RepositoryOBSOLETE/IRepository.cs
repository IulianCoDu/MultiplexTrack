using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Repository
{
    interface IRepository<T> where T : class //constraint: The type argument must be a class/reference type
    {
        IEnumerable<T> GetAll(); //objects
        void Create(T item);
        void Update(T itemOld, T itemNew);
        void Delete(T id);
    }
}
