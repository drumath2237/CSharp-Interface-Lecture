namespace InterfaceLecture.Core
{

    public enum Weather
    {
        Sunny,
        Rainy,
        Cloudy
    }

    public interface IWeatherService
    {
        Task<Weather> TryGetWeatherAsync(string cityCode);
    }
}