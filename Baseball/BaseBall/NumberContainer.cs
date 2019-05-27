using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall
{
    class NumberContainer
    {
        // public : 제한 없음
        // private : 클래스 안에서만
        // protected : 후손들

        protected int[] numbers = new int[Constant.Digit];

        public int At(int index)
        {
            return numbers[index];
        }

        public void Print()
        {
            // todo: 둘 중 하나만 출력해야 한다능
            Console.WriteLine("[추측] ");
            //Console.WriteLine("[정답] ");
            for (int i = 0; i < Constant.Digit; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }

    }
}
