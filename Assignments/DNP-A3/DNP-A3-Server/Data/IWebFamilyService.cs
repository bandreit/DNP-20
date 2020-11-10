using System.Collections.Generic;
using System.Threading.Tasks;
using A1_DNP1Y.Models;

namespace A1_DNP1Y.Data.Impl
{
    public interface IWebFamilyService
    {
        void SaveChanges();
        Task<IList<Family>> GetFamiliesAsync();
        Task<Family> AddFamilyAsync(Family family);
        Task<Family> UpdateFamily(Family family);
        Task<Family> RemoveFamily(string streetName, int houseNo);
        Task<Family> GetFamilyAsync(int id);
    }
}