using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoQ4
{
    internal class Ethanol : EnergyTypeBase
    {
        public override double GetEnergyDenisty()
        {
            double density = 24;
            return density;
        }

        public override string GetEnergyType()
        {
            string type = "Chemical";
            return type;
        }

        public override string GetName()
        {
            string name = "Ethanol";
            return name;
        }

        public override double GetSpecificEnergy()
        {
            double energy = 30;
            return energy;
        }
    }
}
