using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BeerMapping
{
    public class RestApiBase
    {
        private readonly string _baseAddress;

        public RestApiBase(string baseUrl)
        {
            _baseAddress = baseUrl;
        }

        protected async Task<HttpResponseMessage<T>> GetAsync<T>(string path) where T : new()
        {
            using (var client = CreateClient())
            {
                return await (await client.GetAsync(path)).DeserializeContent<T>();
            }
        }

        protected async Task<HttpResponseMessage> GetAsync(string path)
        {
            using (var client = CreateClient())
            {
                return await client.GetAsync(path);
            }
        }

        protected async Task<HttpResponseMessage<TOutput>> PutAsync<TOutput, TInput>(TInput obj, string path) where TOutput : new()
        {
            using (var client = CreateClient())
            {
                HttpContent content = CreateContent(obj);
                return await (await client.PutAsync(path, content)).DeserializeContent<TOutput>();
            }
        }

        protected async Task<HttpResponseMessage<TOutput>> PostAsync<TOutput, TInput>(TInput obj, string path) where TOutput : new()
        {
            using (var client = CreateClient())
            {
                HttpContent content = CreateContent(obj);
                return await (await client.PostAsync(path, content)).DeserializeContent<TOutput>();
            }
        }

        protected async Task<HttpResponseMessage> DeleteRequest(string path, params string[] args)
        {
            using (var client = CreateClient())
            {
                return await client.DeleteAsync(path);
            }
        }

        private HttpClient CreateClient()
        {
            return new HttpClient { BaseAddress = new Uri(_baseAddress) };
        }

        private HttpContent CreateContent<T>(T content)
        {
            return new StringContent(JsonConvert.SerializeObject(content));
        }
    }
}