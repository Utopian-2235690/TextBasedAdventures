using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    internal class AllRooms
    {
        public void Rooms()
        {
            FirstRoom first = new FirstRoom();
            SecondRoom second = new SecondRoom();
            Library library = new Library();

            first.StartRoom();
            second.StartRoom();
            library.StartRoom();

        }
    }
}
