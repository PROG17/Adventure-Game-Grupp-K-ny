using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Door
    {
        public string DoorName { get; set; }
        public int DoorNumber { get; set; } //För att kunna jämföra vilka nycklar man har.
        public bool DoorIsClosed { get; set; }

        //Här finns dörrar mellan rummen.
        //Vissa dörrar är öppna. 
        //Vissa dörrar behöver nycklar från klass item för att öppns.


    }
}
