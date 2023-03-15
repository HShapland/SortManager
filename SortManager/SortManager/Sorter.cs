namespace SortManager
{
    public abstract class Sorter
    {
        public abstract string Name { get; }
        public abstract int[] Sort(int[] inputArray);
    }
}
