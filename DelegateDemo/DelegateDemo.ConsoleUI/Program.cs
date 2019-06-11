using DelegateDemo.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Zealot zealot = new Zealot();
            zealot.NoShield += NoShieldHandler;

            while (zealot.HP > 0)
            {
                zealot.GetAttacked();
                Console.ReadLine();
            }

            Console.WriteLine("dead");
        }

        private static void NoShieldHandler(object sender, 
           Zealot.NoShieldEventArgs e)
        {
            Console.WriteLine($"no shield, damage : {e.Damage}, hp : {e.Hp}");
        }
    }
}
