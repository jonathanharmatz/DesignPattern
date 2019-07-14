using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExrc2
{
    class Locked : LoginBase
    {
        public Locked(Context ctx) : base(ctx)
        {
        }

        public override void Login(string password)
        {
            Console.WriteLine("You are locked, can't log in");
        }

        public override void Restart()
        {
            System.Console.WriteLine("Restart, back to login");
            ctx.State = new NewLogin(ctx);
        }
    }
}
