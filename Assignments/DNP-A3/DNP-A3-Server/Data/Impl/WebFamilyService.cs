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
            _families = fileContext.Families;
        }

        public void SaveChanges()
        {
            _fileContext.SaveChanges();
        }

        public async Task<IList<Family>> GetFamiliesAsync()
        {
            List<Family> tmp = new List<Family>(_families);
            return tmp;
        }

        public async Task<Family> AddFamilyAsync(Family family)
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
            return family;
        }

        public async Task<Family> UpdateFamily(Family family)
        {
             Family toUpdate = _families.First(f => f.Id == family.Id);
             toUpdate.Adults = family.Adults;
             toUpdate.Children = family.Children;
             toUpdate.Pets = family.Pets;
             toUpdate.HouseNumber = family.HouseNumber;
             toUpdate.StreetName = family.StreetName;
             SaveChanges();
             return toUpdate;
        }

        public async Task<Family> RemoveFamily(string streetName, int houseNo)
        {
            Family toRemove = _families.First(family =>
                family.HouseNumber == houseNo && family.StreetName == streetName);
            _families.Remove(toRemove);
            SaveChanges();
            return toRemove;
        }

        public async Task<Family> GetFamilyAsync(int id)
        {
            Family family = _families.First(family => family.Id == id);
            return family;
        }
    }
}