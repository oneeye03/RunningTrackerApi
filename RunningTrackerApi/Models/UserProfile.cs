using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningTrackerApi.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; } // in kg
        public float Height { get; set; } // in cm
        public DateTime BirthDate { get; set; }

        public int Age => DateTime.Now.Year - BirthDate.Year;

        public float BMI => Weight / ((Height / 100) * (Height / 100));

        public ICollection<RunningActivity> RunningActivities { get; set; }
    }
}
