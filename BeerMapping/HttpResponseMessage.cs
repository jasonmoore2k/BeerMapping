using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BeerMapping
{
    public class HttpResponseMessage<T> : HttpResponseMessage
    {
        public new T Content { get; set; }

        public HttpResponseMessage(HttpResponseMessage httpResponseMessage, T content)
        {
            Content = content;
            ReasonPhrase = httpResponseMessage.ReasonPhrase;
            RequestMessage = httpResponseMessage.RequestMessage;
            StatusCode = httpResponseMessage.StatusCode;
            Version = httpResponseMessage.Version;
        }
    }

    public static class HttpResponseMessageExtensions
    {
        public static async Task<HttpResponseMessage<T>> DeserializeContent<T>(this HttpResponseMessage httpResponseMessage)
        {
            var message = await httpResponseMessage.Content.ReadAsStringAsync();

            byte[] bytes = Encoding.UTF8.GetBytes(message);
            var serializer = new DataContractSerializer(typeof(T));

            T content;
            using (var reader = XmlDictionaryReader.CreateTextReader(bytes, XmlDictionaryReaderQuotas.Max))
            {
                content = (T)serializer.ReadObject(reader);
            }

            return new HttpResponseMessage<T>(httpResponseMessage, content);
        }
    }
}