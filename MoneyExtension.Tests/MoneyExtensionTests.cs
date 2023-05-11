namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal value = 279.98M;
        var cents = value.ToCents();
        Assert.AreEqual(27998, cents);

        value = 0M;
        cents = value.ToCents();
        Assert.AreEqual(0, cents);

        value = -1.0M;
        cents = value.ToCents();
        Assert.AreEqual(0, cents);

        value = -1M;
        cents = value.ToCents();
        Assert.AreEqual(0, cents);

        value = 0.01M;
        cents = value.ToCents();
        Assert.AreEqual(1, cents);

        value = 0.1M;
        cents = value.ToCents();
        Assert.AreEqual(10, cents);
    }
}