using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Player
    {
        public string Name { get; set; }
        public List<Items> IventoryList { get; set; } //Hur ska man göra en hel lista utav detta.
        public bool IsAlive { get; set; }
        

        //Konstruktur För att få spelarenamn. Start för Spelet
        public Player(string name)
        {
            Name = this.Name;            

            Console.WriteLine("Välkommen " + Name);
            Console.WriteLine("nDitt uppdrag är att hitta den värdefulla skattkistan" +
               "+ med livet i behåll. Leta efter nycklar för att kunna ta dig runt i huset och slutligen till skattkistan");
            Console.WriteLine("Tryck Enter för att stara spelet");
            Console.ReadLine();

            Console.Clear();

            //Ska även passa med en lista som innehåller ngt till att börja med? 
        }

        //public object Go() // Får att gå, inkomplett
        //{
            
        //}

        //public List<Items> PickUp() //Ska ta upp Items
        //{
        //    Items.
        //}

        //public List<Items> Drope()//Ska släppa items
        //{


        //}

        //public bool Open() //Ska kunna använda nycklas som finns i lista för att öppna dörr
        //{

        //}

        public bool Die() //Ska döda karaktär
        {
            return IsAlive = false;
        }
    }
}
