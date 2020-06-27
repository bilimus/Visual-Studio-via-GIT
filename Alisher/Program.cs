using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisher
{

    class Car
    {
        private string color;

        public Car()
        { Color = "empty"; }

        public Car(string col)
        { Color = col; }

        public string Color
        {
          get {return color;}
          set {color = value;}
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("red");
            //car1.Color = "red";
            
            Console.WriteLine("Color of a car is {0}", car1.Color);
            Console.ReadKey();
        }
    }
}
