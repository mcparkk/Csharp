using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroodWar
{
    class Vulture : Terran
    {
        public Vulture()
        {
            MaxHp = 120;
            hp = 120;
            attackPower = 25;
        }

        public override void Attack(BroodWar Unit)
        {
            // base.Attack(Unit);
            Unit.setHp(Unit.getHp() - attackPower * 2);
        }

        public override void MakeSound()
        {
            Console.WriteLine("I'm going");
        }
    }
}