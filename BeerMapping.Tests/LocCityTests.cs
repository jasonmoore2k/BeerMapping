using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Threading.Tasks;

namespace BeerMapping.Tests
{
    [TestClass]
    public class LocCityTests
    {
        [TestMethod]
        public async Task Test1()
        {
            var service = new BeerMappingService(AppSettings.ApiKey);

            var result = await service.LocCityAsync("lyons,co");
            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
        }
    }
}