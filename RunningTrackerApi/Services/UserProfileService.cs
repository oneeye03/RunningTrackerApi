using RunningTrackerApi.Repository;
using RunningTrackerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningTrackerApi.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _repository;

        public UserProfileService(IUserProfileRepository repository)
        {
            _repository = repository;
        }

        public Task<UserProfile> GetUserProfileAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task AddUserProfileAsync(UserProfile userProfile)
        {
            return _repository.AddAsync(userProfile);
        }

        public async Task UpdateUserProfileAsync(UserProfile userProfile)
        {
            await _repository.UpdateAsync(userProfile);
        }
        public async Task DeleteUserProfileAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
