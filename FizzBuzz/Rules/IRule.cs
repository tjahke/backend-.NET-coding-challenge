using System;

namespace FizzBuzz.Rules
{
    public interface IRule
    {
        string Evaluate(int number);
        bool ShouldRun(int number);
    }
}