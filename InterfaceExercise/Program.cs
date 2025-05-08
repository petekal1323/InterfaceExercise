using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           var car = new Car();
           var truck = new Truck();
           var vehicles = new List<IVehicle>() { car, truck};
           

           foreach (var vehicle in vehicles)
           {    
               vehicle.Drive();
               vehicle.ChangeGear(true);
               vehicle.Reverse();
               vehicle.ChangeGear(true);
               vehicle.Park();
           }
        }
    }
}
