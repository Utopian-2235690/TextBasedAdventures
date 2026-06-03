using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    internal class SecondRoom : Room
    {
        public override void StartRoom()
        {
            Console.Clear();
            Console.WriteLine("Je gebruikt de sleutel en opent de deur.");
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();

            bool loop = true;
            bool kamer2A = true;
            bool kamer3A = true;
            bool wallOpen = false;
            Choices choices = new Choices();

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Je staat in een lange gang. Er zijn deuren aan beide kanten, wat doe je?");
                Console.WriteLine("\n1. Loop naar eerste linker deur");
                Console.WriteLine("2. Loop naar tweede linker deur");
                Console.WriteLine("\n3. Loop naar eerste rechter deur");
                Console.WriteLine("4. Loop naar tweede rechter deur");
                Console.WriteLine(" ");

                string actionInput = Console.ReadLine();

                int.TryParse(actionInput, out int answer);

                if (answer == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Je loopt naar de deur en probeert het te openen, het zit op slot.");


                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                }
                else if (answer == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Je opent de deur en loopt de kamer binnen, de deur sluit achter je.");

                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();

                    while (kamer2A)
                    {
                        Console.Clear();
                        Console.WriteLine("Je staat in het midden van de kamer, wat doe je?");
                        Console.WriteLine("\n1. Examineer de douchecabine");
                        Console.WriteLine(" ");

                        string actionInput2 = Console.ReadLine();

                        int.TryParse(actionInput2, out int answer2);

                        if (answer2 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Je loopt naar de douchecabine en stapt erin. Voordat je door hebt wat er gebeurt, val je door de grond heen." +
                                "\n Je valt rechtstreeks in lava.");
                            Console.WriteLine("Je bent dood.");

                            Console.WriteLine("\nPress any key...");
                            Console.ReadKey();

                            Console.Clear();
                            choices.Main();
                        }
                    }


                }
                else if (answer == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Je opent de deur en loopt de kamer binnen, de deur sluit achter je.");

                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();

                    while (kamer3A)
                    {
                        Console.Clear();
                        Console.WriteLine("Je staat in het midden van de kamer, wat doe je?");
                        Console.WriteLine("\n1. Examineer de toilet");
                        Console.WriteLine("2. Examineer de boekenkast");
                        if (wallOpen)
                        {
                            Console.WriteLine("3. Loop naar het gat in de muur");
                        }
                        Console.WriteLine(" ");

                        string actionInput3 = Console.ReadLine();

                        int.TryParse(actionInput3, out int answer3);

                        if (answer3 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Je loopt naar de toilet, het water en de toilet zelf zijn beide smerig.");
                            Console.WriteLine("\nPress any key...");
                            Console.ReadKey();
                        }
                        else if (answer3 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Je loopt naar de boekenkast, het zit vol met boeken. Er hangt een boek uit de boekenkast," +
                                "\nje duwt het terug naar achter en je hoort een vreemd geluid..");
                            Console.WriteLine("\nPress any key...");
                            Console.ReadKey();
                            wallOpen = true;
                        }
                        else if (answer3 == 3 && wallOpen)
                        {
                            Console.Clear();
                            kamer3A = false;
                            loop = false;
                        }
                    }


                }
                else if (answer == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Je loopt naar de deur en probeert het te openen, het zit op slot.");

                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                }


            }
        }
    }
}
