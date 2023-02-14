using tasks;

namespace tasks_tests;

public class Task3Test
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DifferentLength()
    {
        Assert.That(
            new Task3().toDo("qwe", "as"),
            Is.False
        );
    }

    [Test]
    public void WithSameString()
    {
        string example = "qweqwe";

        Assert.That(
            new Task3().toDo(example, example),
            Is.True
        );
    }

    [Test]
    public void PositiveExample()
    {
        Assert.That(new Task3().toDo("aab", "aba"), Is.True, "aab<->aba");
        Assert.That(new Task3().toDo("aaa", "aaa"), Is.True, "aaa<->aaa");
        Assert.That(new Task3().toDo("abc", "cab"), Is.True, "abc<->cab");
    }

    [Test]
    public void NegativeExample()
    {
        Assert.That(new Task3().toDo("aab", "abb"), Is.False, "aab<->abb");
        Assert.That(new Task3().toDo("aaa", "bbb"), Is.False, "aaa<->bbb");
        Assert.That(new Task3().toDo("abc", "cabb"), Is.False, "abc<->cabb");
    }
}
