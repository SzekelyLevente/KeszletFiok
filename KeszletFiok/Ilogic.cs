using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeszletFiok
{
    internal interface Ilogic
    {
        String Read(String key);
        void Update(String key, String value);
        bool Contains(String key);
    }
}
