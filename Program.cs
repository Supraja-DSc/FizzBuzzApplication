using FizzBuzzApplication;
using FizzBuzzApplication.Services.Interface;
using FizzBuzzApplication.Services;
using FizzBuzzApplication.Models;

public class Program
{
    public static void Main()
    {
        IFizzBuzzService fizzBuzzService = new FizzBuzzService();
        FizzBuzzController fizzBuzzController = new FizzBuzzController(fizzBuzzService);

        // Get FizzBuzz numbers for input 100
        FizzBuzzModel fizzBuzzModel = fizzBuzzController.GenerateFizzBuzz(100);

        // Display FizzBuzz numbers
        Console.WriteLine($"FizzBuzz numbers for input {fizzBuzzModel.Input}:");
        foreach (var number in fizzBuzzModel.FizzBuzzNumbers)
        {
            Console.WriteLine(number);
        }
    }
}