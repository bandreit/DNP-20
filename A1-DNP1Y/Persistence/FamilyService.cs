using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Models;


namespace A1_DNP1Y.Persistence
{
    public class FamilyService : IFamilyService
    {
        private FileContext _fileContext;
        private IList<Family> _families;
        
        public FamilyService(FileContext fileContext)
        {
            _fileContext = fileContext;
            _families = _fileContext.Families;
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
            // int? max = Families.Max(family => family.Id);
            // family.Id = (++max);
            // Families.Add(family);
            _families.Add(family);
            SaveChanges();
        }

        public void RemoveFamily(Family family)
        {
            // Family toRemove = Families.First(t => t.Id == family.Id);
            // Families.Remove(toRemove);
            // SaveChanges();
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