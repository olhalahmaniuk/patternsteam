using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages.Patterns.Manager
{
    interface IManagerMediator
    {
        void sendMessage(string msg, Colleague colleague);
    }
}
