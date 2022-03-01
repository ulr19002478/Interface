using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //creating the vehicle interface
    internal interface IVehicle 
    {
        public int NoOfWheels { get; set; }
        public string? Colour  { get; set; }
        public string Horn();              
    }

    //creating a class from the interface
    internal class Car : IVehicle 
    {
        public int NoOfWheels { get; set; }
        public string? Colour { get; set; }
        public string Horn()
        {
            return "beep";
        }

    }
}
