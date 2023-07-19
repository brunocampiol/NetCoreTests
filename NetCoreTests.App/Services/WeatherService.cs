using System.Globalization;

namespace NetCoreTests.App.Services
{
    public sealed class WeatherService
    {
        // This class uses the Open-Meteo API https://open-meteo.com/en/docs

        private readonly IHttpClientFactory _httpClientFactory;
        private const string _baseUrl = "https://api.open-meteo.com/v1";

        public WeatherService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> GetCurrentWeatherAsync(float latitude, float longitude)
        {
            // https://api.open-meteo.com/v1/forecast?latitude=71.29&longitude=156.77&current_weather=true
            // TODO: fix rounding positions
            // Example: 30.0368 -> 30.03
            var endpoint = $"{_baseUrl}/forecast?" +
                           $"latitude={latitude.ToString("F2", CultureInfo.InvariantCulture)}&" +
                           $"longitude={longitude.ToString("F2", CultureInfo.InvariantCulture)}&" +
                           $"current_weather=true";

            var httpClient = _httpClientFactory.CreateClient();
            var httpResponse = await httpClient.GetAsync(endpoint);
            return await httpResponse.Content.ReadAsStringAsync();
        }
    }
}
