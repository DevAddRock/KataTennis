using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTennis
{
    public sealed class Singleton
    {
        public static bool Instance(object instance)
        {
            if (instance == null)
                return true;
            else
                return false;
        }
    }
}
