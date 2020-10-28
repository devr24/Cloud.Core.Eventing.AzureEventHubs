using System;
using Cloud.Core.Testing;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Cloud.Core.Eventing.AzureEventHubs.Tests.Integration
{
    public class IntegrationTestsFixture : IDisposable
    {
        public IntegrationTestsFixture()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();
        }

        public void Dispose()
        {
            // Clean up.
        }
    }

    [IsIntegration]
    public class EventHubsIntegrationTests : IClassFixture<IntegrationTestsFixture>
    {
        private readonly IntegrationTestsFixture _fixture;

        public EventHubsIntegrationTests(IntegrationTestsFixture fixture)
        {
            _fixture = fixture;
        }

        /// <summary>Verify ...</summary>
        [Fact]
        public void Test_PubSubMessenger_SendMessage()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
