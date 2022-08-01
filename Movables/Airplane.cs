using InterfaceLecture.Core;

namespace InterfaceLecture.Movables
{
    public class Airplane : IMovable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("[airplane]: fly");
        }

        public void GoBack()
        {
            Console.WriteLine("[airplane]: go back");
        }

        public void GoForward()
        {
            Console.WriteLine("[airplane]: go forward");
        }

        public void GoLeft()
        {
            Console.WriteLine("[airplane]: go left");
        }

        public void GoRight()
        {
            Console.WriteLine("[airplane]: go right");
        }
    }
}