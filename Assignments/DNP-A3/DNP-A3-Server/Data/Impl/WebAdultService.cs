using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using A1_DNP1Y.Persistence;
using Models;

namespace A1_DNP1Y.Data.Impl
{
    public class WebAdultService : IWebAdultService
    {
        private FileContext _fileContext;
        private IList<Adult> _adults;

        public WebAdultService(FileContext fileContext)
        {
            _fileContext = fileContext;
            _adults = fileContext.Adults;
        }

        public void SaveChanges()
        {
            _fileContext.SaveChanges();
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            List<Adult> tmp = new List<Adult>(_adults);
            return tmp;
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            int maxFamilyId = _adults.Max(adult => adult.Id);
            adult.Id = (++maxFamilyId);
            _adults.Add(adult);
            SaveChanges();
            return adult;
        }
    }
}