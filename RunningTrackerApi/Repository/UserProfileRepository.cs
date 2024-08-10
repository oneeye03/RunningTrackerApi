using Microsoft.EntityFrameworkCore;
using RunningTrackerApi.Context;
using RunningTrackerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningTrackerApi.Repository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly RunningTrackerContext _context;

        public UserProfileRepository(RunningTrackerContext context)
        {
            _context = context;
        }

        public async Task<UserProfile> GetByIdAsync(int id)
        {
            return await _context.UserProfiles
                .Include(u => u.RunningActivities)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task AddAsync(UserProfile userProfile)
        {
            _context.UserProfiles.Add(userProfile);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(UserProfile userProfile)
        {
            _context.UserProfiles.Update(userProfile);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var userProfile = await GetByIdAsync(id);
            if (userProfile != null)
            {
                _context.UserProfiles.Remove(userProfile);
                await _context.SaveChangesAsync();
            }
        }
    }
}
