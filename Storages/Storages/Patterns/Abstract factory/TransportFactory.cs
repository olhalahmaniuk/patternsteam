using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storages.DataModel.Transport_types;

namespace Storages.Patterns.Abstract_factory
{
    class TransportFactory : IFactory
    {
        public IGranularTransport CreateGranularTransport()
        {
            return new GranularTransport();
        }

        public ISolidTransport CreateSolidTransport()
        {
            return new SolidTransport();
        }

        public ILiquidTransport CreateLiquidTransport()
        {
            return new LiquidTransport();
        }
    }
}
