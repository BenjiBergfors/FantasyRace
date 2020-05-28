using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyRace
{
    class Unicorn : Animal
    {
        public Unicorn()
        {
            

            Random generator = new Random();
            //  stats
            speed = generator.Next(4, 8);
            position = 0;
            energyMax = generator.Next(4, 8);
            energyCurrent = energyMax;

            
        } 

    }
}
