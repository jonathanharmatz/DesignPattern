using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExrc
{
    class Clock
    {
         private static Clock instance;

        private static Object key = new Object();

        private Clock()
        {

        }

        public DateTime getCurrTime()
        {
            return new DateTime();
        }
        public static Clock getInstance()
        {
            if(instance != null)
            {
                return instance;
            }

            lock (key)
            {
                if(instance == null)
                {
                    instance = new Clock();
                }

                return instance;
            }
        }

    }

}
