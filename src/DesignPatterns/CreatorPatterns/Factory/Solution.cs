using DesignPatterns.Interfaces;
using DesignPatterns.Models;

namespace DesignPatterns.CreatorPatterns.Factory
{
    public class Solution
    {
        // first we create a factory abstraction
        public abstract class VehicleFactory
        {
            public abstract IVehicle Build();
        }

        public class CarFactory : VehicleFactory
        {
            public override IVehicle Build()
            {
                return new Car();
            }
        }

        public class TruckFactory : VehicleFactory
        {
            public override IVehicle Build()
            {
                return new Truck();
            }
        }

        // usage

        public void CreateVehicles()
        {
            var carFactory = new CarFactory();
            var car = carFactory.Build();

            var truckFactory = new TruckFactory();
            var truck = truckFactory.Build();
        }


    }
}