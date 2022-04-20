using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoQ4
{
    public abstract class EnergyTypeBase
    {
        public abstract string GetName();
        public abstract string GetEnergyType();
        public abstract double GetSpecificEnergy();
        public abstract double GetEnergyDenisty();

    }
}
