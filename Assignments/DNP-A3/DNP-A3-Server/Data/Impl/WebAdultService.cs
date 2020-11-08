﻿using System.Collections.Generic;
using System.Net.Http;
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

        public void AddAdult(Adult adult)
        {
            throw new System.NotImplementedException();
        }
    }
}