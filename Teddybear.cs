using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyRace
{
    class Teddybear : Animal
    {
        public Teddybear()
        {
        //int speed = 0;
        //int position = 0;
        //int energyCurrent = 0;
        //int energyMax = 0;


            Random generator = new Random();
            
            speed = generator.Next(1, 5);
            position = 0;
            energyMax = generator.Next(7, 11);
            energyCurrent = energyMax; 
        }
        
       
    }


}
