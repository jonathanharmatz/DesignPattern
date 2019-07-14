using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExrc2
{
    public class NewLogin : LoginBase
    {

        public NewLogin(Context ctx) : base(ctx)
        {
        }

        public override void Login(string password)
        {
         if(password == correctPass)
            {
                Console.WriteLine("Logged in successfully!");
                ctx.State = new LoginSucceed(ctx);
            }
         else
            {
                Console.WriteLine("Failed to login, 2 more chances");
                ctx.State = new LoginFailed(ctx);
            }
         
        }

        public override void Restart()
        {
            Console.WriteLine("Restart, already in new login");
        }
    }
}
