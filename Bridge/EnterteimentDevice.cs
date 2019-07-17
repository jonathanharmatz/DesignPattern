using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{ 
    abstract class EnterteimentDevice
    {

        protected int state;
        protected int max;
        protected bool isOn;

        public abstract void PrintStatus();

        public abstract void PressNext();

        public abstract void PressPreviouse();

        public void TurnOn()
        {
            this.isOn = true;
            Console.WriteLine("Turned on!");
        }

        public void TurnOff()
        {
            this.isOn = false;
            Console.WriteLine("Turned off!");
        }

    }
}
