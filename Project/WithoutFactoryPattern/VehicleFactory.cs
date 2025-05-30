using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WithoutFactoryPattern
{
    public class Car
    {
        public void Drive() { Console.WriteLine("Driving a Car"); }
    }

    public class Bike
    {
        public void Drive() { Console.WriteLine("Driving a Car"); }
    }

    public class FactoryVehicle
    {
        public static void BuyVehicle(string vehicle)
        {
            if(vehicle.ToLower() == "car")
            {
                Car car = new Car();
                car.Drive();
            }
            else if(vehicle.ToLower() == "bike")
            {
                Bike bike = new Bike();
                bike.Drive();
            }
        }
    }    
    
}
