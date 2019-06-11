using SortLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = {3,5,1,2};

            // 대리자 객체 생성
            //Sorter.Sort(ar, InDescending);

            // 익명 메서드
            //Sorter.Sort(ar, delegate(int i, int j)
            //{
            //    return i < j;
            //});

            // 람다식
            //string b = "";
            //Action<string> name = x => b = x;
            //name("hi");
            //Console.WriteLine(b); 

            Sorter sorter = new Sorter();
            sorter.InnerEndReached += Sorter_InnerEndReached;
            sorter.Sort(ar, (i, j) => i > j);
           

            for (int i = 0; i < ar.Length; i++)
                Console.WriteLine(ar[i]);
        }

        private static void Sorter_InnerEndReached(object sender, Sorter.InnerEndReachedEventArgs e)
        {
            Console.WriteLine($"end of i : {e.I}");
        }

        private static bool InAscending(int i, int j)
        {
            return i > j;
        }

        private static bool InDescending(int i, int j)
        {
            return i < j;
        }
    }
}
