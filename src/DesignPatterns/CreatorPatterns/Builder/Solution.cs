using System.Collections.Generic;
using System.Text;
using DesignPatterns.Models;

namespace DesignPatterns.CreatorPatterns.Builder
{
    public class Solution
    {
        // here we will use the builder pattern to create a new car for us

        public class CarBuilder
        {
            private readonly Car _car;

            // first we start with an emtpy model instance of our car. this is the bare bones
            public CarBuilder()
            {
                _car = new Car();
            }

            public CarBuilder AddEngine(int cylinders, int displacement)
            {
                _car.engine = new Engine { Cylinders = cylinders, Displacement = displacement };
                return this;
            }

            public CarBuilder PaintCar(string hexCode, string name)
            {
                _car.color = new Color
                {
                    HexCode = hexCode,
                    Name = name
                };
                return this;
            }

            public CarBuilder AddChassis(int maxTwistRating, int wheelBase)
            {
                _car.Chassis = new Chassis
                {
                    MaxTwistRating = maxTwistRating,
                    WheelBase = wheelBase,
                };

                return this;
            }

            public CarBuilder AddBrand(string name)
            {

                _car.Brand = new Brand
                {
                    Name = name
                };
                return this;
            }

            public Car Build()
            {
                return _car;
            }
        }


        // now that we have our car builder, we can now create a car like this
        public Car BuildCar()
        {
            var car = new CarBuilder()
                .AddBrand("Ford")
                .AddEngine(8, 5)
                .AddChassis(20, 20)
                .PaintCar("#FFF", "Oxford White")
                .Build();

            return car;
        }

    }
}