using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExrc2
{
    public interface ILoginState
    {

        void Login(string password);

        void Restart();
    }
}
