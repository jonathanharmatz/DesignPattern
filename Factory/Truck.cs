using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExrc
{

    public class Truck : Vehicle
    {

        protected string hunk;



        public Truck(string model, float cylinder, string color, int numberOfWheels, string hunk) : base(model, cylinder, color, numberOfWheels)
        {
            this.hunk = hunk;
        }

        public override string ToString()
        {
            return "Truck : " + base.ToString() + $" { hunk}";
        }
    }
}
