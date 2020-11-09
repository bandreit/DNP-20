using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using A1_DNP1Y.Models;
using Models;

namespace A1_DNP1Y.Data.Impl
{
    public class WebFamilyService : IWebFamilyService
    {
        public async Task<IList<Family>> GetFamiliesAsync()
        {
            HttpClient httpClient = new HttpClient();
            string requestURI = "https://localhost:5003/families";
            string message = await httpClient.GetStringAsync(requestURI);
            List<Family> result = JsonSerializer.Deserialize<List<Family>>(message);
            return result;
        }
        
        public async Task<Family> GetFamilyAsync(int id)
        {
            HttpClient httpClient = new HttpClient();
            string requestURI = $"https://localhost:5003/families/{id}";
            string message = await httpClient.GetStringAsync(requestURI);
            Family result = JsonSerializer.Deserialize<Family>(message);
            return result;
        }

        public async Task<HttpStatusCode> AddFamily(Family family)
        {
            HttpClient client = new HttpClient();

            string familySerialized = JsonSerializer.Serialize(family);

            StringContent content = new StringContent(
                familySerialized,
                Encoding.UTF8,
                MediaTypeNames.Application.Json
            );

            HttpResponseMessage responseMessage = await client.PostAsync("https://localhost:5003/families", content);

            return responseMessage.StatusCode;
        }

        public async Task<Family> RemoveFamily(string streetName, int streetNo)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage responseMessage =
                await client.DeleteAsync(
                    $"https://localhost:5003/families?streetname={streetName}&housenumber={streetNo}");

            String reply = await responseMessage.Content.ReadAsStringAsync();

            Family familyDeserialized = JsonSerializer.Deserialize<Family>(reply);

            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                return familyDeserialized;
            }

            return null;
        }

        public async Task EditFamily(Family newFamily)
        {
            HttpClient client = new HttpClient();

            string familySerialized = JsonSerializer.Serialize(newFamily);

            StringContent content = new StringContent(
                familySerialized,
                Encoding.UTF8,
                MediaTypeNames.Application.Json
            );

            HttpResponseMessage responseMessage = await client.PatchAsync("https://localhost:5003/families", content);
        }
    }
}