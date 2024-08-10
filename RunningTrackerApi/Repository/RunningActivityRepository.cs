using Microsoft.EntityFrameworkCore;
using RunningTrackerApi.Context;
using RunningTrackerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningTrackerApi.Repository
{
    public class RunningActivityRepository : IRunningActivityRepository
    {
        private readonly RunningTrackerContext _context;

        public RunningActivityRepository(RunningTrackerContext context)
        {
            _context = context;
        }

        public async Task<RunningActivity> GetByIdAsync(int id)
        {
            return await _context.RunningActivities
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task AddAsync(RunningActivity runningActivity)
        {
            _context.RunningActivities.Add(runningActivity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(RunningActivity runningActivity)
        {
            _context.RunningActivities.Update(runningActivity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var activity = await GetByIdAsync(id);
            if (activity != null)
            {
                _context.RunningActivities.Remove(activity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
