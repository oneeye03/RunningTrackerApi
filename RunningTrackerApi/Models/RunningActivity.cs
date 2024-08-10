using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningTrackerApi.Models
{
    public class RunningActivity
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public float Distance { get; set; } // in km

        public TimeSpan Duration => EndDateTime - StartDateTime;

        public float AveragePace => (float)Duration.TotalMinutes / Distance;

        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
