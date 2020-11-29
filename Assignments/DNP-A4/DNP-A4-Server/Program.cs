using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using A1_DNP1Y.Models;
using A1_DNP1Y.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models;

namespace DNP_A4_Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ViaDbContext viaDbContext = new ViaDbContext())
            {
                if (!viaDbContext.Families.Any())
                {
                    Seed(viaDbContext);
                }
            }

            CreateHostBuilder(args).Build().Run();
        }

        private static void Seed(ViaDbContext viaDbContext)
        {
            IList<Family> families = new List<Family>();
            List<Interest> interests = new List<Interest>()
            {
                new Interest() {Type = "Soccer"},
                new Interest() {Type = "Drawing"},
                new Interest() {Type = "Kite Flying"},
                new Interest() {Type = "Roller Blades"},
                new Interest() {Type = "Board Games"},
                new Interest() {Type = "Ballet"},
                new Interest() {Type = "Hockey"},
                new Interest() {Type = "Gaming"},
                new Interest() {Type = "Lego"},
                new Interest() {Type = "Scout"},
                new Interest() {Type = "Gymnastics"},
                new Interest() {Type = "Harry Potter"},
                new Interest() {Type = "Frozen"}
            };
            List<User> users = new List<User>()
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
            };

            using (var jsonReader = File.OpenText("families.json"))
            {
                families = JsonSerializer.Deserialize<List<Family>>(jsonReader.ReadToEnd());
            }

            foreach (var family in families)
            {
                viaDbContext.Families.Add(family);
                viaDbContext.Entry(family).State = EntityState.Added;
            }

            foreach (var interest in interests)
            {
                viaDbContext.Interest.Add(interest);
                viaDbContext.Entry(interest).State = EntityState.Added;
            }
            
            foreach (var user in users)
            {
                viaDbContext.Users.Add(user);
                viaDbContext.Entry(user).State = EntityState.Added;
            }

            viaDbContext.SaveChanges();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}