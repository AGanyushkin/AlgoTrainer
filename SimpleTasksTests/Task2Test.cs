using tasks;

namespace tasks_tests;

public class Task2Test
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void WithEmptyString()
    {
        Assert.That(
            new Task2().toDo(""),
            Is.EqualTo("")
        );
    }

    [Test]
    public void WithSingleCharacter()
    {
        Assert.That(
            new Task2().toDo("g"),
            Is.EqualTo("g1")
        );
    }

    [Test, TestCaseSource(nameof(GetDataForTest2))]
    public void TestWithData(string[] data)
    {
        var result = new Task2().toDo(data[0]);
        Assert.That(
            result,
            Is.EqualTo(data[1]),
            $"actual {result} != expected {data[1]}"
        );
    }

    private static string[][] GetDataForTest2()
    {
        return new[]
        {
            new[]
            {
                "eeeee",
                "e5"
            },
            new[]
            {
                "abbbhhhhpjj",
                "a1b3h4p1j2"
            },
        };
    }
}
