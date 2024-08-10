using RunningTrackerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningTrackerApi.Services
{
    public interface IUserProfileService
    {
        Task<UserProfile> GetUserProfileAsync(int id);
        Task AddUserProfileAsync(UserProfile userProfile);
        Task UpdateUserProfileAsync(UserProfile userProfile);
        Task DeleteUserProfileAsync(int id);
    }
}
