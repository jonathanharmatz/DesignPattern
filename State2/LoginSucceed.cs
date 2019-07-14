namespace StateExrc2
{
    internal class LoginSucceed : LoginBase
    {
        public LoginSucceed(Context ctx) : base(ctx)
        {
        }

        public override void Login(string password)
        {
            System.Console.WriteLine("Already logged in!");
            ctx.State = this;
        }
    }
}