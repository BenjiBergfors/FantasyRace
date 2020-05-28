using System;
using System.Collections.Generic;
using System.IO;
namespace FantasyRace
{
    class Program
    {
        

        static void Main(string[] args)
        {

            Animal a = new Animal();
            Random generator = new Random();
            int antalDjur;


            List<Animal> animaltypes = new List<Animal>() {}; //En lista på djuren som kan genereras i spelet

            

            Console.WriteLine("Hur många djur vill du ha?");
            
            antalDjur = Convert.ToInt32(Console.ReadLine()); 
            while (antalDjur > 0)
            {
                int animalNumber = generator.Next(0,2); //Genererar mellan de två typerna 0 = Teddybear och 1 = Unicorn
                
                Unicorn u = new Unicorn(); //Skapar en ny instans av Unicorn som innehåller alla unika variabler från en Unicorn
                Teddybear t = new Teddybear(); ////Skapar en ny instans av Teddybear som innehåller alla unika variabler från en Teddybear

                if (animalNumber == 0) // Om animaltype är Unicorn så kommer Unicorns stats skrivas ut som de nedanstående Console.Writlinerna
                {
                    Console.WriteLine("Unicorn");
                    Console.WriteLine("Speed = " + u.speed);
                    Console.WriteLine("Position = " +  u.position);
                    Console.WriteLine("Energy = " + u.energyCurrent + "/" + u.energyMax);
                    Console.WriteLine("-------------------------");
                    animaltypes.Add(new Unicorn());

                }
                if (animalNumber == 1) // Om animaltype är Teddybear så kommer Unicorns stats skrivas ut som de nedanstående Console.Writlinerna
                {
                    Console.WriteLine("Teddybear");
                    Console.WriteLine("Position = " + t.position);
                    Console.WriteLine("Speed = " + t.speed);
                    Console.WriteLine("Energy = " + t.energyCurrent + "/" + t.energyMax);
                    Console.WriteLine("-------------------------");
                    animaltypes.Add(new Teddybear());
                }
                //
               
                antalDjur -= 1; //Gör så att Whileloopen inte fortsätter i all oändlighet
            }
            
            
            Console.ReadLine();
        }
    }
}
