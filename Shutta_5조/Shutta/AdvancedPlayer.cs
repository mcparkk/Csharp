using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shutta
{
    public class AdvancedPlayer : Player
    {
        public AdvancedPlayer(int money) : base(money)
        {
        }

        public override void CalculateScore()
        {
            if (_cards[0].IsKwang == true && _cards[1].IsKwang == true) // 광떙
            {
                Score = (_cards[0].No + _cards[1].No) * 100;
                if((_cards[0].No == 1 && _cards[1].No == 3) || (_cards[0].No == 1 && _cards[1].No == 8) ||
                    (_cards[0].No == 3 && _cards[1].No == 1) || (_cards[0].No == 8 && _cards[1].No == 1))
                {
                    AmhaengoesaScore = 10;
                }
            }
            else if (_cards[0].No == _cards[1].No)
                Score = _cards[0].No * 10; // 10 ~ 100
            else
            {
                Score = (_cards[0].No + _cards[1].No) % 10; // 0 ~ 9
                if (_cards[0].IsSecretAgent == true && _cards[1].IsSecretAgent == true)
                {
                    AmhaengoesaScore = 11;
                }
                else if ((_cards[0].No == 4 && _cards[1].No == 9) || (_cards[0].No == 9 && _cards[1].No == 4))
                {
                    Score = 101; 
                }
            }
        }
    }
}
