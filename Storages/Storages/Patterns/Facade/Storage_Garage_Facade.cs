using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storages.DataModel;

namespace Storages.Patterns.Facade
{
    class Storage_Garage_Facade
    {
        Garage garage;
        Storage storage;

        public Storage_Garage_Facade(Garage garage, Storage storage)
        {
            this.garage = garage;
            this.storage = storage;
        }

        public void Operation1()
        {
            //TODO: Some operation with Storage and Garage calling their methods
            throw new NotImplementedException();
        }

        public void Operation2()
        {
            //TODO: Some operation with Storage and Garage calling their methods
            throw new NotImplementedException();
        }

        public void Operation3()
        {
            //TODO: Some operation with Storage and Garage calling their methods
            throw new NotImplementedException();
        }
    }
}
