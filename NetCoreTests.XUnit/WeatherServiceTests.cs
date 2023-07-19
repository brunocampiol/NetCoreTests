using System.Net;
using NetCoreTests.App.Services;
using NetCoreTests.Common;
using RichardSzalay.MockHttp;
using Xunit;

namespace NetCoreTests.XUnit
{
    public sealed class WeatherServiceTests
    {
        [Fact]
        public async Task GetCurrentWeatherAsync_WhenValidInputs_ExpectsStringResponse()
        {
            // Assemble
            var httpClient = new MockHttpMessageHandler();
            httpClient.When("*")
                      .Respond(HttpStatusCode.OK);

            var httpClientFactory = new MockHttpClientFactory(httpClient);

            var service = new WeatherService(httpClientFactory);

            // Act
            var response = await service.GetCurrentWeatherAsync(1234f, 1234f);

            // Assert
            Assert.NotNull(response);
        }
    }
}
