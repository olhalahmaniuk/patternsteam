using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages.Patterns.Proxy
{
    class Proxy : Implementer
    {
        ImplementerContext implementerContext;

        public override void Implement()
        {
            if (implementerContext == null)
                implementerContext = new ImplementerContext();
            implementerContext.Implement();
        }

        //TODO: Other methods for Proxy
    }
}
