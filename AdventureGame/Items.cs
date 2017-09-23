using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Items
    {
        public string itemName { get; set; }
        public string itemDescripton { get; set; }
        public int keyNumberForDoorNumber { get; set; } //Ska bestå av number för varje rum

        //public List<Room> BelongsIn { get; set; } //För att få items till rumbehörighet. 


        // här ska det finnas items: 

        //nycklar till dörrar - Får sifferNamn
        //nycklar till pengarvalvet
        //Spöket - som dödar dig
        //Toalett

        //Krimskrams man inte behöver i spelet egentligen
        // Fyll på med Items när vi vet resten av historien...

    }
}
