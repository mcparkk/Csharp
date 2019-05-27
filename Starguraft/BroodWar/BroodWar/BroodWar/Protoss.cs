using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroodWar
{
    abstract class Protoss : BroodWar
    {
        protected int MaxShield;
        protected int shield;

        
        protected virtual void shieldRegen()
        {
            if (shield < MaxShield)
            {
                shield++;
            }
        }
        public int getShield()
        {
            return shield;
        }
        public void setShield(int newShield)
        {
            shield = newShield;
        }
        public override void Sound()
        {
            // sound for protoss units
            MakeSound();
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("protoss unit sound");
        }
    }
}
