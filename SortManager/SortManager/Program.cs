using System.Reflection.Metadata.Ecma335;
using System.Threading;
namespace SortManager;

internal class Program
{
    static void Main()
    {
        Title();
        string methodChoice = TakeMethodChoice();

        Sorter sorter = new Factory().CreateSorter(methodChoice);

        int length = TakeLengthChoice();

        var watch = new System.Diagnostics.Stopwatch();

        int[] randomArray = GenerateArray(length);

        watch.Start();
        int[] sortedArray = sorter.Sort(randomArray);
        watch.Stop();


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

    static int TakeLengthChoice()
    {
        WriteLine("Enter array length:");
        string input = Console.ReadLine();
        
        if(Int32.TryParse(input, out int length)) return length;

        WriteLine("Must be an integer");
        return TakeLengthChoice();
        
    }

    static int[] GenerateArray(int length)
    {
        int[] ints= new int[length];
        Random rand = new Random();
        for(int i =0; i< length; i++)
        {
            ints[i]= rand.Next();
        }
        WriteLine(String.Join(' ', ints));
        return ints;
    }
    public static void Title()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            if (i == 1) Console.ForegroundColor = ConsoleColor.Red;
            else if (i == 2) Console.ForegroundColor = ConsoleColor.Green;
            else if (i == 3) Console.ForegroundColor = ConsoleColor.Blue;
            else if (i == 4) Console.ForegroundColor = ConsoleColor.Gray; Console.Write(@"             
  /$$$$$$                                                /$$$$$$                        /$$                        
/$$__  $$                                              /$$__  $$                      | $$                        
| $$  \ $$  /$$$$$$   /$$$$$$  /$$$$$$  /$$   /$$      | $$  \__/  /$$$$$$   /$$$$$$  /$$$$$$    /$$$$$$   /$$$$$$ 
| $$$$$$$$ /$$__  $$ /$$__  $$|____  $$| $$  | $$      |  $$$$$$  /$$__  $$ /$$__  $$|_  $$_/   /$$__  $$ /$$__  $$
| $$__  $$| $$  \__/| $$  \__/ /$$$$$$$| $$  | $$       \____  $$| $$  \ $$| $$  \__/  | $$    | $$$$$$$$| $$  \__/
| $$  | $$| $$      | $$      /$$__  $$| $$  | $$       /$$  \ $$| $$  | $$| $$        | $$ /$$| $$_____/| $$      
| $$  | $$| $$      | $$     |  $$$$$$$|  $$$$$$$      |  $$$$$$/|  $$$$$$/| $$        |  $$$$/|  $$$$$$$| $$      
|__/  |__/|__/      |__/      \_______/ \____  $$       \______/  \______/ |__/         \___/   \_______/|__/      
                                        /$$  | $$                                                                  
                                       |  $$$$$$/                                                                  
                                        \______/                                                                    
            "); Thread.Sleep(1000);
        }
    }
}