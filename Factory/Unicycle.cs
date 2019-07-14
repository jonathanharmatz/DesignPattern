using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExrc
{
    public class Unicycle : Vehicle
    {

        protected string ring;

        public Unicycle(string model, float cylinder, string color, int numberOfWheels, string ring) : base(model, cylinder, color, numberOfWheels)
        {
            this.ring = ring;
        }

        public override string ToString()
        {
            return "Unicycle : " + base.ToString() + $" { ring }";
        }
    }
}

