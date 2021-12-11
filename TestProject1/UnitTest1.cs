using NUnit.Framework;
using WebApplication1;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestTaxPrice()
    {
        Assert.AreEqual((decimal)120, TaxPrice(1000));
    }
}