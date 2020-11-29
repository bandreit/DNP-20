using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using A1_DNP1Y.Models;
using A1_DNP1Y.Persistence;
using Microsoft.EntityFrameworkCore;
using Models;

namespace A1_DNP1Y.Data.Impl
{
    public class WebFamilyService : IWebFamilyService
    {
        private ViaDbContext _viaDbContext;

        public WebFamilyService(ViaDbContext viaDbContext)
        {
            _viaDbContext = viaDbContext;
        }

        public async Task SaveChanges()
        {
            await _viaDbContext.SaveChangesAsync();
        }

        public async Task<IList<Family>> GetFamiliesAsync()
        {
            return await _viaDbContext.Families
                .Include(family => family.Adults)
                .Include(family => family.Children)
                .ThenInclude(child => child.ChildInterests)
                .Include(family => family.Children)
                .ThenInclude(child => child.Pets)
                .Include(family => family.Pets).ToListAsync();
        }

        public async Task<Family> AddFamilyAsync(Family family)
        {
            await _viaDbContext.Families.AddAsync(family);
            await _viaDbContext.SaveChangesAsync();
            return family;
        }

        public async Task<Family> UpdateFamily(Family family)
        {
            List<ChildInterest> childInterests = new List<ChildInterest>();

            foreach (var child in family.Children)
            {
                foreach (var interest in child.ChildInterests)
                {
                    childInterests.Add(interest);
                }

                List<ChildInterest> dbChildInterests = _viaDbContext.ChildInterest.ToList().FindAll(interest =>interest.ChildId == child.Id);
                
                // ChildInterest toRemove =
                //     _viaDbContext.ChildInterest.Where(ci => ci.ChildId == child.Id);
                if (dbChildInterests != null)
                {
                    _viaDbContext.ChildInterest.RemoveRange(dbChildInterests);
                    await _viaDbContext.SaveChangesAsync();
                }
            }

            
            foreach (var child in family.Children)
            {
                child.ChildInterests = null;
            }
            
            _viaDbContext.Update(family);
            _viaDbContext.Entry(family).State = EntityState.Modified;
            await _viaDbContext.SaveChangesAsync();

            foreach (var childInterest in childInterests.Distinct())
            {
                await _viaDbContext.ChildInterest.AddAsync(childInterest);
                await _viaDbContext.SaveChangesAsync();
            }

            await _viaDbContext.SaveChangesAsync();
            return family;
        }

        public async Task<Family> RemoveFamily(string streetName, int houseNo)
        {
            Family toRemove = _viaDbContext.Families.First(family =>
                family.HouseNumber == houseNo && family.StreetName == streetName);
            _viaDbContext.Families.Remove(toRemove);
            await _viaDbContext.SaveChangesAsync();
            return toRemove;
        }

        public async Task<Family> GetFamilyAsync(int id)
        {
            Family familyToReturn = _viaDbContext.Families
                .Include(family => family.Adults)
                .Include(family => family.Children)
                .ThenInclude(child => child.ChildInterests)
                .Include(family => family.Children)
                .ThenInclude(child => child.Pets)
                .Include(family => family.Pets)
                .FirstOrDefault(f => f.Id == id);
            return familyToReturn;
        }
    }
}