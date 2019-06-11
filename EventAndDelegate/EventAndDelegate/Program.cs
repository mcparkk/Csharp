using PeopleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(32, "김과장");

            person.AgeChanged += Person_AgeChanged;
            person.AgeChanging += Person_AgeChanging;

            //person.AgeChanged = (oldAge, newAge) =>
            //{
            //    Console.WriteLine($"{oldAge} -> {newAge} : {birthYear}생");
            //};


            Console.WriteLine("before : " + person.Age);
            person.IncreaseAge();
            Console.WriteLine("after : " + person.Age);
        }

        private static void Person_AgeChanging(object sender, Person.AgeChangingEventArgs e)
        {
            Console.WriteLine("나이를 한 살 더 먹을까요");
            string answer = Console.ReadLine();
            if (answer == "n")
                e.Cancel = true;
        }

        private static void Person_AgeChanged(object sender, Person.AgeChangedEventArgs e)
        {
            Console.WriteLine($"{e.OldAge} -> {e.NewAge}");
        }
    }
}
