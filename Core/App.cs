namespace InterfaceLecture.Core
{
    public class App
    {
        IMovable movable;
        IWeatherService service;
        public App(IMovable movable, IWeatherService service)
        {
            this.movable = movable;
            this.service = service;
        }

        public void Run()
        {

        }
    }
}