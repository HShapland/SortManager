using SortManager;
using SortManager.Sorters;
namespace SortManagerTests;

public class QuickSortTests
{
    [TestCase(new int[] { 3, 7, 8, 23, 1 }, new int[] { 1, 3, 7, 8, 23 })]
    [TestCase(new int[] { 5, -1, -5, 0, 1 }, new int[] { -5, -1, 0, 1, 5 })]
    [TestCase(new int[] { 1, 3, 5, 7, 100 }, new int[] { 1, 3, 5, 7, 100 })]
    public void GivenArray_QuickSort_ReturnsSortedArray(int[] array, int[] exp)
    {
        BubbleSort bubbleSorter = new BubbleSort();
        int[] result = bubbleSorter.Sort(array);
        Assert.That(result, Is.EqualTo(exp));
    }
}
