using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Bus:Car
    {
        public int PassengerCount;
        public Bus(string Brand, string Model, string Color, int MaxSpeed, int PassengerCount) : base(Brand, Model, Color, MaxSpeed)
        {
            this.PassengerCount = PassengerCount;
        }
        public override void Info()
        {
            Console.WriteLine($"Marka: {Brand} Model: {Model}  Color: {Color} Maximum Speed: {MaxSpeed} Passenger Count : {PassengerCount}");
        }
    }
}
