using System;
using System.Collections.Generic;
using System.Linq;
using ToDoWAuth.Model;

namespace ToDoWAuth.Data.Impl
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
                    Id = 1,
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
                    City = "Aarhus",
                    Domain = "hotmail.com",
                    Password = "654321",
                    Role = "PrivateToDoer",
                    BirthYear = 1998,
                    SecurityLevel = 2,
                    UserName = "Jakob"
                },
                new User
                {
                    City = "Aarhus",
                    Domain = "whatever.com",
                    Password = "654321",
                    Role = "Student",
                    BirthYear = 2000,
                    SecurityLevel = 1,
                    UserName = "Biakob"
                },
                new User
                {
                    City = "Horsens",
                    Domain = "whatever.com",
                    Password = "123456",
                    Role = "PrivateToDoer",
                    BirthYear = 2000,
                    SecurityLevel = 0,
                    UserName = "Andrei"
                },
                new User
                {
                    City = "Horsens",
                    Domain = "whatever.com",
                    Password = "123456",
                    Role = "PrivateUser",
                    BirthYear = 2000,
                    SecurityLevel = 0,
                    UserName = "PrivateUser"
                },
                new User
                {
                    City = "Horsens",
                    Domain = "whatever.com",
                    Password = "123456",
                    Role = "Admin",
                    BirthYear = 2000,
                    SecurityLevel = 0,
                    UserName = "Admin"
                },
                new User
                {
                    City = "Horsens",
                    Domain = "whatever.com",
                    Password = "123456",
                    Role = "Dumbie",
                    BirthYear = 2000,
                    SecurityLevel = 0,
                    UserName = "AdminDumbie"
                }
            }.ToList();
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}