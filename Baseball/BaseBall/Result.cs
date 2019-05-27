using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall
{
    class Result
    {
        public int Strike;
        public int Ball;
        public int Out;

        public bool IsCorrect()
        {
            // 엄청 복잡한 로직이라능
            return Strike == Constant.Digit;
        }

        public void Print()
        {
            Console.WriteLine($"S: {Strike}, B: {Ball}, O: {Out}"); // string interpolation
        }

        public void Calculate(Answer answer, Guess guess)
        {
            for (int i = 0; i < Constant.Digit; i++)
            {
                int j = (i + 1) % Constant.Digit;
                int k = (i + 2) % Constant.Digit;

                if (answer.At(i) == guess.At(i))
                    Strike++;
                else if (answer.At(i) == guess.At(j) || answer.At(i) == guess.At(k))
                    Ball++;
                else
                    Out++;
            }
        }
    }
}
