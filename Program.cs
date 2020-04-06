using FactoryDesignPattern.FactoryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();
            IVehicle scooter = factory.GetVehicle("Scooter");
            scooter.Drive(20);
            IVehicle bike = factory.GetVehicle("Bike");
            bike.Drive(40);
            Console.ReadLine();
        }
    }
}
