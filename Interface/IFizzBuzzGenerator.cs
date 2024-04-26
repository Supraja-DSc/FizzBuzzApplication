namespace FizzBuzzApplication.Interface;
public interface IFizzBuzzGenerator
{
    bool IsInput(int input);

    string Execute();
}