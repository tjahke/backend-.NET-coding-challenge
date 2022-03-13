using System;

namespace FizzBuzz.Rules
{
    public class DivisibleBy : IRule
    {
        private readonly int divisor;
        private readonly string text;

        public DivisibleBy(int divisor, string text)
        {
            this.divisor = divisor;
            this.text = text;
        }

        public string Evaluate(int number)
        {
            return text;
        }
        public bool ShouldRun(int number)
        {
            return number % divisor == 0;
        }
    }
}