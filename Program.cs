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


            List<string> types = new List<string>() { "Teddybear", "Unicorn" };


            Console.WriteLine("Hur många djur vill du ha?");
            
            antalDjur = Convert.ToInt32(Console.ReadLine());
            while (antalDjur > 0)
            {
                int animalNumber = generator.Next(0,2);
                string type = types[animalNumber];
                Unicorn u = new Unicorn();
                Teddybear t = new Teddybear();
                //Console.WriteLine(type);
                if (type == "Unicorn")
                {
                    Console.WriteLine("Unicorn");
                    Console.WriteLine("Speed = " + u.speed);
                    Console.WriteLine("Position = " +  u.position);
                    Console.WriteLine("Energy = " + u.energyCurrent + "/" + u.energyMax);
                    Console.WriteLine("-------------------------");
                }
                if (type == "Teddybear")
                {
                    Console.WriteLine("Teddybear");
                    Console.WriteLine("Position = " + t.position);
                    Console.WriteLine("Speed = " + t.speed);
                    Console.WriteLine("Energy = " + t.energyCurrent + "/" + t.energyMax);
                    Console.WriteLine("-------------------------");
                }
                //

                antalDjur -= 1;
            }
            Console.ReadLine();
        }
    }
}
