using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoQ4
{

    internal class Methanol : EnergyTypeBase
    {
        public override double GetEnergyDenisty()
        {
            double density = 15.6;
            return density;
        }

        public override string GetEnergyType()
        {
            string type = "Chemical";
            return type;
        }

        public override string GetName()
        {
            string name = "Methanol";
            return name;
        }

        public override double GetSpecificEnergy()
        {
            double energy = 19.7;
            return energy;
        }
    }
}
