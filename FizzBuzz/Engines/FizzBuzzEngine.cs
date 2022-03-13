using System;
using System.Collections.Generic;
using FizzBuzz.Rules;
using System.Text;

namespace FizzBuzz.Engines
{
    public class FizzBuzzEngine : IEngine
    {
        private readonly IEnumerable<IRule> rules;

        public FizzBuzzEngine(IEnumerable<IRule> rules)
        {
            this.rules = rules;
        }

        public string RunEngine(int number) {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var rule in rules)
            {
                if (rule.ShouldRun(number))
                {
                    stringBuilder.Append(rule.Evaluate(number));
                }
            }
            return stringBuilder.ToString();
        }
    }
}