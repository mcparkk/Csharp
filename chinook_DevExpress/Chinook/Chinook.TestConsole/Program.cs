using Chinook.Data;
using Chinook.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pastel;
using System.Drawing;

// 2 : Generic
// 3 : LINQ
// 4 : dynamic
// 5 : async / await

namespace Chinook.TestConsole
{
    class Program
    {
        private const string Path = "model.json";

        static void Foo(int a, int b = 0, int c = 0)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        private static void PrintName(dynamic entity)
        {
            Console.WriteLine(entity.Name);
        }

        static void Main(string[] args)
        {
            PrintName(new Artist{ Name = "ar"});
            PrintName(new Track{ Name = "tr"});
            //PrintName(new Album());
        }

        private static void Deserialize()
        {
            string json = File.ReadAllText(Path);

            List<AlbumModel> models = JsonConvert.DeserializeObject<List<AlbumModel>>(json);
        }

        private static void Serialize()
        {
            List<AlbumModel> models = new List<AlbumModel>
            {
                new AlbumModel{Letter="A", Count= 3 },
                new AlbumModel{Letter="B", Count= 5 },
            };

            string json = JsonConvert.SerializeObject(models);

            File.WriteAllText(Path, json);
        }
    }
}
