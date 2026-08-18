using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    internal class Program // CLass Name 
    {
        static void Main1(string[] args)
        {
            Car myCar = new Car(); 
            Console.WriteLine(myCar.Name);
            Console.WriteLine(myCar.Price);
        }
    }
    class Car
    {
        public string Name = "Toyota"; 
        public int Price = 125000;
    }
}
