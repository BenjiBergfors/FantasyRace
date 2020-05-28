using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyRace
{
    class Animal
    {
        


        public int speed; //variabel för speed
        public int position; //variabel för position
        public int energyCurrent; //variabel för energyCurrent
        public int energyMax; //variabel för energyMax

      

        static Random Randomizer() //En metod som gör att man kan generera tal
        {
            Random generator = new Random();
            return generator;
        }
           
          
        

    }
    
}
    


