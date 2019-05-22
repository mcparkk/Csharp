using Database.Step4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Step4.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Album a= DataRepository.Album.GetByPK(5);
            Console.WriteLine(a.Title);
           
        }

        private static void PrintLog(string log)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine(log);
            Console.WriteLine("---------------------");
        }
    }
}
