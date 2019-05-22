using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutDa
{
    public class Player
    {
        public Player(int money)
        {
            Money = money;

            _cards = new List<Card>();
        }
       

        public int Money { get; set; }

        private readonly List<Card> _cards;

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public virtual void CalculateScore()
        {
            //     List<int> jokbo = new List<int>();
            //    jokbo.Add(400);
            //    jokbo.Add(900);
            
            if (_cards[0].No == _cards[1].No)
                Score = _cards[0].No * 10; // 10 ~ 100
            else if (_cards[0].K == true && _cards[1].K == true)
                Score = (_cards[0].No + _cards[1].No) * 100;
            
            else //(_cards[0].No != _cards[1].No)
                Score = (_cards[0].No + _cards[1].No) % 10; // 0 ~ 9
            
        }

        public int Score { get; set; }
        
        // indexer
        public Card this[int index]
        {
            get
            {
                return _cards[index];
            }
        }

        public void PrepareRound()
        {
            _cards.Clear();
            Score = 0;
        }
       
    }
}
