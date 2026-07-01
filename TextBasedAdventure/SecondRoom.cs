using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    internal class SecondRoom : Room
    {
        private int _injuredLevel = 0;


        public override void StartRoom()
        {
            bool loop = true;
            bool kamer2A = true;
            bool kamer3A = true;
            bool kamer4A = true;
            bool wallOpen = false;
            bool steen = false;
            int boomDurability = 4;
            bool boomDur = false;
            Choices choices = new Choices();

            while (loop)
            {
                Console.Clear();
                //STATUS SYSTEEM

                string status = "nun";
                string currentRoom = "Gang";

                if (_injuredLevel == 0)
                {
                    status = "Healthy";
                }
                else if (_injuredLevel == 1)
                {
                    status = "Slightly injured";
                }
                else if (_injuredLevel == 2)
                {
                    status = "Heavily injured";
                }

                Console.WriteLine("----- Stats -----");
                Console.WriteLine($"Status: {status}");
                Console.WriteLine($"Room: {currentRoom}\n");

                Console.WriteLine("Je staat in een lange gang. Er zijn deuren aan beide kanten, wat doe je?");
                Console.WriteLine("\n1. Loop naar eerste linker deur");
                Console.WriteLine("2. Loop naar tweede linker deur");
                Console.WriteLine("\n3. Loop naar eerste rechter deur");
                Console.WriteLine("4. Loop naar tweede rechter deur\n");

                string actionInput = Console.ReadLine();

                int.TryParse(actionInput, out int answer);

                /*
                kamer 1: ln 38 - Locked/Geen path
                kamer 2: ln 53 - Death
                kamer 3: ln 89 - Library path
                kamer 4: ln 143 - Kamer met boom/escape 1
                */

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
                            Console.WriteLine("Je loopt naar de toilet, het water en de toilet zien er zijn beide smerig.");
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
                            Console.WriteLine("Je staat voor het gat in de muur, wat doe je?");
                            Console.WriteLine("\n1. Kruip door het gat");
                            Console.WriteLine("2. Ga terug\n");

                            string actionInputWall = Console.ReadLine();

                            int.TryParse(actionInputWall, out int answerWall);

                            if (answerWall == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Je kruipt door het gat..");
                                Console.WriteLine("\nPress any key...");
                                Console.ReadKey();
                                kamer3A = false;
                                loop = false;
                            }
                            
                        }
                    }


                }
                else if (answer == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Je opent de deur en loopt de kamer binnen, de deur sluit achter je.");

                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();

                    while (kamer4A)
                    {
                        Console.Clear();
                        //STATUS SYSTEEM

                        status = "nun";
                        currentRoom = "Gang";

                        if (_injuredLevel == 0)
                        {
                            status = "Healthy";
                        }
                        else if (_injuredLevel == 1)
                        {
                            status = "Slightly injured";
                        }
                        else if (_injuredLevel == 2)
                        {
                            status = "Heavily injured";
                        }

                        Console.WriteLine("----- Stats -----");
                        Console.WriteLine($"Status: {status}");
                        Console.WriteLine($"Room: {currentRoom}\n");

                        Console.WriteLine("Je staat voor een grote boom in het midden van een verticaal lange kamer, " +
                            "\n er zitten kiezelstenen overal op de vloer, wat doe je?");
                        if (steen)
                        {
                            Console.WriteLine("\n(Je houdt een kiezelsteen vast)");
                        }
                        Console.WriteLine("\n1. Examineer de boom");
                        Console.WriteLine("2. Examineer de gebroken muur");
                        if (!steen)
                        {
                            Console.WriteLine("3. Pak een kiezelsteen op");
                        }
                        
                        if (steen)
                        {
                            Console.WriteLine("4. Gooi een kiezelsteen naar de boom");
                        }

                        if (boomDur)
                        {
                            Console.WriteLine("5. Loop naar de uit elkaar gevallen muur");
                        }

                        Console.WriteLine(" ");

                        string actionInput4 = Console.ReadLine();

                        int.TryParse(actionInput4, out int answer4);


                        if (answer4 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Je raakt de stam van de boom aan, de boom is tenminste 6 meter lang, er is een raam boven de boom, " +
                                "maanlicht schijnt er doorheen.");
                            Console.WriteLine("\nPress any key...");
                            Console.ReadKey();
                        }
                        else if (answer4 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Je loopt naar een muur met een gat erin. Je kan een bibliotheek zien aan de andere kant, " +
                                "\nhet gat is te klein om er doorheen te kruipen.");
                            Console.WriteLine("\nPress any key...");
                            Console.ReadKey();
                        }
                        //if statements om te checken of je een kiezelsteen hebt en hoeveel je gegooit hebt
                        else if (answer4 == 3 && !steen)
                        {
                            Console.Clear();
                            Console.WriteLine("Je pakt een kiezelsteen op van de grond.");
                            Console.WriteLine("\nPress any key...");
                            Console.ReadKey();
                            steen = true;
                        }
                        else if (answer4 == 4 && steen)
                        {
                            Console.Clear();
                            Console.WriteLine("Je gooit de kiezelsteen tegen de stam van de boom aan.");
                            if (boomDurability == 4)
                            {
                                Console.WriteLine("Je hoort een slot open gaan, misschien gaat er iets open als je nog een steen gooit..");
                                steen = false;
                            }
                            else if (boomDurability == 3)
                            {
                                Console.WriteLine("Je hoort een tweede slot open gaan, probeer nog een steen te gooien..");
                                steen = false;
                            }
                            else if (boomDurability == 2)
                            {
                                Console.WriteLine("Je hoort een derde slot open gaan, een muur valt opeens uit elkaar..");
                                steen = false;
                                boomDur = true;
                            }
                            else if(boomDurability == 1)
                            {
                                //if statement om je te injuren als je vier kiezelstenen gooit

                                Console.WriteLine("De steen weerkaatst terug en raakt je op je voorhoofd.\n(1+ Damage)");
                                _injuredLevel++;
                                steen = false;
                            }
                            else if (boomDurability < 1)
                            {
                                Console.WriteLine("Er gebeurt niks..");
                                steen = false;
                            }
                            Console.WriteLine("\nPress any key...");
                            Console.ReadKey();
                            boomDurability--;
                            steen = false;
                        }
                        else if (answer4 == 5 && boomDur)
                        {
                            Console.Clear();
                            Console.WriteLine("Je loopt naar de muur die net uit elkaar viel, wil je door het gat in de muur kruipen?");
                            Console.WriteLine("\n1. Kruip door het gat");
                            Console.WriteLine("2. Ga terug");

                            string actionInput5 = Console.ReadLine();

                            int.TryParse(actionInput5, out int answer5);

                            if (answer5 == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Je kruipt door het gat..");
                                Console.WriteLine("Je bevindt jezelf in een weiland! Je bent ontsnapt.\n");
                                Console.WriteLine("Je hebt gewonnen!");

                                Console.WriteLine("\nPress any key...");
                                Console.ReadKey();

                                choices.Main();
                                kamer4A = false;
                                loop = false;
                            }
                                
                        }
                    }
                }

            }
        }

    }
}
