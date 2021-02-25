using System.Text;
using DesignPatterns.Models;

namespace DesignPatterns.CreatorPatterns.Builder
{
    public class Problem
    {
        // Let's say that we have a class that simply creates cars, it needs to insert an engine, the brand, a chassis and give it a color

        // You can see that with much bigger models, constructors and methods would be large and convoluted
        // or you would have a bunch of overloads in case your model should have different models applied, in our case, what if we don't want to give our car a brand
        // or after our car has been instanciated, we want to add an engine at a later stage?
        public Car CreateCar(string brandName, int maxTwistRating, string chassisNumber, int wheelBase, string hexCode, string colorName, int cylinders, int displacement)
        {
            return new Car
            {
                Brand = new Brand { Name = brandName },
                Chassis = new Chassis { MaxTwistRating = maxTwistRating, Number = chassisNumber, WheelBase = wheelBase },
                color = new Color { HexCode = hexCode, Name = colorName },
                engine = new Engine { Cylinders = cylinders, Displacement = displacement }
            };
        }

        // we dont want to paint our car, so we ommit the pain parameters
        public Car CreateCar(string brandName, int maxTwistRating, string chassisNumber, int wheelBase, int cylinders, int displacement)
        {
            return new Car
            {
                Brand = new Brand { Name = brandName },
                Chassis = new Chassis { MaxTwistRating = maxTwistRating, Number = chassisNumber, WheelBase = wheelBase },
                color = null,
                engine = new Engine { Cylinders = cylinders, Displacement = displacement }
            };
        }
    }
}