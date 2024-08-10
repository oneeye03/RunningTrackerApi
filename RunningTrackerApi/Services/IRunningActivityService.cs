using RunningTrackerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningTrackerApi.Services
{
    public interface IRunningActivityService
    {
        Task<RunningActivity> GetRunningActivityAsync(int id);
        Task AddRunningActivityAsync(RunningActivity runningActivity);
        Task UpdateRunningActivityAsync(RunningActivity runningActivity);
        Task DeleteRunningActivityAsync(int id);
    }
}
