namespace SortManager.Sorters
{
    public class CombSort : Sorter
    {
        public override string Name => "CombSort";

        public override int[] Sort(int[] array)
        {
            int gap = array.Length;
            bool sorted = false;

            while (!sorted)
            {
                gap = (int)(gap / 1.3);
                if (gap <= 1)
                {
                    sorted = true;
                }

                for (int i = 0; i + gap < array.Length; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                        sorted = false;
                    }
                }
            }

            return array;
        }
    }
}
