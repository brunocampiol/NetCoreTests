using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreTests.App.Services;

namespace NetCoreTests.App
{
    public static class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new HostBuilder()
              .ConfigureServices((hostContext, services) =>
              {
                  services.AddHttpClient();
              })
              .UseConsoleLifetime();

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                Console.WriteLine($"Hello World! arguments count: {args.Count()}");

                var httpClientFactory = serviceScope.ServiceProvider.GetRequiredService<IHttpClientFactory>();
                var weatherService = new WeatherService(httpClientFactory);
                var response = await weatherService.GetCurrentWeatherAsync(30.0368f, 51.2090f);
                Console.WriteLine($"Weather response -> {response}");
            }
        }
    }
}
