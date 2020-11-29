using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A1_DNP1Y.Models;
using A1_DNP1Y.Persistence;

namespace A1_DNP1Y.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private ViaDbContext _viaDbContext;

        public InMemoryUserService(ViaDbContext viaDbContext)
        {
            _viaDbContext = viaDbContext;
        }

        public async Task<User> ValidateUser(string userName, string password)
        {
            User first = _viaDbContext.Users.FirstOrDefault(user => user.UserName.Equals(userName));
            return first;
        }
    }
}