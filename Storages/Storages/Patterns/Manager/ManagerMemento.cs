using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages.Patterns.Manager
{
    class ManagerMemento
    {
        //TODO: What to save in memento
        public string State { get; private set; }

        public ManagerMemento(string state)
        {
            this.State = state;
        }
    }
}
