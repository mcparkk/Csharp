using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroodWar
{
    class Zealot : Protoss
    {
        public Zealot()
        {
            hp = 100;
            MaxShield = 60;
            shield = 60;
            attackPower = 11;
        }

        public override void Attack(BroodWar Unit)
        {
            // base.Attack(Unit);
            Unit.setHp(Unit.getHp() - attackPower * 2);
        }

        public override void MakeSound()
        {
            Console.WriteLine("My life for Aiur");
        }
    }
}
