using InterfaceLecture.Core;

namespace InterfaceLecture.Movables
{
    public class Car : IMovable
    {
        public void GoBack()
        {
            Console.WriteLine("[car]: go back");
        }

        public void GoForward()
        {
            Console.WriteLine("[car]: go forward");
        }

        public void GoLeft()
        {
            Console.WriteLine("[car]: go left");
        }

        public void GoRight()
        {
            Console.WriteLine("[car]: go right");
        }
    }
}