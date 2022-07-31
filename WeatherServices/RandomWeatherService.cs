using InterfaceLecture.Core;

namespace InterfaceLecture.WeatherServices;

public class RandomWeatherService : IWeatherService
{
    public Task<Weather> TryGetWeatherAsync(string cityCode)
    {
        var random = new Random();
        var randomNumber = random.Next(0, 3);

        var weather = randomNumber switch
        {
            0 => Weather.Sunny,
            1 => Weather.Cloudy,
            _ => Weather.Rainy,
        };

        return Task.FromResult(weather);
    }
}