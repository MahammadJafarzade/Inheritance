using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public int MaxSpeed;


        public virtual void Info()
        {
            Console.WriteLine($"Brand:{Brand}, Model:{Model} ,Color:{Color}, MaxSpeed:{MaxSpeed}");
        }
        public Car()
        {
            Console.WriteLine("Car created");
        }
        public Car(string Brand,string Model)
        {
            this.Brand = Brand;
            this.Model = Model;
        }
        public Car(string Brand, string Model, string Color, int MaxSpeed):this(Brand,Model)
        {
            this.Color = Color;
            this.MaxSpeed = MaxSpeed;
        }
 
    }
}
