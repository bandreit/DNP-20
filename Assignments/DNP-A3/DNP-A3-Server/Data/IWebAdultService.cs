﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace A1_DNP1Y.Data
{
    public interface IWebAdultService
    {
        void SaveChanges();
        Task<IList<Adult>> GetAdultsAsync();
        Task<Adult> AddAdultAsync(Adult adult);
    }
}