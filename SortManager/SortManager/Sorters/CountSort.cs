namespace SortManager.Sorters;

public class CountSort : Sorter
{
    public override string Name => "CountSort";

    public override int[] Sort(int[] array)
    {
        int[] numCounts = new int[Program.maximum];
        
        foreach (int i in array)
        {
            numCounts[i - 1]++;
        }
        
        int index = 0;

        for(int i = 0; i < numCounts.Length; i++)
        {
            while (numCounts[i] > 0)
            {
                array[index] = i+1;
                index++;
                numCounts[i]--;
            }
        }

        return array;
    }
}
