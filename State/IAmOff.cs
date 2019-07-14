﻿using System;

namespace State
{
    public class IAmOff : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("Light is already off...");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Turning on the light!");
            return new IAmOn();
        }

        public ILightState Fix()
        {
            Console.WriteLine("Switch is not broken, nothing to fix");

            return this;
        }
    }
}
