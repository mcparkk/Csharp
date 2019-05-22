using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{

    abstract class Person : IRunable
    {
        public int Age { get; set; }

        public abstract void SayHello();

        public void Run()
        {
            Console.WriteLine("a (wo)man is running");
        }
    }

    class Korean : Person
    {
        public override void SayHello()
        {
            Console.WriteLine("안녕하세요");
        }

        public virtual void StopIt()
        {
            Console.WriteLine("그만했으면 좋겠어요.");
        }
    }

    class Busanian : Korean
    {
        public override void StopIt()
        {
            Console.WriteLine("쫌!!!");
        }
    }

    class Suwonian : Korean
    {
    }

    class American : Person
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
