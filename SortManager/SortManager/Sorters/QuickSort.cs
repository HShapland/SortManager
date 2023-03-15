

namespace SortManager.Sorters
{
    public class QuickSort : Sorter
    {
        public override string Name => "QuickSort";

        public override int[] Sort(int[] inputArray)
        {
            int[] result = QuickSortMethod(inputArray);
            return result;
        }

        public static int[] QuickSortMethod(int[] inputArray, int left = 0, int right = 0)
        {
            if (right == 0) right = inputArray.Length - 1;
            int leftPointer = left;
            int rightPointer = right;

            int pivot = inputArray[leftPointer];

            while (leftPointer <= rightPointer)
            {
                while (inputArray[leftPointer] < pivot)
                {
                    leftPointer++;
                }

                while (inputArray[rightPointer] > pivot)
                {
                    rightPointer--;
                }

                if (leftPointer <= rightPointer)
                {
                    (inputArray[leftPointer], inputArray[rightPointer]) = (inputArray[rightPointer], inputArray[leftPointer]);
                    leftPointer++;
                    rightPointer--;
                }

            }

            if (left < rightPointer)
            {
                QuickSortMethod(inputArray, left, rightPointer);
            }
            if (leftPointer < right)
            {
                QuickSortMethod(inputArray, leftPointer, right);
            }

            return inputArray;
        }
    }
}
