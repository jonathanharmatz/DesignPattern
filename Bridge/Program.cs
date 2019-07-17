using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {

            RemoteControl remote = new RemoteControl(new TV(8, 10, false));

            remote.On();

            remote.Next();
            remote.Next();
            remote.Next();
            remote.Next();

            remote.SetDevice(new Memir(9, 10, false));

            remote.On();

            remote.Next();
            remote.Next();
            remote.Next();
            remote.Next();
        }
    }
}
