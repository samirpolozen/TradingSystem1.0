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

}