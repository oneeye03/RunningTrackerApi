using Moq;
using RunningTrackerApi.Repository;
using RunningTrackerApi.Models;
using RunningTrackerApi.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace RunningTracker.Tests
{
    public class UserProfileServiceTests
    {
        [Fact]
        public async Task AddUserProfileAsync_ShouldAddUserProfile()
        {
            // Arrange
            var mockRepo = new Mock<IUserProfileRepository>();
            var service = new UserProfileService(mockRepo.Object);

            var userProfile = new UserProfile
            {
                Name = "John Doe",
                Weight = 70,
                Height = 175,
                BirthDate = new DateTime(1990, 1, 1)
            };

            // Act
            await service.AddUserProfileAsync(userProfile);

            // Assert
            mockRepo.Verify(repo => repo.AddAsync(userProfile), Times.Once);
        }
    }
}
