using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages.Patterns.Manager
{
    abstract class Colleague
    {
        protected IManagerMediator manager;

        public Colleague(IManagerMediator manager)
        {
            this.manager = manager;
        }
    }
}
