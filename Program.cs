using InterfaceLecture.Core;
using InterfaceLecture.Movables;
using InterfaceLecture.WeatherServices;

public class Program
{
    public static void Main()
    {
        IWeatherService service = new MyWeatherService();
        IMovable movable = new Car();

        var app = new App(movable, service);
        _ = app.RunAsync("002");
    }
}