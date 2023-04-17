using System.Reflection;
using CommandLine;   
namespace DotnetToolExample;

public static class Program
{
    public class Options
    {
        [Option('c', "cat", Required = false, HelpText = "Print a cat")]
        public bool IsCatOpt { get; set; }
    }
    
    public static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed<Options>(o =>
            {
                if (o.IsCatOpt)
                {
                    PrintCat();
                }
                else
                {
                    Console.WriteLine("This is an example dotnet tool");
                }
            });
    }

    public static void PrintCat()
    {
        Console.WriteLine(" /\\_/\\");
        Console.WriteLine("( o.o )");
        Console.WriteLine(" > ^ <");
    }
}