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
                default:
                    break;
            }
            return null;
        }
    }
}
