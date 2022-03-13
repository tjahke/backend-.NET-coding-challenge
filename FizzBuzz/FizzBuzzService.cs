using System;
using System.Collections.Generic;
using FizzBuzz.Engines;
using FizzBuzz.Rules;

namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public void RunFizzBuzz(int limit)
        {
            List<IRule> rules = new List<IRule>();
            rules.Add(new DivisibleBy(3, "Fizz"));
            rules.Add(new DivisibleBy(5, "Buzz"));

            FizzBuzzEngine engine = new FizzBuzzEngine(rules);
            
            for (int number = 1; number <= limit; number++)
            {
                Console.WriteLine($"{number}: {engine.RunEngine(number)}");
            }
        }
    }
}