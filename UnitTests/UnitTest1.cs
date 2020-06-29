using CodeConverage;
using NUnit.Framework;

namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var forecast = new WeatherForecast();
            Assert.IsTrue(forecast.IsRainyTomorrow());
        }
    }
}