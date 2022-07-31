namespace InterfaceLecture.WeatherServices
{
    public class MyWeatherService : IWeatherService
    {
        public Task<Weather> TryGetWeatherAsync(string cityCode)
        {
            var weather = cityCode switch
            {
                "001" => Weather.Sunny,
                "002" => Weather.Cloudy,
                _ => Weather.Rainy
            };

            return Task.FromResult(weather);
        }
    }
}