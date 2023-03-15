using System.Reflection.Metadata.Ecma335;
using System.Threading;
namespace SortManager;

public class Program
{
    static void Main()
    {
        Title();
        string methodChoice = TakeMethodChoice().ToLower();

        Sorter sorter = new Factory().CreateSorter(methodChoice);

        int length = TakeLengthChoice();
        int maximumNumber = TakeMaxChoice();

        var watch = new System.Diagnostics.Stopwatch();

        int[] randomArray = GenerateArray(length, maximumNumber);

        watch.Start();
        int[] sortedArray = methodChoice == "countsort" ? sorter.Sort(randomArray, maximumNumber) : sorter.Sort(randomArray);
        watch.Stop();

        WriteLine("Your Sorted Array:");
        Console.WriteLine($"{String.Join(' ', sortedArray)} Sorted in: {watch.Elapsed.TotalMilliseconds} ms");
    }

    public static void WriteLine(string input)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (char c in input)
        {
            Console.Write(c);
            Thread.Sleep(10);
        }
        Console.WriteLine("");
    }


    static string TakeMethodChoice()
    {
        string[] methods = { "1 Bubblesort", "2 Mergesort", "3 Insertionsort" };
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

    public static bool CheckChoice(string choice)
    {
        string[] choices = { "bubblesort", "mergesort", "insertionsort" };

        return choices.Contains(choice.ToLower());  
    }

    static int TakeLengthChoice()
    {
        WriteLine("Enter array length:");
        string input = Console.ReadLine();
        
        if(Int32.TryParse(input, out int length)) return length;
        if (length < 1)
        {
            WriteLine("Must be greater than 0");
            return TakeLengthChoice();
        }

        WriteLine("Must be an integer");
        return TakeLengthChoice();
        
    }
    static int TakeMaxChoice()
    {
        WriteLine("Enter maximum element size");
        string input = Console.ReadLine();
        if (Int32.TryParse(input, out int max) && max > 0) return max;
        

        WriteLine("Must be a positive integer");
        return TakeMaxChoice();

    }

    public static int[] GenerateArray(int length, int max)
    {
        int[] ints= new int[length];
        Random rand = new Random();
        for(int i =0; i< length; i++)
        {            
            ints[i]= rand.Next(0, max);
        }
        WriteLine("Your Random Array:");
        Console.WriteLine(String.Join(' ', ints));
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