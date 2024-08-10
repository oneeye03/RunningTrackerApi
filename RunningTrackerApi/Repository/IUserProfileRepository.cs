using RunningTrackerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningTrackerApi.Repository
{
    public interface IUserProfileRepository
    {
        Task<UserProfile> GetByIdAsync(int id);
        Task AddAsync(UserProfile userProfile);
        Task UpdateAsync(UserProfile userProfile);
        Task DeleteAsync(int id);
    }
}
