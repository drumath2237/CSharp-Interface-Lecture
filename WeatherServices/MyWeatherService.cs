using InterfaceLecture.Core;

namespace InterfaceLecture.WeatherServices
{
    public class MyWeatherService : IWeatherService
    {
        public Task<Weather> TryGetWeatherAsync(string cityCode)
        {
            return Task.Run(() => cityCode switch
            {
                "001" => Weather.Sunny,
                "002" => Weather.Cloudy,
                _ => Weather.Rainy
            });
        }
    }
}