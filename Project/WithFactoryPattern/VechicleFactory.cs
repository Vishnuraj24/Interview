using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithFactoryPattern
{
    public interface IVehicle
    {
        public void Drive() { }
    }
    public class Car : IVehicle
    {
        public void Drive() { Console.WriteLine("Driving a Car"); }
    }

    public class Bike :IVehicle
    {
        public void Drive() { Console.WriteLine("Driving a Car"); }
    }

    public static class FactoryVehicle
    {
        public static IVehicle BuyVehicle(string vehicle)
        {
            if (vehicle.ToLower() == "car")
            {
                return new Car();
            }
            else if (vehicle.ToLower() == "bike")
            {
                return new Bike(); 
            }
            else
            {
                throw new Exception("Invalid vechicle Type");
            }
        }
    }
}
