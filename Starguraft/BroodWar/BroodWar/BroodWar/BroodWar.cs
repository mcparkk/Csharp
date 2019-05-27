using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroodWar
{
    abstract class BroodWar
    {
        protected int hp;
        // protected int mp = 0;
        protected int x, y;
        // protected bool movable = true;
        protected int attackPower;
        protected int MaxHp;
        
        public int getHp()
        {
            return hp;
        }
        public void setHp(int newHP)
        {
            hp = newHP;
        }

        public virtual void Attack(BroodWar Unit)
        {
            Unit.hp -= attackPower;
            // todo : BroodWar 타입이 프로토스일 경우 쉴드부터 차감
        }

        public abstract void Sound();
    }
}
