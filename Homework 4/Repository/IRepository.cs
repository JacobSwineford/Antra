using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4.Repository
{
    public interface IRepository<T> where T : Entity
    {
        void add(T item);
        void remove(T item);
        void save();
        IEnumerable<T> getAll();
        T getById(int id);
    }
}
