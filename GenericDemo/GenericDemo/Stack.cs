using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Stack<T> where T:IComparable<T>
    {
        private List<T> _list = new List<T>();

        private int _index;

        public void Push(T x)
        {
            _list.Add(x);
            _index++;

            if (_index > 1)
                if (_list[_index - 1].CompareTo(_list[_index - 2]) > 0)
                    Console.WriteLine("greater " + _list[_index - 1].ToString());
        }

        public T Pop()
        {
            _index--;
            return _list[_index];
        }
    }
}
