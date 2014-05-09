using System.Threading.Tasks;

namespace BeerMapping
{
    public class BeerMappingService : RestApiBase
    {
        private const string ApiBaseUrl = "http://beermapping.com/webservice/";

        public string ApiKey { get; private set; }

        public BeerMappingService(string apiKey)
            : base(ApiBaseUrl)
        {
            ApiKey = apiKey;
        }

        private Task<HttpResponseMessage<T>> GetAsync<T>(string service, string query) where T : new()
        {
            string path = string.Join("/", service, ApiKey, query);
            return GetAsync<T>(path);
        }

        /// <summary>
        /// This service should be used to search for Locations by querying the location name. Partials will work.
        /// This function will return multiple locations depending on the search query given.
        ///
        /// This query can be made either with a location name or with a location id.
        /// The location name could possibly return more than one location, but location id's are all unique so they will only return one location or none if that id is not being used.
        /// </summary>
        public async Task<HttpResponseMessage<LocQueryResults>> LocQueryAsync(string query)
        {
            return await GetAsync<LocQueryResults>("locquery", query);
        }

        /// <summary>
        /// This service should be used to search for Locations when given a city. Partials will work.
        /// This function will return multiple locations depending on the search query given.
        /// </summary>
        public async Task<HttpResponseMessage<LocQueryResults>> LocCityAsync(string query)
        {
            return await GetAsync<LocQueryResults>("loccity", query);
        }

        /// <summary>
        /// This service should be used to search for Locations when given a city,state. Partials will work.
        /// This function will return multiple locations depending on the search query given.
        /// </summary>
        public async Task<HttpResponseMessage<LocQueryResults>> LocStateAsync(string query)
        {
            return await GetAsync<LocQueryResults>("locstate", query);
        }

        /// <summary>
        /// This service should be used to return score information based on the location id given.
        /// Location Id's are unique and should return only one location.
        /// </summary>
        public async Task<HttpResponseMessage<LocMapResults>> LocMapAsync(int id)
        {
            return await GetAsync<LocMapResults>("locmap", id.ToString());
        }

        public async Task<HttpResponseMessage<LocScoreResults>> LocScoreAsync(int id)
        {
            return await GetAsync<LocScoreResults>("locscore", id.ToString());
        }

        public async Task<HttpResponseMessage<LocImageResults>> LocImageAsync(int id)
        {
            return await GetAsync<LocImageResults>("locimage", id.ToString());
        }
    }
}