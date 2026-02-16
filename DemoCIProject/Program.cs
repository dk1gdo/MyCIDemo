using DemoCIProject.Classes;

namespace DemoCIProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Enter first number: ");
        var calc = new Calc();
        var inputFirst = Console.ReadLine();
        Console.WriteLine("Enter Second number");
        var inputSecond = Console.ReadLine();
        var result =calc.Add(Convert.ToInt32(inputFirst), Convert.ToInt32(inputSecond));
        Console.WriteLine($"Result is {result}");
    }
}