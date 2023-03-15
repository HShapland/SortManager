namespace SortManager.Sorters;

public class CountSort : Sorter
{
    public override string Name => "CountSort";

    public override int[] Sort(int[] array)
    {
        int[] numCounts = new int[500];

        foreach(int i in array)
        {
            numCounts[i - 1]++;
        }


    }
}
