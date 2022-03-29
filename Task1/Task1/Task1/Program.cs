using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car drift = new Car("Mercedes", "E63", "Black", 350);
            drift.Info();
            Bus vehicle = new Bus("Deawou", "A20", "White", 150,40);
            vehicle.Info();
        }
    }
}
