using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class World
    {
        // Skapa spelare från klassen "Player". t.ex. Player kalle = new Player("Kalle", osv);

        public static void RoomSetup() //Spelbanan 
        {
            Room utanförHuset = new Room() { roomName = "Vid Ytterdörren", roomNumber=0, roomDescription = "Du är utanför huset" };
            Room köket = new Room() { roomName = "Köket", roomNumber = 1, roomDescription = "Det är köket" };
            Room vardagsrummet = new Room() { roomName = "Vardagsrummet", roomNumber = 2, roomDescription = "Du är i sovrummet" };
            Room toaletten = new Room() { roomName = "Toaletten", roomNumber = 3, roomDescription = "Det här toaletten" };
            Room sovrummet = new Room() { roomName = "Sovrummet", roomNumber = 4, roomDescription = "Du är i sovrummet" };
            Room källaren = new Room() { roomName = "Källaren", roomNumber = 5, roomDescription = "Det här Källaren" };
            Room valvet = new Room() { roomName = "Valvet", roomNumber = 6, roomDescription = "Det här KassaValvet. Du är RIK" };


            //Spelbanan som man ska gå igenom för att klara spelet. Vi får lägga till felgrejerna sen. Tex om man ska dö i ett rum etc etc

            utanförHuset.exits.Add(Direction.North, köket); //Gå till köket
            köket.exits.Add(Direction.South, utanförHuset);//Gå tillbaka till Hall

            köket.exits.Add(Direction.West, vardagsrummet);//Gå till vardagsrum
            vardagsrummet.exits.Add(Direction.East, köket);//Gå tillbaka till köket

            vardagsrummet.exits.Add(Direction.North, toaletten);//till Toaletten
            toaletten.exits.Add(Direction.South, vardagsrummet);//Tillbaka till vardagsrummet

            toaletten.exits.Add(Direction.North, sovrummet);//Tillsovrummet
            sovrummet.exits.Add(Direction.South, toaletten);//Tillbaka till Toalett

            sovrummet.exits.Add(Direction.North, källaren);//Tillkällaren
            källaren.exits.Add(Direction.South, sovrummet);//Tillbaka till sovrummet

            källaren.exits.Add(Direction.West, valvet);//Klarat spelet om man kommer in

            //return hall;//? Metoden ska retunera position
        }

        public static void ItemsSetup()
        {
            //För att ta sig in i Husets 1a rum : köket
            Items kitchenKey = new Items { itemName = "Key", itemDescripton = "Key for Use", keyNumberForDoorNumber = 2 };

            Items krukaFör1Nyckel = new Items { itemName = "Stor Blom Kruka", itemDescripton = "Kruka med fina blommor i" };
           
            
            //För att kunna ta dig in i kassavalvet och för att klara spelet
            Items keyforKista = new Items { itemName = "BigKey", itemDescripton = "Another Key", keyNumberForDoorNumber = 7 };
            //Spöket hittar vi i toaletten. Ex, använder man inte toaletten och skrämmer iväg spöket med ljuden så dör man och kan inte ta sig vidare
            Items spöket = new Items { itemName = "MödarSpöket", itemDescripton = "Oh no, spöket vill ta dig!"};

            //KrimsKrams items som man ska kunna plocka upp bara för att ha ngt att göra i spelet
            Items vattenpistol = new Items { itemName = "VattenPistol", itemDescripton = "Vem vet när du behöver denna" };
        }

        // sedan kommer det behöva mer kod för att lägga till t.ex. items till respektive rum

        /**************************************************************************/

        // public void Play () // Metod för att spela

        // Start "gameloop". En while loop t.ex.

        // 1. Använd en rumspekare typ currentroom = t.ex. Hall som skapades tidigare
        // 2. Skriv ut kommandoprompt typ >
        // 3. Läs in kommando från spelaren med string command = Console.ReadLine();
        // 4. Kod för att tolka kommandot och utföra. t.ex "go west", "take key" etc.
        // 5. samt kontrollera att det är ett alternativ man kan göra i det rummet man är i.
        // 6. annars ska man få ett felmeddelande och gå tillbaka till början av loopen.
        // 7. 





    }
}
