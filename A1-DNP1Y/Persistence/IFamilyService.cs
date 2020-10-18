using System.Collections.Generic;
using Models;

namespace A1_DNP1Y.Persistence
{
    public interface IFamilyService
    {
        void SaveChanges();
        IList<Family> GetFamilies();
        void AddFamily(Family family);
        void UpdateFamily(Family family);
        void RemoveFamily(Family family);
    }
}