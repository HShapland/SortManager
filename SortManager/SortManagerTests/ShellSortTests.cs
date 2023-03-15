using SortManager.Sorters;

namespace SortManagerTests
{
    internal class ShellSortTests
    {
        [TestCase(new int[] {3, 2, 1}, new int[] {1, 2, 3})]
        [TestCase(new int[] {9, 8, 3, 7, 5, 6, 4, 1}, new int[] {1, 3, 4, 5, 6, 7, 8, 9})]
        public void GivenArray_ShellSort_ReturnsSortedArray(int[] input, int[] expected)
        {
            ShellSort sorter = new();
            Assert.That(sorter.Sort(input), Is.EqualTo(expected));
        }
    }
}
