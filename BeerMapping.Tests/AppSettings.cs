using System.Configuration;

namespace BeerMapping.Tests
{
    public class AppSettings
    {
        public static readonly string ApiKey = ConfigurationManager.AppSettings["ApiKey"];
    }
}