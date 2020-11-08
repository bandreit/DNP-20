﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace A1_DNP1Y.Data
{
    public interface IWebAdultService
    {
        Task<IList<Adult>> GetAdults();
        void AddAdult(Adult adult);
    }
}