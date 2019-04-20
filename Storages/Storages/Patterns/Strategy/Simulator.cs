using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages.Patterns.Strategy
{
    //TODO: Simulator
    class Simulator
    {
        public IStrategy strategy { get; set; }

        public Simulator(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteAlgorithm()
        {
            this.strategy.Algorithm();
        }
    }
}
