using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    public class MyStack<T>
    {
        private List<T> stack;

        public MyStack()
        {
            stack = new List<T>();
        }

        public int count() { return stack.Count(); }
        public T pop() 
        {
            T re = stack.Last();
            stack.Remove(re);
            return re;
        }

        public void push(T item) { stack.Add(item); }
    }
}
