using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages.Patterns.Abstract_factory
{
    interface IFactory
    {
        IGranularTransport CreateGranularTransport();
        ISolidTransport CreateSolidTransport();
        ILiquidTransport CreateLiquidTransport();
    }
}
