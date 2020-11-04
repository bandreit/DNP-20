using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using A1_DNP1Y.Models;
using A1_DNP1Y.Persistence;
using Models;

namespace A1_DNP1Y.Data.Impl
{
    public class WebFamilyService : IWebFamilyService
    {
        private FileContext _fileContext;
        private IList<Family> _families;

        public WebFamilyService(FileContext fileContext)
        {
            _fileContext = fileContext;
        }

        public void SaveChanges()
        {
            _fileContext.SaveChanges();
        }

        public async Task<IList<Family>> GetFamiliesAsync()
        {
            HttpClient httpClient = new HttpClient();
            string requestURI = "http://dnp.metamate.me/families";
            string message = await httpClient.GetStringAsync(requestURI);
            List<Family> result = JsonSerializer.Deserialize<List<Family>>(message);
            return result;
        }

        public void AddFamily(Family family)
        {
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


            _families.Add(family);
            SaveChanges();
        }

        public void UpdateFamily(Family family)
        {
            // Family toUpdate = Families.First(t => t.Id == family.Id);
            //TODO: CREATE UPDATE
            // toUpdate. = todo.IsCompleted;
            // SaveChanges();
        }

        public void RemoveFamily(int? familyId)
        {
            Family toRemove = _families.First(t => t.Id == familyId);
            _families.Remove(toRemove);
            SaveChanges();
        }
    }
}