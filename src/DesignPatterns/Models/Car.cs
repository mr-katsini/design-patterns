using DesignPatterns.Interfaces;

namespace DesignPatterns.Models
{
    public class Car : IVehicle
    {
        public Engine engine { get; set; }
        public Chassis Chassis { get; set; }
        public Brand Brand { get; set; }
        public Color color { get; set; }
    }
}