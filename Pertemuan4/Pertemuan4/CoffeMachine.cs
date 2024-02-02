using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffeMachine
{
    internal class CoffeMachine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;

        public CoffeMachine(CoffePowder powder, WaterGalon galon)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
        }

        public String makeEsspresso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }

            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your coffe is ready";
        }

        public String checkAvailability()
        {
            return $"the water :{this.waterGalon.getVolume()} and teh coffe powder : {this.coffePowder.getNetto()}";
        }
    }
}
