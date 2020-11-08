using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A1_DNP1Y.Models;
namespace A1_DNP1Y.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    City = "Horsens",
                    Domain = "via.dk",
                    Password = "123456",
                    Role = "Teacher",
                    BirthYear = 1986,
                    SecurityLevel = 4,
                    UserName = "Troels"
                },
                new User
                {
                    City = "Horsens",
                    Domain = "via.dk",
                    Password = "123456",
                    Role = "Admin",
                    BirthYear = 1986,
                    SecurityLevel = 5,
                    UserName = "Andrei"
                },
                new User
                {
                    City = "Aarhus",
                    Domain = "hotmail.com",
                    Password = "654321",
                    Role = "Student",
                    BirthYear = 1998,
                    SecurityLevel = 2,
                    UserName = "Jakob"
                }
            }.ToList();
        }

        public async Task<User> ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            return first;
        }
    }
}