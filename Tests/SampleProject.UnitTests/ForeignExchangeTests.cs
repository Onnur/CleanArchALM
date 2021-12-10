using NSubstitute;
using NUnit.Framework;
using SampleProject.Infrastructure.Caching;
using SampleProject.Infrastructure.Domain.ForeignExchanges;
using SampleProject.UnitTests.SeedWork;

namespace SampleProject.UnitTests
{
    [TestFixture]
    public class ForeignExchangeTests : TestBase
    {
        [Test]
        public void GetConversionRates_WhenCacheNotAvailable_ShouldReturnTwoValues()
        {
            var cacheStore = Substitute.For<ICacheStore>();
            var foreignExchange = new ForeignExchange(cacheStore);
            var result = foreignExchange.GetConversionRates();

            Assert.That(result.Count == 2);
        }
    }
}