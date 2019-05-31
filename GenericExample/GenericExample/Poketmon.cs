using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class Poketmon : Monster
    {
        public Poketmon(int hp, string name)
        {
            Hp = hp;
            Name = name;
            TypeOfMonster = "Poketmon";
        }

        public override string Introduce()
        {
            return $"{TypeOfMonster}이며 이름은 {Name} 체력은 {Hp}입니다.";
        }
    }
}
