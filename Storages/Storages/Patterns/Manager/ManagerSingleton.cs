using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages.Patterns.Manager
{
    class ManagerSingleton : IManagerMediator
    {
        private static object syncRoot = new Object();
        private static ManagerSingleton instance;

        //TODO: Add real collegues for mediator
        public ConcreteColleague1 Colleague1 { get; set; }
        public ConcreteColleague2 Colleague2 { get; set; }

        private ManagerSingleton()
        {

        }

        public static ManagerSingleton getInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new ManagerSingleton();
                }
            }
            return instance;
        }

        //TODO: Manage send method with real collegues
        public void sendMessage(string msg, Colleague colleague)
        {
            if (Colleague1 == colleague)
                Colleague2.Notify(msg);
            else
                Colleague1.Notify(msg);
        }

        // TODO: Saving some state
        public ManagerMemento SaveState()
        {
            return new ManagerMemento("state");
        }

        //TODO: Restoring state
        public string RestoreState(ManagerMemento memento)
        {
            string state = memento.State;
            return state;
        }
    }
}
