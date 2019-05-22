using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IRunable c = new Car();
            IRunable k = new Korean();

            List<IRunable> runners = new List<IRunable>();
            runners.Add(new Car());
            runners.Add(new Busanian());

            Run(c);
            Run(k);
        }

        static void Run(Car runnable)
        {
            runnable.Run();
        }

        static void Run(Person runnable)
        {
            runnable.Run();
        }

        static void Run(IRunable runnable)
        {
            runnable.Run();
        }
    }
}
