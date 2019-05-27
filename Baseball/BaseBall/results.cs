using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall
{
    class Result
    {
        public int Strike;          //public = internal 
        public int Ball;          //public = internal 
        public int Out;          //public = internal 
        private object result;

        public bool IsCorrect()
        {
            // 복잡한 로직
            // todo: 하드코드 제거해야함
            return Strike == 3;
        }

        internal void Print()
        {
            Console.WriteLine($"S: {Strike}, B: {Ball}, O: {@Out}"); // string interpolation
        }
        public void Calculate(int[] answers, int[] guesses)
        {
            for (int i = 0; i < Constant.Digit; i++)
            {
                int j = (i + 1) % Constant.Digit;
                int k = (i + 2) % Constant.Digit;

                if (answers[i] == guesses[i])
                    Strike++;
                else if (answers[i] == guesses[j] || answers[i] == guesses[k])
                    Ball++;
                else
                    @Out++;

            }
        }

    }
}