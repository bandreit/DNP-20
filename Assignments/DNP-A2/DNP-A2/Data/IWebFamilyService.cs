using System.Collections.Generic;
using System.Threading.Tasks;
using A1_DNP1Y.Models;

namespace A1_DNP1Y.Data.Impl
{
    public interface IWebFamilyService
    {
        void SaveChanges();
        Task<IList<Family>> GetFamiliesAsync();
        void AddFamily(Family family);
        void UpdateFamily(Family family);
        void RemoveFamily(int? familyId);
    }
}