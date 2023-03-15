namespace SortManager.Sorters
{
    public class BubbleSort : Sorter
    {
        public override string Name => "BubbleSort";

        public override int[] Sort(int[] array)
        {
            int temp = array[0];

            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }

            return array;
        }
    }
}
