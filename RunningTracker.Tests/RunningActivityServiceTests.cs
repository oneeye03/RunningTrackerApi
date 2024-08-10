using Moq;
using RunningTrackerApi.Repository;
using RunningTrackerApi.Models;
using RunningTrackerApi.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace RunningTracker.Tests
{
    public class RunningActivityServiceTests
    {
        [Fact]
        public async Task AddRunningActivityAsync_ShouldAddRunningActivity()
        {
            // Arrange
            var mockRepo = new Mock<IRunningActivityRepository>();
            var service = new RunningActivityService(mockRepo.Object);

            var runningActivity = new RunningActivity
            {
                UserProfileId = 1,
                Location = "Park",
                StartDateTime = DateTime.Now.AddMinutes(-30),
                EndDateTime = DateTime.Now,
                Distance = 5
            };

            // Act
            await service.AddRunningActivityAsync(runningActivity);

            // Assert
            mockRepo.Verify(repo => repo.AddAsync(runningActivity), Times.Once);
        }
    }
}
