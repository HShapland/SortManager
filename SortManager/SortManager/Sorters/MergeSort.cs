namespace SortManager.Sorters
{
    public class MergeSort : Sorter
    {
        public override string Name => "MergeSort";

        public override int[] Sort(int[] array)
        {
            if (array.Length == 1) return array;

            int[] arrayOne = array.ToList().GetRange(0, array.Length / 2).ToArray();
            int[] arrayTwo = array[(array.Length / 2)..];

            arrayOne = Sort(arrayOne);
            arrayTwo = Sort(arrayTwo);

            return MergeArrays(arrayOne, arrayTwo);
        }

        public static int[] MergeArrays(int[]? arrayOne, int[]? arrayTwo)
        {
            if (arrayOne == null || arrayTwo == null) throw new ArgumentException();
            List<int> mergedArray = new List<int>();
            int i = 0;
            int j = 0;

            while (i < arrayOne.Length && j < arrayTwo.Length)
            {
                if (arrayOne[i] < arrayTwo[j])
                {
                    mergedArray.Add(arrayOne[i]);
                    i++;
                }
                else
                {
                    mergedArray.Add(arrayTwo[j]);
                    j++;
                }
            }

            if (i < arrayOne.Length)
            {
                for (int k = i; k < arrayOne.Length; k++) mergedArray.Add(arrayOne[k]);
            }
            else
            {
                for (int k = j; k < arrayTwo.Length; k++) mergedArray.Add(arrayTwo[k]);
            }

            return mergedArray.ToArray();
        }
    }
}
