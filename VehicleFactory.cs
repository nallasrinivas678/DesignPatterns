using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.FactoryManager
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string vehicle);
    }
}
