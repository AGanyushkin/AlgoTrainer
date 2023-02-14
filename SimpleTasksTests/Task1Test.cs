using tasks;

namespace tasks_tests;

public class Task1Test
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void WithEmptyList()
    {
        Assert.That(
            new Task1().toDo(new int[] { }),
            Is.EqualTo(new int[] { })
        );
    }

    [Test, TestCaseSource(nameof(GetDataForTest1))]
    public void TestWithData(int[] input, int[] output)
    {
        var result = new Task1().toDo((int[])input.Clone());
        Assert.That(
            result,
            Is.EqualTo(output),
            $"actual {string.Join(",", result)}" +
            $" != expected {string.Join(",", output)}"
        );
    }

    private static IEnumerable<TestCaseData> GetDataForTest1()
    {
        yield return new TestCaseData(new[] { 1, 3, 5, 6 }, new[] { 1, 3, 5, 6 })
        {
            TestName = "1, 3, 5, 6"
        };
        yield return new TestCaseData(new[] { 0 }, new[] { 0 })
        {
            TestName = "0"
        };
        yield return new TestCaseData(new[] { 2, 3, 3, 0, 0, 0, 0 }, new[] { 2, 3, 3, 0, 0, 0, 0 })
        {
            TestName = "2, 3, 3, 0, 0, 0, 0"
        };
        yield return new TestCaseData(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })
        {
            TestName = "0, 0, 0"
        };
        yield return new TestCaseData(new[] { 0, 2, 3, 0, 3, 0, 1 }, new[] { 2, 3, 3, 1, 0, 0, 0 })
        {
            TestName = "0, 2, 3, 0, 3, 0, 1"
        };
        yield return new TestCaseData(new[] { 0, 0, 0, 2, 3, 3, 1 }, new[] { 2, 3, 3, 1, 0, 0, 0 })
        {
            TestName = "0, 0, 0, 2, 3, 3, 1"
        };
    }
}
