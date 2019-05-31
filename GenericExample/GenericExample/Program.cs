using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class Program
    {
        
        static void CatchedMonster<T>(T unit) where T : Monster
        {
            Console.WriteLine("Monster를 잡았습니다.");
            Console.WriteLine(unit.Introduce());
        }

        static void Main(string[] args)
        {
            MonsterList MonsterList = new MonsterList();
            Poketmon Pikachu = new Poketmon(60, "Pikachu");
            Console.WriteLine("monster가 나타났습니다. 잡으시겠습니까? yes->1, no->2");
            string anwer = Console.ReadLine();
            if (anwer == "2")
                Console.WriteLine(Pikachu.Name +"(이)가 떠났습니다");
            else
            CatchedMonster(Pikachu);
            MonsterList.AddList(Pikachu);
            


            Console.WriteLine();


            Digimon Agumon = new Digimon(80, "Agumon");
            Console.WriteLine("monster가 나타났습니다. 잡으시겠습니까? yes->1, no->2");
            string anwer2 = Console.ReadLine();
            if (anwer2 == "2")
                Console.WriteLine(Agumon.Name+"(이)가 떠났습니다.");
            else
            CatchedMonster(Agumon);
            MonsterList.AddList(Agumon);

            Console.WriteLine(MonsterList.GetList(Pikachu));
            Console.WriteLine(MonsterList.GetList(Agumon));
           
        }
    }
}
