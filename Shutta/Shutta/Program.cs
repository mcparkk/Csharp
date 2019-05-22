using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutDa
{
    class Program
    {
        public const int PlayerCount = 2;
        public const int SeedMoney = 500000;
        private const int BetMoney = 100000;
        static void Main(string[] args)
        {
            Console.WriteLine("[섰다]게임에 입장하신 것을 환영합니다.");

            List<Player> players = new List<Player>();
            for (int i = 0; i < PlayerCount; i++)
                players.Add(new Player(SeedMoney));

            int round = 1;
            while (true)
            {
                if (CanRunRound(players) == false)
                    break;

                Console.WriteLine($"[Round {round++}]");

                // 라운드를 진행한다
                RunRound(players);

                // 선수들이 가진 돈을 출력한다.
                PrintMoney(players);

                Console.WriteLine();
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. 콜");
            Console.WriteLine("2. 다이");
        }

        private static int PlayGame(List<Player> players, int totalBetMoney)
        {
            while (true)
            {
                PrintMenu();
                int select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    int selectionOfComputer = SelectionOfComputer();
                    if (select == selectionOfComputer)
                    {
                        Console.WriteLine();
                        Console.WriteLine("==========================================");
                        Console.WriteLine("컴퓨터가 콜을 했습니다.");
                        totalBetMoney = BettingMoney(players, totalBetMoney);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("==========================================");
                        Console.WriteLine("컴퓨터가 다이를 했습니다.");
                        Console.WriteLine("패를 공개하고 라운드를 종료합니다.");
                        totalBetMoney = BettingMoney(players, totalBetMoney);
                        return totalBetMoney;
                    }
                }
                else if (select == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("==========================================");
                    Console.WriteLine("플레이어가 다이를 했습니다.");
                    Console.WriteLine("패를 공개하고 라운드를 종료합니다.");
                    totalBetMoney = BettingMoney(players, totalBetMoney);
                    return totalBetMoney;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("1과 2중에서 선택해주세요.");
                }
            }
        }

        private static int BettingMoney(List<Player> players, int totalBetMoney)
        {
            foreach (Player player in players)
            {
                player.Money -= BetMoney;
                totalBetMoney += BetMoney;
            }
            return totalBetMoney;
        }

        private static int SelectionOfComputer()
        {
            Random rand = new Random();
            int selection = rand.Next(1, 3);
            return selection;
        }

        private static void PrintMoney(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============== 현재 금액 =================");
            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"You have \\{players[i].Money}");
                }
                else
                {
                    Console.WriteLine($"Computer has \\{players[i].Money}");
                }
            }
            Console.WriteLine("==========================================");
        }

        private static bool CanRunRound(List<Player> players)
        {
            foreach (Player player in players)
                if (player.Money <= 0)
                    return false;

            return true;
        }

        static void RunRound(List<Player> players)
        {
            // 각 선수가 이전 라운드에서 받은 카드를 클리어한다.
            foreach (Player player in players)
                player.PrepareRound();

            // 선수들이 학교를 간다
            int totalBetMoney = 0;

            // 딜러가 각 선수들에게 2장씩 카드를 돌린다
            Dealer dealer = new Dealer();
            foreach (Player player in players)
                for (int i = 0; i < 2; i++)
                    player.AddCard(dealer.Draw());

            Console.WriteLine($"뽑은 카드 : ({players[0][0]}, {players[0][1]})");
            totalBetMoney = PlayGame(players, totalBetMoney);
            Console.WriteLine($"컴퓨터의 카드 : ({players[1][0]}, {players[1][1]})");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("================ 점   수 =================");
            // 각 선수들의 족보를 계산하고 출력한다.
            for (int i = 0; i < players.Count; i++)
            {

                Player p = players[i];

                p.CalculateScore();
                

                if (i == 0)
                {
                    Console.WriteLine($"Player ({p[0]}, {p[1]}) => 점수 : {p.Score}");
                }
                else
                {
                    Console.WriteLine($"Computer ({p[0]}, {p[1]}) => 점수 : {p.Score}");
                }
            }

            Console.WriteLine("==========================================");

           
            
        if (players[0].Score == players[1].Score)
            {
                Console.WriteLine("동점입니다. 재대결을 진행합니다.");
                foreach(Player player in players)
                {
                    player.Money += (totalBetMoney / 2);
                }

            }
        else
            {
                Player winner = FindWinner(players);
                winner.Money += totalBetMoney;
            }
        }
        

        private static Player FindWinner(List<Player> players)
        {
            // return players.OrderByDescending(x => x.Score).First();

            int maxScore = 0;
            
            foreach (Player player in players)
                if (player.Score > maxScore)
                    maxScore = player.Score;

            foreach (Player player in players)
                if (player.Score == maxScore)

                    return player;

            // return null;
            throw new Exception("승자를 찾을 수 없음");
        }
    }
}