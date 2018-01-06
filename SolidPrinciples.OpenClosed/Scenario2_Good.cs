using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosed
{
    //GOOD SCENARIO
    public abstract class Vehicle
    {
        public abstract void Start();
    }
    public class Car : Vehicle
    {
        public override void Start()
        {
            throw new NotImplementedException();
        }
    }
    public class Helicopter : Vehicle
    {
        public override void Start()
        {
            throw new NotImplementedException();
        }
    }
    public class Truck : Vehicle
    {
        public override void Start()
        {
            throw new NotImplementedException();
        }
    }

    public class VehicleEngineManager
    {
        public void Start(Vehicle vehicle)
        {
            vehicle.Start();
        }
    }

    //And now we can add a new vehicle type. "Open to extension"
    //We will not change the VehicleEngineManager codes. because of, VehicleEngineManager's Start method uses Vehicle type parameter.  "Closed to modification"


}
