using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmBroken : ILightState
    {
        public ILightState Fix()
        {
            Console.WriteLine("Switch fixed, light is now off");

            return new IAmOff();
        }

        public ILightState TurnOff()
        {
            Console.WriteLine("Switch is broken! Can't turn off the light");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Switch is broken! Can't turn on the light");
            return this;
        }
        

    }
}
