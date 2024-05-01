using FizzBuzzApplication.Interface;
using FizzBuzzApplication.Models;
using FizzBuzzApplication.Services.Interface;
using System.Drawing;

namespace FizzBuzzApplication.Services;

public class FizzBuzzService : IFizzBuzzService
{ 
    private readonly List<IFizzBuzzGenerator> _rules;

    public FizzBuzzService()
    {
        _rules = new List<IFizzBuzzGenerator>
        {
            new FizzBuzzGenerator(),
            new FizzGenerator(),
            new BuzzGenerator()
        };
    }

    public IList<(string, ConsoleColor)> GetFizzBuzzNumbers(int input)
    {
        var fizzBuzzNumbers = new List<(string,ConsoleColor)>();

        for (int i = 1; i <= input; i++)
        {
            string result = string.Empty;
            ConsoleColor color = ConsoleColor.White;

            foreach (var rule in _rules)
            {
                if (rule.IsInput(i))
                {
                    result += rule.Execute();
                    if (rule is FizzGenerator)
                        color = ConsoleColor.Blue; // Fizz color
                    else if (rule is BuzzGenerator)
                        color = ConsoleColor.Green; // Buzz color
                }
            }

            if (string.IsNullOrEmpty(result))
            {
                result = i.ToString();
            }

            fizzBuzzNumbers.Add((result,color));
        }

        return fizzBuzzNumbers;
    }
}