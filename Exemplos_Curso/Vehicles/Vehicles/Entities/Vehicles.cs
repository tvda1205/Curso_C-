using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Entities
{
    class Vehicles
    {

        public string Model {  get; set; }

        public Vehicles(string model)
        {
            Model = model;
        }
    }
}
