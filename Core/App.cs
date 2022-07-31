namespace InterfaceLecture.Core
{
    public class App
    {
        private readonly IMovable _movable;
        private readonly IWeatherService _service;

        public App(IMovable movable, IWeatherService service)
        {
            _movable = movable;
            _service = service;
        }

        public async Task RunAsync(string cityCode)
        {
            var weather = await _service.TryGetWeatherAsync(cityCode);
            
            switch (weather)
            {
                case Weather.Rainy:
                    _movable.GoForward();
                    _movable.GoLeft();
                    _movable.GoLeft();
                    break;
                case Weather.Cloudy:
                    _movable.GoForward();
                    break;
                case Weather.Sunny:
                default:
                    _movable.GoBack();
                    break;
            }
        }
    }
}