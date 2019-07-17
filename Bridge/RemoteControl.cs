using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class RemoteControl
    {

        EnterteimentDevice enterDevice;

        public RemoteControl (EnterteimentDevice givenDevice)
        {
            this.enterDevice = givenDevice;
        }

        public EnterteimentDevice GetDevice()
        {
            return this.enterDevice;
        }

        public void SetDevice(EnterteimentDevice deviceToSet)
        {
            this.enterDevice = deviceToSet;
        }

        public void On()
        {
            this.enterDevice.TurnOn();
        }

        public void Off()
        {
            this.enterDevice.TurnOff();
        }

        public void Next()
        {
            this.enterDevice.PressNext();
        }

        public void Prev()
        {
            this.enterDevice.PressPreviouse();
        }

        public void PrintStatus()
        {
            this.enterDevice.PrintStatus();
        }
    }
}
