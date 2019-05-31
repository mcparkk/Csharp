using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    public abstract class Monster
    {
       
        public Monster()
        {
           
        }

        public int Hp { get; set; }
        public string Name { get; set; }

        public string TypeOfMonster { get; set; }

        public abstract string Introduce();
        
    }

}
