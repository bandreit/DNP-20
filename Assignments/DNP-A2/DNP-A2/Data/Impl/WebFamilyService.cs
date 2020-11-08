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
        private IList<Family> _families;

        public async Task<IList<Family>> GetFamiliesAsync()
        {
            HttpClient httpClient = new HttpClient();
            string requestURI = "http://dnp.metamate.me/Families";
            string message = await httpClient.GetStringAsync(requestURI);
            List<Family> result = JsonSerializer.Deserialize<List<Family>>(message);
            _families = result;
            return result;
        }

        public async Task<HttpStatusCode> AddFamily(Family family)
        {
            _families = await GetFamiliesAsync();
            int? maxFamilyId = _families.Max(family => family.Id);
            family.Id = (++maxFamilyId);

            List<Adult> adults = new List<Adult>();
            foreach (var fam in _families)
            {
                adults.AddRange(fam.Adults);
            }

            int maxAdultId = adults.Max(adult => adult.Id);
            foreach (var adult in family.Adults)
            {
                adult.Id = (++maxAdultId);
            }

            List<Child> children = new List<Child>();
            foreach (var fam in _families)
            {
                children.AddRange(fam.Children);
            }

            int maxChildId = 0;
            if (children.Count != 0)
            {
                maxChildId = children.Max(child => child.Id);
            }

            foreach (var child in family.Children)
            {
                child.Id = (++maxChildId);
            }

            List<Pet> pets = new List<Pet>();
            foreach (var fam in _families)
            {
                if (!(fam.Pets is null))
                {
                    pets.AddRange(fam.Pets);
                }
            }

            foreach (var fam in _families)
            {
                foreach (var child in fam.Children)
                {
                    if (!(child.Pets is null))
                    {
                        pets.AddRange(fam.Pets);
                    }
                }
            }

            int maxPetId = 0;
            if (pets.Count != 0)
            {
                maxPetId = pets.Max(pet => pet.Id);
            }

            foreach (var pet in family.Pets)
            {
                pet.Id = (++maxPetId);
            }

            HttpClient client = new HttpClient();

            string familySerialized = JsonSerializer.Serialize(family);

            StringContent content = new StringContent(
                familySerialized,
                Encoding.UTF8,
                MediaTypeNames.Application.Json
            );

            HttpResponseMessage responseMessage = await client.PutAsync("http://dnp.metamate.me/Families", content);

            return responseMessage.StatusCode;
        }

        public async Task<Family> RemoveFamily(string streetName, int streetNo)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage responseMessage =
                await client.DeleteAsync(
                    $"http://dnp.metamate.me/Families?streetname={streetName}&housenumber={streetNo}");

            String reply = await responseMessage.Content.ReadAsStringAsync();
            
            Family familyDeserialized = JsonSerializer.Deserialize<Family>(reply);

            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                return familyDeserialized;
            }

            return null;
        }
    }
}