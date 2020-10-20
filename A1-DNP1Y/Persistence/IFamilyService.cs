using System.Collections.Generic;
using A1_DNP1Y.Models;
using Models;

namespace A1_DNP1Y.Persistence
{
    public interface IFamilyService
    {
        void SaveChanges();
        IList<Family> GetFamilies();
        IList<Adult> GetAdults();
        void AddFamily(Family family);
        void AddAdult(Adult adult);
        void UpdateFamily(Family family);
        void RemoveFamily(Family family);
    }
}