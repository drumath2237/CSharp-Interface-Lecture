namespace InterfaceLecture.Movables
{
    public class Bus : IMovable
    {
        public void GoBack()
        {
            Console.WriteLine("[bus]: go back");
        }

        public void GoForward()
        {
            Console.WriteLine("[bus]: go forward");
        }

        public void GoLeft()
        {
            Console.WriteLine("[bus]: go left");
        }

        public void GoRight()
        {
            Console.WriteLine("[bus]: go right");
        }
    }
}