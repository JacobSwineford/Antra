using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4.Repository
{
    internal class GenericRepository<T> : IRepository<T> where T : Entity
    {
        void IRepository<T>.add(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IRepository<T>.getAll()
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.getById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.remove(T item)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.save()
        {
            throw new NotImplementedException();
        }
    }
}
