using SortManager;
namespace SortManagerTests;

public class ProgramTests
{
    [TestCase("BubbleSort", true)]
    [TestCase("mergeSort", true)]
    [TestCase("foo", false)]
    public void GivenString_CheckChoice_ReturnsCorrectBoolean(string input, bool exp)
    {
        Assert.That(Program.CheckChoice(input), Is.EqualTo(exp));
    }

    [TestCase(3)]
    [TestCase(6)]
    [TestCase(10)]
    public void GivenLength_GenerateArray_ReturnsArrayOfSpecifiedLength(int input)
    {
        Assert.That(Program.GenerateArray(input, 10), Has.Length.EqualTo(input));
    }
}
