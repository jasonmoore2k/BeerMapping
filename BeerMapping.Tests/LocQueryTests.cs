using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Threading.Tasks;

namespace BeerMapping.Tests
{
    [TestClass]
    public class LocQueryTests
    {
        [TestMethod]
        public async Task Test1()
        {
            var service = new BeerMappingService(AppSettings.ApiKey);

            var result = await service.LocQueryAsync("piece");
            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
        }
    }
}