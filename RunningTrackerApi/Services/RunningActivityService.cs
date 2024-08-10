using RunningTrackerApi.Models;
using RunningTrackerApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningTrackerApi.Services
{
    public class RunningActivityService : IRunningActivityService
    {
        private readonly IRunningActivityRepository _repository;

        public RunningActivityService(IRunningActivityRepository repository)
        {
            _repository = repository;
        }

        public async Task<RunningActivity> GetRunningActivityAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddRunningActivityAsync(RunningActivity runningActivity)
        {
            await _repository.AddAsync(runningActivity);
        }

        public async Task UpdateRunningActivityAsync(RunningActivity runningActivity)
        {
            await _repository.UpdateAsync(runningActivity);
        }

        public async Task DeleteRunningActivityAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
