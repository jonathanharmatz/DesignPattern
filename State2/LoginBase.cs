using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExrc2
{
    public abstract class LoginBase : ILoginState
    {

        protected Context ctx;

        protected const string correctPass = "1234";

        protected LoginBase(Context ctx)
        {
            this.ctx = ctx;
        }

        public abstract void Login(string password);

        public virtual void Restart()
        {
            Console.WriteLine("Restart, login again");
            ctx.State = new NewLogin(ctx);
        }

    }
}
