using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    internal class placeholder
    {
        bool gameActive = true;

        bool beginRoom;
        bool beginRoomBed;
        bool firstHallway;

        bool secondRoom;

        bool sleutelR1;

        string beginInput;
        string beginInputBed;
        string hallwayInput;

        public void main()
        {
            Console.WriteLine("Je wordt wakker in een onbekende en vreemde kamer.");

            while (gameActive)
            {
                while (!beginRoom)
                {
                    Console.WriteLine("Je staat nu in het midden van de vreemde kamer. Wat wil je doen?");
                    Console.WriteLine("\n1. Loop naar de deur\n2. Loop naar het bed");
                    beginInput = Console.ReadLine();
                    int.TryParse(beginInput, out int input1);

                    if (input1 == 1)
                    {
                        Console.Clear();

                        if (sleutelR1)
                        {
                            Console.WriteLine("open deur");
                        }
                        else
                        {
                            Console.WriteLine("Je probeert de deur te openen, het zit op slot.\n");
                        }
                    }
                    else if (input1 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Je loopt naar het bed toe.");
                        beginRoom = true;
                        beginRoomBed = false;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }


                while (!beginRoomBed)
                {
                    Console.WriteLine("Je staat naast het bed. Wat wil je doen?");
                    Console.WriteLine("\n1. Lig op het bed\n2. Open het nachtkastje\n3. Loop terug");
                    beginInputBed = Console.ReadLine();
                    int.TryParse(beginInputBed, out int inputBed1);

                    if (inputBed1 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Je gaat liggen op het bed, je valt langzaam in slaap.");
                        //terug naar main menu
                    }
                    else if (inputBed1 == 2)
                    {
                        Console.Clear();
                        if (!sleutelR1)
                        {
                            Console.WriteLine("Je opent het nachtkastje, er zit een sleutel in. Je pakt de sleutel.\n");
                            sleutelR1 = true;
                        }
                        else
                        {
                            Console.WriteLine("Je opent het nachtkastje, er zit niks meer in\n.");
                        }
                    }
                    else if (inputBed1 == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Je loopt terug naar het midden van de kamer.");

                        beginRoom = false;
                        beginRoomBed = true;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }


                /*while (!firstHallway)
                {
                    Console.WriteLine("Je staat nu in een gang. Je ziet 4 deuren langs de muren. Wat wil je doen?");
                    Console.WriteLine("\n1. Loop terug naar de begin kamer\n2. Loop naar de eerste linker deur - deur 1" +
                        "\n3. Loop naar de eerste rechter deur - deur 2\n4. Loop naar de tweede linker deur - deur 3" +
                        "\n5. Loop naar de tweede rechter deur - deur 4");
                    hallwayInput = Console.ReadLine();
                    int.TryParse(hallwayInput, out int inputFirstHallway);

                    if (inputFirstHallway == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Je loopt terug naar de begin kamer.");
                        beginRoom = false;
                        firstHallway = true;
                    }
                    else if (inputFirstHallway == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("kamer 1.");

                    }
                    else if (inputFirstHallway == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("kamer 2.");

                    }
                    else if (inputFirstHallway == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("kamer 3.");

                    }
                    else if (inputFirstHallway == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("kamer 4.");

                    }
                    else
                    {
                        Console.Clear();
                    }
                }*/
            }


        }
    }
}
