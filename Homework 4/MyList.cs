using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    public class MyList<T>
    {
        List<T> list;

        public MyList()
        {
            list = new List<T>();
        }

        public void add(T item) { list.Add(item); }
        public T remove(int index)
        {
            T item = list[index];
            list.RemoveAt(index);
            return item;
        }
        public bool contains(T item)
        {
            return list.Contains(item);
        }
        public void clear() { list.Clear(); }
        public void insertAt(T item, int index)
        {
            list.Insert(index, item);
        }
        public void deleteAt(int index)
        {
            list.RemoveAt(index);
        }
        public T find(int index)
        {
            return list[index];
        }
    }
}
