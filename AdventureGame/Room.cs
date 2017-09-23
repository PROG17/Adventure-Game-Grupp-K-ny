using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    enum Direction
    {
        North,
        South,
        West,
        East,
    }

    class Room
    {
        public string roomName { get; set; }
        public int roomNumber { get; set; }
        public string roomDescription { get; set; }
        public Dictionary<Direction, Room> exits = new Dictionary<Direction, Room>();

        public List<Items> InventoryListForRoom { get; set; } //Behöver lägga till Items.




        // Properties
        // - Description (text about room), public string description;
        // - Room name, public string roomname;
        // - Inventory of items (public List<Items> Inventory { get; set; } 
        // - Exits (vilken riktning dom har och vilket rum dom leder till)
        //   public Dictionary<Direction, Room> exits = new Dictionary<Direction, Room>();

        // Methods
        // 
        // PrintDescription (Print description of room, number and direction of exits, items in room etc.)




    }
}
