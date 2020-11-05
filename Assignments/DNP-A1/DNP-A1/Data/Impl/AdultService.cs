using System.Collections.Generic;
using System.Linq;
using A1_DNP1Y.Persistence;
using Models;

namespace A1_DNP1Y.Data.Impl
{
    public class AdultService : IAdultService
    {
        private FileContext _fileContext;
        private IList<Adult> _adults;

        public AdultService(FileContext fileContext)
        {
            _fileContext = fileContext;
            _adults = _fileContext.Adults;
        }

        public void SaveChanges()
        {
            _fileContext.SaveChanges();
        }
        public IList<Adult> GetAdults()
        {
            List<Adult> tmp = new List<Adult>(_adults);
            return tmp;
        }
        
        public void AddAdult(Adult adult)
        {
            int maxFamilyId = _adults.Max(adult => adult.Id);
            adult.Id = (++maxFamilyId);
            _adults.Add(adult);
            SaveChanges();
        }
    }
}