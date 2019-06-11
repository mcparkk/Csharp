using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo.Logic
{
    public class Zealot // internal (assembly)
    {
        public Zealot()
        {
            _hp = 3;
            _shield = 5;
        }

        private int _hp;

        private int _shield;

        public void GetAttacked()
        {
            int damage = Randomizer.Instance.Next(1, 5);
            int initialDamage = damage;

            while (damage > 0)
            {
                if (_shield > 0)
                {
                    _shield--;

                    if (_shield == 0)
                        OnNoShield(initialDamage, _hp);
                }
                else if (_hp > 0)
                    _hp--;
                else
                    Console.WriteLine("dead");

                damage--;
            }
        }

        public int HP => _hp;
        //{
        //    get
        //    {
        //        return _hp;
        //    }
        //}

        #region NoShield event things for C# 3.0
        public event EventHandler<NoShieldEventArgs> NoShield;

        protected virtual void OnNoShield(NoShieldEventArgs e)
        {
            if (NoShield != null)
                NoShield(this, e);
        }

        private NoShieldEventArgs OnNoShield(int damage, int hp)
        {
            NoShieldEventArgs args = new NoShieldEventArgs(damage, hp);
            OnNoShield(args);

            return args;
        }

        private NoShieldEventArgs OnNoShieldForOut()
        {
            NoShieldEventArgs args = new NoShieldEventArgs();
            OnNoShield(args);

            return args;
        }

        public class NoShieldEventArgs : EventArgs
        {
            public int Damage { get; set; }
            public int Hp { get; set; }

            public NoShieldEventArgs()
            {
            }

            public NoShieldEventArgs(int damage, int hp)
            {
                Damage = damage;
                Hp = hp;
            }
        }
        #endregion
    }
}
