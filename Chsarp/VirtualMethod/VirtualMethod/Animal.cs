using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Car : IRunable
    {
        public void Run()
        {
            Console.WriteLine("a car is running");
        }
    }
}
