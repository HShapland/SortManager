using SortManager.Sorters;

namespace SortManagerTests;

public class CombSortTests
{
    [TestCase(new int[] { 3, 7, 8, 23, 1 }, new int[] { 1, 3, 7, 8, 23 })]
    [TestCase(new int[] { 5, -1, -5, 0, 1 }, new int[] { -5, -1, 0, 1, 5 })]
    [TestCase(new int[] { 1, 3, 5, 7, 100 }, new int[] { 1, 3, 5, 7, 100 })]
    public void GivenArray_CombSort_ReturnsSortedArray(int[] array, int[] exp)
    {
        CombSort combSorter = new CombSort();
        int[] result = combSorter.Sort(array);
        Assert.That(result, Is.EqualTo(exp));
    }
}
