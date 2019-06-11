using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Firebat : Unit
    {
        public override string FullName
        {
            get
            {
                return "Firebat";
            }
        }

        public string SayName()
        {
            return "Firebat";
        }
    }
}
