using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyRace
{
    class Unicorn : Animal
    {
        public Unicorn()
        {
            //int speed = 0;
            //int position = 0;
            //int energyCurrent = 0;
            //int energyMax = 0 ;

            Random generator = new Random();

            speed = generator.Next(4, 8);
            position = 0;
            energyMax = generator.Next(4, 8);
            energyCurrent = energyMax;

            
        } 

    }
}
