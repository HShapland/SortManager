namespace SortManager.Sorters
{
    public class BubbleSort : Sorter
    {
        public override string Name => "BubbleSort";

        public override int[] Sort(int[] array)
        {
            int swaps = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1]) continue;
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
                swaps++;
            }
            if (swaps > 0) return Sort(array);
            return array;
        }
    }
}
