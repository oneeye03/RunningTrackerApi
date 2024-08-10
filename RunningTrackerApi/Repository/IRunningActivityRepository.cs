using RunningTrackerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningTrackerApi.Repository
{
    public interface IRunningActivityRepository
    {
        Task<RunningActivity> GetByIdAsync(int id);
        Task AddAsync(RunningActivity runningActivity);
        Task UpdateAsync(RunningActivity runningActivity);
        Task DeleteAsync(int id);
    }
}
