using NUnit.Framework;

[TestFixture]
public class MathServiceTests
{
    private MathService service;

    [SetUp]
    public void Setup()
    {
        service = new MathService();
    }

    [Test]
    public void Test_N_Am()
    {
        int n = -5;

        int kqtt = service.TongSoLe(n);

        int kqmm = 0;

        Assert.AreEqual(kqmm, kqtt);
    }

    [Test]
    public void Test_N_Bang1()
    {
        int n = 1;

        int kqtt = service.TongSoLe(n);

        int kqmm = 1;

        Assert.AreEqual(kqmm, kqtt);
    }

    [Test]
    public void Test_N_Bang5()
    {
        int n = 5;

        int kqtt = service.TongSoLe(n);

        int kqmm = 9;

        Assert.AreEqual(kqmm, kqtt);
    }

    [Test]
    public void Test_N_Bang6()
    {
        int n = 6;

        int kqtt = service.TongSoLe(n);

        int kqmm = 9;

        Assert.AreEqual(kqmm, kqtt);
    }

    [Test]
    public void Test_N_Bang10()
    {
        int n = 10;

        int kqtt = service.TongSoLe(n);

        int kqmm = 25;

        Assert.AreEqual(kqmm, kqtt);
    }
}