namespace SortManager.Sorters
{
    public class ShellSort : Sorter
    {
        public override string Name => "ShellSort";

        public override int[] Sort(int[] inputArray)
        {
            int n = inputArray.Length;
            for (int interval = n / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < n; i++)
                {
                    int temp = inputArray[i];
                    int j;
                    for (j = i; j >= interval && inputArray[j - interval] > temp; j -= interval)
                    {
                        inputArray[j] = inputArray[j - interval];
                    }
                    inputArray[j] = temp;
                }
            }
            return inputArray;
        }
    }
}
