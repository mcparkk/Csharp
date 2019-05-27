using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroodWar
{
    class Zergling : Zerg
    {
        public Zergling()
        {
            MaxHp = 40;
            hp = 40;
            attackPower = 10;
        }
        public override void MakeSound()
        {
            Console.WriteLine("GRrrrrrrrr");
        }
    }
}
