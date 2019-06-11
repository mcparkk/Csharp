using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuiz.Utilities
{
    internal class Randomizer
    {
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

        private Random _random = new Random();

        public int Next(int maxValue)
        {
            return _random.Next(maxValue);
        }

        public int Next(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }
    }
}
