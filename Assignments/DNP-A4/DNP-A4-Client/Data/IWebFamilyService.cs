using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using A1_DNP1Y.Models;

namespace A1_DNP1Y.Data.Impl
{
    public interface IWebFamilyService
    {
        Task<IList<Family>> GetFamiliesAsync();
        Task<Family> GetFamilyAsync(int id);
        Task<HttpStatusCode> AddFamily(Family family);
        Task<Family> RemoveFamily(string streetName, int streetNo);
        Task EditFamily(Family newFamily);
    }
}