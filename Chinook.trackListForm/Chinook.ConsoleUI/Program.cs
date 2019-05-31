using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.ConsoleUI
{
    public static class Extension
    {
        // extension method
        public static bool IsEven(this int n)
        {
            return n % 2 == 0;
        }
    }

    class Program
    {
        // Func<int, bool>

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        static void Main(string[] args)
        {
            var albums = DataRepository.Album.Search(null, null);
            Console.WriteLine(albums.Count);

            albums = DataRepository.Album.Search("the", null);
            Console.WriteLine(albums.Count);

            albums = DataRepository.Album.Search("the", 1);
            Console.WriteLine(albums.Count);
        }
    }
}
