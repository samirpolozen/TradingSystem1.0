// See https://aka.ms/new-console-template for more information
using app; // Kopplar User.cs till Main


// Skapar en meny
// Endast kunna registerar, logga in och avsluta loopen
bool running = true;

while (running)
{
      Console.WriteLine("----HUVUD MENY---");
      Console.WriteLine("-----------------");
      Console.WriteLine("1. Registrera");
      Console.WriteLine("2. Logga in");
      Console.WriteLine("3. Avsluta");
      string input = Console.ReadLine();
      
      // Kommer använda mig av switch input för tycker det är smidigast 
      switch (input)
      {
            case "1":

                  break;
            case "2":

                  {

                  }
                  break;
            case "3":
                  running = false;
                  break;


      }
      

}
