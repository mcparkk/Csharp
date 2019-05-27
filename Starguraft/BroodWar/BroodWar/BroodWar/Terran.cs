using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroodWar
{
    class Terran : BroodWar
    {
        protected int MaxHp;
        protected int Hp;
        protected int repair;

        public override void Sound()
        {
            // sound for protoss units
            MakeSound();
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("protoss unit sound");
        }
        protected virtual void HPrepair()
        {
            if (Hp < MaxHp)
            {
                Hp++;
            }
        }
        protected virtual void getHp()
        {
            Console.WriteLine(Hp);
        }
    }
}
