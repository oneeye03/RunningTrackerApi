using Microsoft.EntityFrameworkCore;
using RunningTrackerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningTrackerApi.Context
{
    public class RunningTrackerContext : DbContext
    {
        public RunningTrackerContext(DbContextOptions<RunningTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<RunningActivity> RunningActivities { get; set; }
    }
}
