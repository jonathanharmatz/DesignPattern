using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExrc2
{
    class Program
    {
        static void Main(string[] args)
        {

            Context ctx = new Context();

            ctx.Init(new NewLogin(ctx));

            ctx.Login("456");
            ctx.Login("456");
            ctx.Login("456");
            ctx.Restart();
            ctx.Restart();
            ctx.Login("1234");
        }
    }
}
