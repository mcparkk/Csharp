using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void foo(Snake s){s.Age++;}

        static void foo(Cat c){c.Age++;}

        static void Main(string[] args)
        {
            Math mat1 = new Math();
            Math mat2 = new Math();
            double s1 = mat1.Pow(2, 3);
            double s2 = mat2.Pow(2, 3);


            double s3 = Math.Pow(2, 3);




            Marine m1 = new Marine();
            Marine m2 = new Marine();
            m1.HP -= 30;

            Marine.UpgradeHP();

            m1.Heal();
        }

        static int CountA(object o)
        {
            string str = o.ToString().ToLower();
            return str.Count(x => x == 'a');
        }
    }
}
