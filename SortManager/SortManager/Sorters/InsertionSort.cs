namespace SortManager.Sorters
{
    public class InsertionSort : Sorter
    {
        public override string Name => "InsertionSort";

        public override int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                    else break;
                }
            }

            return array;
        }
    }
}
