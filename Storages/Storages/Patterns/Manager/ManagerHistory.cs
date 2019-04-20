using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages.Patterns.Manager
{
    class ManagerHistory
    {
        public Stack<ManagerMemento> History { get; private set; }
        public ManagerHistory()
        {
            History = new Stack<ManagerMemento>();
        }
    }
}
