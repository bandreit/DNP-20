using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using A1_DNP1Y.Models;
namespace A1_DNP1Y.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        public async Task<User> ValidateUser(string userName, string password)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage responseMessage =
                await client.GetAsync(
                    $"https://localhost:5003/authenticate?username={userName}&password={password}");

            String reply = await responseMessage.Content.ReadAsStringAsync();

            
     
            if (responseMessage.StatusCode == HttpStatusCode.NotFound)
            {
                throw new Exception("User not found");
            }

            if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new Exception("Incorrect password");
            }

            User first = JsonSerializer.Deserialize<User>(reply);
            return first;
        }
    }
}