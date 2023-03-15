using SortManager.Sorters;
namespace SortManager
{
    public class Factory
    {
        public Sorter CreateSorter(string identifier)
        {
            switch (identifier.ToLower())
            {
                case "bubblesort":
                    return new BubbleSort();
                case "mergesort":
                    return new MergeSort();
<<<<<<< Updated upstream
=======
                case "inserstionsort":
                    return new InsertionSort();
                case "combsort":
                    return new CombSort();
                case "shellsort":
                    return new ShellSort();
                case "countsort":
                    return new CountSort();
                case "quicksort":
                    return new QuickSort();
>>>>>>> Stashed changes
                default:
                    break;
            }
            return null;
        }
    }
}
