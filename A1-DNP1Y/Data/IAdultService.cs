using System.Collections.Generic;
using Models;

namespace A1_DNP1Y.Data
{
    public interface IAdultService
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
    }
}