﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class TV : EnterteimentDevice
    {

        public TV(int state, int max, bool isOn)
        {
            this.state = state;
            this.max = max;
            this.isOn = isOn;
        }

        public override void PressNext()
        {
            this.state++;

            if(this.state > this.max)
                this.state = 1;

            this.PrintStatus();
        }

        public override void PressPreviouse()
        {
            this.state--;

            if (this.state < 1)
                this.state = this.max;

            this.PrintStatus();
        }

        public override void PrintStatus()
        {
            Console.WriteLine($"The tv channel is now: {this.state}");
        }
    }
}
