using SortManager;
using SortManager.Sorters;
namespace SortManagerTests
{
    internal class BubbleSortTests
    {
        [TestCase(new int[] {3, 2, 1}, new int[] {1, 2, 3})]
        public void ReturnsExpectedArray(int[] input, int[] expected)
        {
            BubbleSort sorter = new();
            Assert.That(sorter.Sort(input), Is.EqualTo(expected));
        }
    }
}
