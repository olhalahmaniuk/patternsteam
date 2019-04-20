using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages.Patterns.Manager
{
    class ManagerFacade
    {
        ManagerSingleton manager;

        public ManagerFacade()
        {
            manager = ManagerSingleton.getInstance();
        }

        public void ManagerSendMessage(string msg, Colleague colleague)
        {
            manager.sendMessage(msg, colleague);
        }

        public void ManagerSaveState()
        {
            manager.SaveState();
        }

        public string ManagerRestoreState(ManagerMemento memento)
        {
            return manager.RestoreState(memento);
        }
    }
}
