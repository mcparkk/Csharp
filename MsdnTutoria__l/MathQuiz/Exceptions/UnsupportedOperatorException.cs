using System;

namespace MathQuiz.Exceptions
{
    public class UnsupportedOperatorException : Exception
    {
        public UnsupportedOperatorException(string @operator)
        {
            Operator = @operator;
        }

        public string Operator { get; }
    }
}
