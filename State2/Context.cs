using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExrc2
{
    public class Context
    {

        public ILoginState State { get; set; }

        public Context() { }


        public void Init(ILoginState state)
        {
            State = state;
        }

        public void Login(string password)
        {
            if (State == null)
                throw new ApplicationException("State not initialized!");

            State.Login(password);
        }

        public void Restart()
        {
            if (State == null)
                throw new ApplicationException("State not initialized!");

            State.Restart();
        }
    }
}
