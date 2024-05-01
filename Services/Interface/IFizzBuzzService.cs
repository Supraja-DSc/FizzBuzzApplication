
namespace FizzBuzzApplication.Services.Interface;
public interface IFizzBuzzService
{
    IList<(string,ConsoleColor)> GetFizzBuzzNumbers(int input);
}