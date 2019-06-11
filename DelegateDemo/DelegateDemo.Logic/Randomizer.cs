using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo.Logic
{
    internal class Randomizer
    {
        #region singleton
        private Randomizer()
        {
        }

        private static Randomizer _instance;

        public static Randomizer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Randomizer();

                return _instance;
            }
        }
        #endregion

        private Random _random = new Random();

        // wrapper method
        public int Next(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
