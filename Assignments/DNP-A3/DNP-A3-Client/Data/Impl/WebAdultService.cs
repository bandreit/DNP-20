using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace A1_DNP1Y.Data.Impl
{
    public class WebAdultService : IWebAdultService
    {
        public async Task<IList<Adult>> GetAdults()
        {
            HttpClient httpClient = new HttpClient();
            string requestURI = "http://dnp.metamate.me/adults";
            string message = await httpClient.GetStringAsync(requestURI);
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task<HttpStatusCode> AddAdult(Adult adult)
        {
            HttpClient client = new HttpClient();

            string familySerialized = JsonSerializer.Serialize(adult);

            StringContent content = new StringContent(
                familySerialized,
                Encoding.UTF8,
                MediaTypeNames.Application.Json
            );

            HttpResponseMessage responseMessage = await client.PutAsync("http://dnp.metamate.me/Adults", content);

            return responseMessage.StatusCode;
        }
    }
}