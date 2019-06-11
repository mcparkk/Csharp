using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public interface IName
    {
        string SayName();
    }

    class Program
    {
        static void Introduce<T>(T m) where T:Unit
        {
            Console.Write("I am ");
            Console.WriteLine(m.FullName);
            Console.WriteLine("Thank you");
        }

        static void Introduce(Marine m)
        {
            Console.Write("I am ");
            Console.WriteLine(m.SayName());
            Console.WriteLine("Thank you");
        }

        static void Introduce(Firebat m)
        {
            Console.Write("I am ");
            Console.WriteLine(m.SayName());
            Console.WriteLine("Thank you");
        }

        static void Main(string[] args)
        {
            Marine m = new Marine(3, "john");
            Introduce(m);

            Firebat f = new Firebat();
            Introduce(f);
            return;



            var stack = new Stack<int>(); // var 동적타입X
            stack.Push(3);
            stack.Push(5);
            stack.Push(1);
            stack.Push(2);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            var ms = new Stack<Marine>();
            ms.Push(new Marine(3, "john"));
            ms.Push(new Marine(5, "paul"));
            ms.Push(new Marine(1, "george"));
            ms.Push(new Marine(2, "ringo"));

            Console.WriteLine(ms.Pop());
            Console.WriteLine(ms.Pop());
            Console.WriteLine(ms.Pop());
            Console.WriteLine(ms.Pop());
        }
    }
}
