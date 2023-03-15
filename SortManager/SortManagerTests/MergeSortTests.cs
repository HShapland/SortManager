using SortManager.Sorters;
namespace SortManagerTests;

public class MergeSortTests
{
    [TestCase(new int[] { 3, 7, 8, 23, 1 }, new int[] { 1, 3, 7, 8, 23 })]
    [TestCase(new int[] { 5, -1, -5, 0, 1 }, new int[] { -5, -1, 0, 1, 5 })]
    [TestCase(new int[] { 1, 3, 5, 7, 100 }, new int[] { 1, 3, 5, 7, 100 })]
    public void GivenArray_MergeSort_ReturnsSortedArray(int[] array, int[] exp)
    {
        MergeSort mergeSorter = new MergeSort();
        int[] result = mergeSorter.Sort(array);
        Assert.That(result, Is.EqualTo(exp));
    }
}
