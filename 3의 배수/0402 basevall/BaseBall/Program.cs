using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall
{
    class Program
    {
        const int Maxvalue = 10;
        const int Digit = 3;

        static void Main(string[] args)
        {
            // 1. (중복되지 않는 세 개의 0~9 사이의 정수로 이루어진)정답을 생성한다.
            // Random 클래스를 만든다- new random.
            Random random = new Random(); // 객체 생성- random에 객체를 생성(new random)한다.
            int[] answers = new int[Digit];          //상수 3자리
            //int answer0;            //선언 
            //int answer1;
            //int answer2;

            while (true)
            {
                //int i = 0;
                //while (i < Digit)
                //{
                //    answers[i] = random.Next(MaxValue)
                //    i++;  // i += 1 // i = i + i
                //}
                for (int j = 0; j < Digit; j++)
                {
                    answers[j] = random.Next(Maxvalue);
                }           
              

                
                answer0 = random.Next(Maxvalue);
                answer1 = random.Next(10);
                answer2 = random.Next(10);   // 대입

                if (answer0 != answer1 && answer1 != answer2 && answer2 != answer0)
                    break;
            }
            //random.Next(10);
            Console.WriteLine("[정답]");
            Console.Write(answer0 + " ");
            Console.Write(answer1 + " ");
            Console.Write(answer2 + " ");
            Console.WriteLine();

            int trycount = 0;           //시도횟수 선언
            while (true)            //다시 2로 돌아와서 재시동
            {
                trycount++;
                // 2. 추측을 입력받는다.-추측을 저장할 변수 3개
                int guess0 = int.Parse(Console.ReadLine());
            int guess1 = Convert.ToInt32(Console.ReadLine());         //두개가 같은 의미의 식
            int guess2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("[추측] ");
            Console.Write(guess0 + " ");
            Console.Write(guess1 + " ");
            Console.Write(guess2 + " ");
            Console.WriteLine();


            // 3. 정답과 추측을 비교하여 결과를 생성한다. 
            int strike = 0;
            int ball = 0;
            int @out = 0;            //out c#의 키워드 -> 변수명으로 사용 x , but @ 사용하면 가능

            if (answer0 == guess0)
                strike++;
            else if (answer0 == guess1 || answer0 == guess2)
                ball++;
            else
                @out++;

            if (answer1 == guess1)
                strike++;
            else if (answer1 == guess2 || answer1 == guess0)
                ball++;
            else
                @out++;

            if (answer2 == guess2)
                strike++;
            else if (answer2 == guess0 || answer2 == guess1)
                ball++;
            else
                @out++;


            // 4. 결과를 출력한다. 

            Console.WriteLine($"S:{strike}, B:{ball}, C:{@out}");


                // 5. 정답과 추측이 일치하지 않으면 2번으로 돌아간다. 
                if (strike == 3) ;
                break;
        }
            // 6. 정답을 맞추는데 걸린 횟수 출력하고 종료한다. 
            Console.WriteLine($"총 {trycount}번 만에 맞추셨습니다.");
        }
    }
}
