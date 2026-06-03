using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    internal class Choices
    {
        public void Main()
        {
            AllRooms rooms = new AllRooms();

            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("1 = Start game");
                Console.WriteLine("2 = Exit game");
                Console.WriteLine(" ");

                string input = Console.ReadLine();
                int.TryParse(input, out int choice);


                if (choice == 1)
                {
                    Console.Clear();
                    rooms.Rooms();
                }
                else if (choice == 2)
                {
                    Environment.Exit(1);
                }
            }
            
        }
    }
}
