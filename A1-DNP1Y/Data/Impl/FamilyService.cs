using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using A1_DNP1Y.Models;
using Models;
using Syncfusion.Blazor.Data;


namespace A1_DNP1Y.Persistence
{
    public class FamilyService : IFamilyService
    {
        private FileContext _fileContext;
        private IList<Family> _families;
        private IList<Adult> _adults;

        public FamilyService(FileContext fileContext)
        {
            _fileContext = fileContext;
            _families = _fileContext.Families;
            _adults = _fileContext.Adults;
        }

        public void SaveChanges()
        {
            _fileContext.SaveChanges();
        }

        public IList<Family> GetFamilies()
        {
            List<Family> tmp = new List<Family>(_families);
            return tmp;
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
        
        public void RemoveFamily(int? familyId)
        {
            Family toRemove = _families.First(t => t.Id == familyId);
            _families.Remove(toRemove);
            SaveChanges();
        }

        public void UpdateFamily(Family family)
        {
            // Family toUpdate = Families.First(t => t.Id == family.Id);
            //TODO: CREATE UPDATE
            // toUpdate. = todo.IsCompleted;
            // SaveChanges();
        }
    }
}