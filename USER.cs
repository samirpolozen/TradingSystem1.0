namespace app; // skapar namespace app som kommer att kopplas till program.cs

class User // skapar en User klass som innehåller metoder för olika funktioner 
{
      public string Email;
      public string Password;

      //Skapar en konstruktor för klass User
      // När vi skapar ett User objekt skickar vi parametrarna email och password 
      public User(string email, string password)
      {
            Email = email; // Tilldelar värdet email
            Password = password; // Tilldelar password värdet
      }
}

// Skapar en UserService klass med metoder
class UserService
{
      // Samma fil delas av alla User objekt med hjälp av statisk.
      // Endast klassen själv kan använda den.
      // Tilldelar filnamnet users.txt
      static string UserFile = "users.txt";
      // Skapar en lista som innehåller alla användare i systemet 
      // Static gör att listan delas av hela klassen, inte av enskilda User instanser
      public static List<User> Users = new List<User>();
      // Statisk variabel som sparar den inloggade användaren
      //När ingen är inloggad är värdet null
      public static User currentuser = null;
      // Skapar en "users.txt" fil om den redan inte finns 
      // Laddar in användare från filen 
      // Start() initierar användarsystemet 
      public static void Start()
      {
            if (File.Exists(UserFile))
            {
                  File.WriteAllText(UserFile, "");
            }
      }
      // skapa en LoadUsers() som kommer att ladda upp alla Users i "users.txt"
      static void LoadUsers()
      {
            if (!File.Exists(UserFile)) // Finns filen?
            {
                  return; // Avsluta metoden direkt om den inte finns
            }

            string[] lines = File.ReadAllLines(UserFile); // Läser in alla rader från filen till en array
            foreach (string n in lines) // Här loopar vi igenom varje rad i file "users.txt"
            {
                  string[] parts = n.Split('-'); // Delar upp raden i två delar: Email och Password
                  if (parts.Length == 2) // Checkar att raden innehåller exakt 2 delar
                  {
                        User u = new User(parts[0], parts[1]); // Här skapar vi en nu User med email och lösenord 
                        Users.Add(u); // Lägger till User i listan med alla Users
                  }

            }
      }


}