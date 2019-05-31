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
            string albumName = "the";
            int minArtistId = 5;
            int maxArtistId = 100;

            //List<Album> albums = DataRepository.Album.GetAll(x =>           
                                    //x.Title.Contains(albumName) && 
                                    //x.ArtistId >= minArtistId && 
                                    //x.ArtistId <= maxArtistId);
            List<Album> albums = DataRepository.Album.Search(albumName, minArtistId, maxArtistId);


            // select ArtistID from Artist

            List<string> list = DataRepository.Artist.Select(x => x.Name, x => x.ArtistId < 5);
            foreach (string name in list)
                Console.WriteLine(name);

            List<int> list2 = DataRepository.Artist.Select(x => x.ArtistId);
            foreach (int artistId in list2)
                Console.WriteLine(artistId);

            List<int> list3 = DataRepository.Album.Select(x => x.AlbumId);
            foreach (int albumId in list2)
                Console.WriteLine(albumId);
        }
    }
}
