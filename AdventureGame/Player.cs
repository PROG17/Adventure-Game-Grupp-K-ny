using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player
    {
        public string Name { get; set; }
        public List<Items> IventoryList { get; set; } //Hur ska man göra en hel lista utav detta.
        public bool IsAlive { get; set; }
        public object PlayerLocation { get; set; } //Vart playser ska befinna sig

        public object Go() // Får att gå, inkomplett
        {

        }

        public List<> PickUp() //Ska ta upp Items
        {

        }

        public List<> Drope()//Ska släppa items
        {


        }

        public bool Open() //Ska kunna använda nycklas som finns i lista för att öppna dörr
        {

        }

        public bool Die() //Ska döda karaktär
        {
            return IsAlive = false;
        }
    }
}
