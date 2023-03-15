using System.Reflection.Metadata.Ecma335;
using System.Threading;
namespace SortManager;

internal class Program
{
    static void Main()
    {
        string methodChoice = TakeMethodChoice();

        Sorter sorter = new Factory().CreateSorter(methodChoice);
    }

    public static void WriteLine(string input)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (char c in input)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine("");
    }

    static string TakeMethodChoice()
    {
        string[] methods = { "1 Bubblesort", "2 Mergesort" };
        WriteLine("Which Method");
        foreach(string method in methods)
        {
            WriteLine(method);
        }
        string choice = Console.ReadLine();

        if (CheckChoice(choice)) return choice;

        WriteLine("Not a valid choice");
        return TakeMethodChoice();
    }

    static bool CheckChoice(string choice)
    {
        string[] choices = { "bubblesort", "mergesort" };

        return choices.Contains(choice.ToLower());  
    }
}