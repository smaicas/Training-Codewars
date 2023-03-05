namespace NextBiggerNumberWithTheSameDigits.Test;
[TestFixture]
public class NextBiggerNumberTests
{
    [Test]
    public void SmallNumbers()
    {
        Res res = new();

        Assert.AreEqual(21, Res.CalculateNumber(12));
        Assert.AreEqual(531, Res.CalculateNumber(513));
        Assert.AreEqual(2071, Res.CalculateNumber(2017));
        Assert.AreEqual(441, Res.CalculateNumber(414));
        Assert.AreEqual(414, Res.CalculateNumber(144));
        Assert.AreEqual(1234567908, Res.CalculateNumber(1234567890));
        Assert.AreEqual(364036935, Res.CalculateNumber(364036593));
    }
}