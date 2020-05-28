using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyRace
{
    class Teddybear : Animal
    {
        public Teddybear()
        {
        


            Random generator = new Random();
            // Teddybear stats
            speed = generator.Next(1, 5); 
            position = 0;
            energyMax = generator.Next(7, 11);
            energyCurrent = energyMax; 
        }
        
       
    }


}
