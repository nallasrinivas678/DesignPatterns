using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.FactoryManager
{
    public class Scooter : IVehicle
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter for "+miles.ToString()+" miles.");
        }
    }
}
