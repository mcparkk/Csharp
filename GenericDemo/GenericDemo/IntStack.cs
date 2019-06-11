using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class IntStack
    {
        private List<int> _list = new List<int>();

        private int _index;

        public void Push(int x)
        {
            _list.Add(x);
            _index++;
        }

        public int Pop()
        {
            _index--;
            return _list[_index];
        }
    }
}
