using System;

namespace OOps
{
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            Bus myBus = new Bus();

            myBus.Color = "Blue";

            Console.WriteLine("Bus Color: " + myBus.Color);
        }
    }

    class Bus
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}