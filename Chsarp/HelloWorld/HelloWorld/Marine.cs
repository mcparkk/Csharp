using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Marine
    {
        public Marine()
        {
            HP = 50;
        }

        public int HP;

        private static int MaxHP = 50;

        public static void UpgradeHP()
        {
            // 정적 멤버에서는 비정적 멤버에 접근 불가
            //HP--; 

            MaxHP += 10;
        }

        public void Heal()
        {
            // 비정적 멤버는 정적 멤버에 접근 가능

            while (HP <= MaxHP)
            {
                HP++;
            }
        }
    }
}
