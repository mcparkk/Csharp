using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shutta
{
    class Program
    {
        public const int PlayerCount = 2;
        static int BetMoney = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("******SHUTTA GAME******");
            Console.WriteLine("***********************");
            Console.WriteLine("게임의 룰을 선택하세요. (1:기본룰, 2:확장룰)");
            string inputText = Console.ReadLine();
            int input = int.Parse(inputText);
            RuleType ruleType = (RuleType)input;
            Console.WriteLine("얼마를 충전하시겠습니까?");
            int SeedMoney = int.Parse(Console.ReadLine());
            Console.WriteLine($"{SeedMoney}원을 충전하셨습니다.");
            Console.WriteLine();


            // 각 선수들이 시드 머니를 가진다.
            List<Player> players = new List<Player>();
            for (int i = 0; i < PlayerCount; i++)
            {
                if (ruleType == RuleType.Basic)
                    players.Add(new Player(SeedMoney));
                else if (ruleType == RuleType.Advanced)
                    players.Add(new AdvancedPlayer(SeedMoney));
            }

            int round = 1;
            // 선수 중 파산(오링)하는 사람이 있을 때 까지 라운드를 진행한다.
            while (true)
            {
                if (CanRunRound(players) == false)
                    break;

                Console.WriteLine($"[Round {round++}]");

                // 라운드를 진행한다
                RunRound(players);

                //Console.WriteLine("======================");

                // 선수들이 가진 돈을 출력한다.
                PrintMoney(players);

                Console.WriteLine();
                Console.WriteLine("게임을 계속 진행하시겠습니까?");
                Console.WriteLine("=> 1.Continue 2.Exit <=");
                int continueGame = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if(continueGame == 2)
                {
                    Console.WriteLine("게임을 종료하셨습니다.");
                    Console.WriteLine($"남은 돈은 {players[1].Money}원 입니다.");
                    break;
                }
            }
        }

        private static void PrintMoney(List<Player> players)
        {
            for (int i = 0; i < players.Count; i++)
                Console.WriteLine($"Player{i} has \\{players[i].Money}");
        }

        private static bool CanRunRound(List<Player> players)
        {
            if (totalBetMoney != 0)
                return true;

            foreach (Player player in players)
                if (player.Money <= 0)
                    return false;

            return true;
        }
        static int totalBetMoney = 0;
        static void RunRound(List<Player> players)
        {
            // 각 선수가 이전 라운드에서 받은 카드를 클리어한다.
            foreach (Player player in players)
                player.PrepareRound();

            // 딜러가 각 선수들에게 2장씩 카드를 돌린다
            Dealer dealer = new Dealer();
            foreach (Player player in players) {
                for (int i = 0; i < 2; i++)
                    player.AddCard(dealer.Draw());
            }
            Console.WriteLine($"나(Player1)의 패는 \"{players[1][0]}\", \"{players[1][1]}\" 입니다.");
            Console.WriteLine($"현재 BettingMoney는 \"{BetMoney}원\"입니다.");
            Console.WriteLine("BettingMoney를 교체하시겠습니까?");
            Console.WriteLine("=> 1.Continue 2.Change BettingMoney <=");
            int ContinueGame = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (ContinueGame == 2)
            {
                Console.WriteLine("BettinMoney를 얼마로 하시겠습니까?");
                int ChangeBetMoney = int.Parse(Console.ReadLine());
                BetMoney = ChangeBetMoney;
                Console.WriteLine($"BettingMoney가 {BetMoney}원으로 변경되었습니다.");
                Console.WriteLine();
            }

            foreach (Player player in players)
            {
                player.Money -= BetMoney;
                totalBetMoney += BetMoney;
            }

            // 각 선수들의 족보를 계산하고 출력한다.
            for (int i = 0; i < players.Count; i++)
            {
                Player p = players[i];

                p.CalculateScore();
                Console.WriteLine($"Player{i} ({p[0]}, {p[1]}) => {p.Score}");
            }

            // 승자와 패자를 가린다.
            Player winner = FindWinner(players);

            if (winner != null)
            {
                winner.Money += totalBetMoney;
                totalBetMoney = 0;
            }
        }

        private static Player FindWinner(List<Player> players)
        {
            //return players.OrderByDescending(x => x.Score).First();
            if (Math.Abs(players[0].AmhaengoesaScore - players[1].AmhaengoesaScore) == 1)
            {
                if (players[0].AmhaengoesaScore - players[1].AmhaengoesaScore > 0)
                {
                    Console.WriteLine("====>암행어사출두요~~~ \"Computer\"가 이겼습니다.");
                    return players[0];
                }
                else
                {
                    Console.WriteLine("====>암행어사출두요~~~ \"내(Player1)\"가 이겼습니다.");
                    return players[1];
                }
            }

            if (players[0].Score == players[1].Score)
            {
                Console.WriteLine("====>무승부입니다. 배팅머니는 다음판으로 누적되었습니다.");
                return null;
            }
            else if ((players[0].Score <= 100 && players[1].Score == 101) ||
                (players[1].Score <= 100 && players[0].Score == 101)) //49파토
            {
                Console.WriteLine("====>무승부입니다. 배팅머니는 다음판으로 누적되었습니다.");
                return null;
            }
            else
            {
                Player p = (players[0].Score > players[1].Score) ? players[0] : players[1];
                String inputText = (p == players[0]) ? "====>\"Computer\"가 이겼습니다." : "====>\"내(Player1)\"가 이겼습니다.";
                Console.WriteLine(inputText);
                return p;
            }
        }
    }
}
