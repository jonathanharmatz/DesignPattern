using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExrc2
{
    class LoginFailed : LoginBase
    {

        public int numberOfTries;
        public LoginFailed(Context ctx) : base(ctx)
        {
            numberOfTries = 2;
        }

        public override void Login(string password)
        {
            if (password == correctPass)
            {
                Console.WriteLine("Logged in successfully!");
                ctx.State = new LoginSucceed(ctx);
            }
            else
            {
                Console.WriteLine("Failed to login, " + --this.numberOfTries + " tries left");

                if(numberOfTries == 0)
                {
                    Console.WriteLine("You entered a wrong password 3 times. User in now locked");
                    ctx.State = new Locked(ctx);
                }
            }
        }
    }
}
