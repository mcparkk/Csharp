using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroodWar 
{
    class Zerg : BroodWar
    {

        public override void Sound()
        {
            // sound for protoss units
            MakeSound();
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("protoss unit sound");
        }
        public virtual void HpRegen()
        {
            if (hp < MaxHp)
            {
                hp++;
            }
        }        
    }
}
