using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    internal class FirstRoom : Room
    {
        public override void StartRoom()
        {
            bool loop = true;
            bool key = false;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Je wordt wakker op een bed in een vreemde kamer. Je staat op, wat doe je?");
                Console.WriteLine("\n1. Loop naar de deur");
                Console.WriteLine("2. Open het nachtkastje");
                Console.WriteLine("3. Examineer de boekenkast");
                Console.WriteLine(" ");

                string actionInput = Console.ReadLine();

                int.TryParse(actionInput, out int answer);

                if (answer == 1)
                {
                    Console.Clear();

                    Console.WriteLine("Je loopt naar de deur en probeert het te openen.");
                    if (!key)
                    {
                        Console.WriteLine("De deur zit op slot en gaat niet open.");
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                    }
                    else
                    {
                        loop = false;
                    }
                }
                else if (answer == 2)
                {
                    Console.Clear();

                    Console.WriteLine("Je opent het nachtkastje.");
                    if (!key)
                    {
                        Console.WriteLine("Er zit een sleutel in het nachtkastje, je pakt de sleutel.");
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                        key = true;
                    }
                    else
                    {
                        Console.WriteLine("Er zit niks meer in het nachtkastje.");
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                    }
                }
                else if (answer == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Je loopt naar de boekenkast, het zit vol met boeken. Het is een normale boekenkast.");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                }


            }
        }


    }
}
