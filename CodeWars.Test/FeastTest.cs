namespace CodeWars.Test;
using NUnit.Framework;

[TestFixture]
public class TheFeastOfManyBeastsTests
{
    [Test]
    public void Feast_CorrectValues_ReturnsTrue()
    {
        Assert.IsTrue(TheFeastOfManyBeasts.Feast("donkey", "doughnut topped with cherry"));
    }
    [Test]
    public void Feast_WrongValues_ReturnsFalse()
    {
        Assert.IsFalse(TheFeastOfManyBeasts.Feast("monkey", "sourdough fiesta"));
    }
}