using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    internal class Library : Room
    {
        private int _injuredLevel;

        public override void StartRoom()
        {
            Choices choices = new Choices();
            bool loop = true;
            bool key = false;
            bool boek = false;
            bool trapRightBK = true;
            bool escapeLeftBK = false;
            while (loop)
            {
                Console.Clear();
                //STATUS SYSTEEM

                string status = "nun";
                string currentRoom = "Grote bibliotheek";

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

                Console.WriteLine("Je staat in een lange bibliotheek. Er zijn boekenkasten overal, wat doe je?");

                Console.WriteLine("\n1. Loop naar de balie");
                Console.WriteLine("2. Loop naar de linker boekenkasten");
                Console.WriteLine("3. Loop naar de rechter boekenkasten");
                Console.WriteLine("4. Ga naar de tweede verdieping van de bibliotheek met de spiraaltrap\n");

                string actionInput = Console.ReadLine();

                int.TryParse(actionInput, out int answer);

                if (answer == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Je loopt naar de balie.");

                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();

                    Console.Clear();
                    Console.WriteLine("Je staat voor de balie, wat doe je?");

                    Console.WriteLine("\n1. Druk op de baliebel");
                    Console.WriteLine("2. Loop achter de balie\n");

                    string actionInput2 = Console.ReadLine();

                    int.TryParse(actionInput2, out int answer2);

                    if (answer2 == 1)
                    {
                        //ESCAPE 3 Path
                        Console.Clear();
                        Console.WriteLine("Je klikt op de baliebel, de linker boekenkasten schuiven naar voren en het onthult een geheime passage.");
                        escapeLeftBK = true;
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                    }
                    else if (answer2 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Je loopt achter de balie...");

                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();

                        Console.Clear();
                        Console.WriteLine("Je staat achter de balie, wat doe je?");

                        Console.WriteLine("\n1. Open de deur achter de balie");
                        Console.WriteLine("2. Kijk onder de balie\n");

                        string actionInput3 = Console.ReadLine();

                        int.TryParse(actionInput3, out int answer3);

                        if (answer3 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Je probeert de deur te openen...");
                            Console.WriteLine("\nPress any key...");
                            Console.ReadKey();

                            if (!key)
                            {
                                Console.Clear();
                                Console.WriteLine("De deur zit op slot, je hebt een sleutel nodig.");
                                Console.WriteLine("\nPress any key...");
                                Console.ReadKey();
                            }
                            else
                            {
                                //ESCAPE 2

                                Console.Clear();
                                Console.WriteLine("Je gebruikt de sleutel en opent de deur.");
                                Console.WriteLine("\nPress any key...");
                                Console.ReadKey();

                                Console.Clear();
                                Console.WriteLine("Je bevindt jezelf in een schuur, je loopt naar buiten en bevindt jezelf" +
                                    "in een weiland! Je bent ontsnapt.\n");
                                Console.WriteLine("Je hebt gewonnen!");

                                Console.WriteLine("\nPress any key...");
                                Console.ReadKey();

                                choices.Main();
                                loop = false;
                            }
                        }
                        else if (answer3 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Je kijkt onder de balie...");
                            Console.WriteLine("\nPress any key...");
                            Console.ReadKey();

                            if (!key)
                            {
                                Console.Clear();
                                Console.WriteLine("Er zit een sleutel vastgeplakt met plakband onder de balie," +
                                    " je trekt de plakband weg en neemt de sleutel.");
                                Console.WriteLine("\nPress any key...");
                                Console.ReadKey();

                                key = true;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Er zit niks meer onder de balie.");
                                Console.WriteLine("\nPress any key...");
                                Console.ReadKey();
                            }
                        }
                    }

                }
                else if (answer == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Je loopt naar de linker boekenkast.");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();


                    if (boek)
                    {
                        Console.WriteLine("Je staat voor de boekenkast, er hangt een boek uit de boekenkast. Wat doe je?");
                    }
                    else if (!boek)
                    {
                        Console.WriteLine("Je staat voor de boekenkast. Wat doe je?");
                    }

                    if (boek)
                    {
                        Console.WriteLine("\n1. Trek het boek uit de boekenkast.\n");

                        string actionInput4 = Console.ReadLine();

                        int.TryParse(actionInput4, out int answer4);

                        if (answer4 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("\n1. Je trekt het boek uit de boekenkast, er gebeurt niks.");
                            boek = true;
                        }
                    }
                    else if (escapeLeftBK)
                    {
                        Console.WriteLine("Je staat voor de boekenkast, het is naar voren geschoven en er is een gang achter de boekenkast");
                        Console.WriteLine("\n1. Loop door de gang.\n");

                        string actionEscape = Console.ReadLine();

                        int.TryParse(actionEscape, out int escape);

                        if (escape == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Je loopt door de gang heen..");
                            Console.WriteLine("Er is een deur aan het einde van de gang.");
                            Console.WriteLine("Je opent de deur en bevindt jezelf in een huis, je kan door een raam een weiland zien.\n");
                            Console.WriteLine("Je bent ontsnapt, je hebt gewonnen!");

                            Console.WriteLine("\nPress any key...");
                            Console.ReadKey();
                            choices.Main();
                        }
                    }
                }
                else if (answer == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Je loopt naar de rechter boekenkast.");

                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();

                    if (trapRightBK)
                    {
                        //if statement om je te injuren
                        Console.Clear();
                        Console.WriteLine("Zodra je dichtbij komt valt er opeens een boek uit de boekenkast recht op je hoofd!\n(1+ Damage)");
                        _injuredLevel++;
                        trapRightBK = false;

                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                    }

                    Console.Clear();
                    Console.WriteLine("Je inspecteert de boekenkast alleen om er achter te komen dat het een normale boekenkast is.");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();

                }
                else if (answer == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Je loopt op de spiraaltrap..");

                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("De hele boven verdieping is leeg, er zijn geen boeken meer.");

                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                }
            }

        }

    }
}
