using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExrc
{
    class Program
    {
        static void Main(string[] args)
        {

            Clock clk1 = Clock.getInstance();
            Clock clk2 = Clock.getInstance();
            Clock clk3 = Clock.getInstance();

            Console.WriteLine(clk1.getCurrTime());
            Console.WriteLine(clk2.getCurrTime());
            Console.WriteLine(clk3.getCurrTime());

        }
    }
}
