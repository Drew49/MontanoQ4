using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoQ4
{
    internal class Gasoline : EnergyTypeBase
    {
        public override double GetEnergyDenisty()
        {
            double density = 34.2;
            return density;
        }

        public override string GetEnergyType()
        {
            string type = "Chemical";
            return type;
        }

        public override string GetName()
        {
            string name = "Gasoline";
            return name;
        }

        public override double GetSpecificEnergy()
        {
           double energy = 46.4;
            return energy;
        }
    }
}
