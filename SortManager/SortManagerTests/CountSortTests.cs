using SortManager.Sorters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerTests
{
    internal class CountSortTests
    {
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        public void ReturnsExpectedArray(int[] input, int[] expected)
        {
            CountSort sorter = new();
            Assert.That(sorter.Sort(input), Is.EqualTo(expected));
        }
    }
}
