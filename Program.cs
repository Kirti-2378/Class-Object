using System;

namespace ClassWork1
{
    internal class Mobile // It is a Class 
    {
        int Price;
        string name;
        string Color;

        public void calling()
        {
            Console.WriteLine("Voice msg");
        }
        public void Chatting()
        {
            Console.WriteLine("Chat");
        }
        public void VideoCalling()
        {
            Console.WriteLine("VideoCalling");
        }
        static void Main(string[] args)
        {
            Mobile m = new Mobile();
            m.Price = 75000;
            m.name = "Nothing";
            m.Color = "White";

            Console.WriteLine(m.Price);
            Console.WriteLine(m.name);
            Console.WriteLine(m.Color);

            m.calling(); m.Chatting(); m.VideoCalling();
        }
    }
}
