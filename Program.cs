using System;
using System.Collections.Generic;


namespace PasswordManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string username = string.Empty;
            string password;
            bool registrerad = false;
           
            // Denna bool är ifall det användarnamn man försöker registrera redan existerar
            bool accountcheck = false;

            List<string> Usernames = new List<string>();
            List<string> passwords = new List<string>();
            bool loggedIn = false;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Välkommen till Lösenordshanteraren");
            Console.ResetColor();
            Console.WriteLine("Du kan använda sifforna 1-5 eller skriva in ordet för att komma vidare!");
            Console.WriteLine("1. Registrera");
            Console.WriteLine("2. Logga in");
            Console.WriteLine("3. Information");
            Console.WriteLine("4. Ändra användarnamn (Förkortning: ändra)");
            Console.WriteLine("5 . Avsluta");



            while (true)
            {

              input = Console.ReadLine();
                input = input.ToLower();

                   

            switch (input)
            {
                   
                    case "1":
                    case "registrera":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Skapa ett konto: ");
                        Console.ResetColor();
                    password = String.Empty;
                      
                        // Här kör vi kod för att Registrera dig!
                    
                   
                       
                    Console.WriteLine("Registrera ett användarnamn");
                     username = Console.ReadLine();

                        if (Usernames.Contains(username))
                            {
                                Console.WriteLine("Detta användarnamn är redan registrerat! Testa en gång till!");
                                   username = Console.ReadLine();
                            if (Usernames.Contains(username))
                            {
                                

                                Console.WriteLine("Detta användarnamn är redan registrerat! Testa ett nytt!");
                               username = Console.ReadLine();
                                if (Usernames.Contains(username))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Detta användarnamn existerar redan! Har redan ett konto? isåfall så kan du logga in via 2.");
                                    
                                    Console.ResetColor();
                                    accountcheck = true;
                                     if (accountcheck == true)
                                    {
                                        Console.ReadLine();

                                    }
                                }
                            }
                             
                            }
                        
                            
                    Usernames.Add(username);
                        
                    if (accountcheck == false) { 
                            Console.WriteLine("Registrera ett lösenord!");
                            password = Console.ReadLine();
                            Console.WriteLine("Du har registrerat dig!");
                            passwords.Add(password);
                       }
                    
                        
                        
                   
                        registrerad = true;
                        if (registrerad == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Du kan använda sifforna 1-5 eller skriva in ordet för att komma vidare!");
                            Console.WriteLine("1. Registrera");
                            Console.WriteLine("2. Logga in");
                            Console.WriteLine("3. Information");
                            Console.WriteLine("4. Ändra användarnamn (Förkortning: ändra)");
                            Console.WriteLine("5. Avsluta");
                        }
                    break;






               
                    

                case "2" :
                    case "logga in":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Logga in: ");
                        Console.ResetColor();
                        Console.Clear();
                        // Här kör vi kod för logga in!
                     if (Usernames.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Du har inte skapat ett konto! Du kan göra det via 1!");
                      
                            Console.WriteLine("1. Registrera");
                            Console.WriteLine("2. Logga in");
                            Console.WriteLine("3. Information");
                            Console.WriteLine("4. Ändra användarnamn (Förkortning: ändra)");
                            Console.WriteLine("5. Avsluta");
                            break;
                        }  
                        Console.WriteLine("Skriv in ditt användarnamn");
                        username = Console.ReadLine();
                    
                      

                      
                 
                     if (Usernames.Contains(username))
                        { 
                            int counter = -1;
                            foreach (string names in Usernames)
                            {
                                counter++;


                                Console.WriteLine("Användaren existerar!");
                                password = Console.ReadLine();

                                if (passwords[counter] == password)
                                {

                                    loggedIn = true;
                                }
                                else
                                {
                                   
                                    Console.WriteLine("Lösenordet stämmer inte överens med ditt användarnamn!");
                                    Console.WriteLine("Har du inget konto så kan du skapa ett via 1!");
                                    Console.ReadLine();
                                    
                                   
                                 
                                }
                                if (loggedIn == true)
                                {
                                    Console.Clear();
                                   
                                    Console.WriteLine("Du loggade in med användaren: " + username);
                                    Console.WriteLine("Välkommen till Lösenordshanteraren");
                                    Console.WriteLine("1, Registrera");
                                    Console.WriteLine("2, Logga in");
                                    Console.WriteLine("3, Information");
                                    Console.WriteLine("4. Ändra användarnamn (Förkortning: ändra)");
                                    Console.WriteLine("5,  Avsluta"); 
                                    
                                }
 
                                 else
                                 {
                                Console.WriteLine("Denna användare existerar ej! Har du inget konto? Du kan alltid skapa ett via 1!");
                                    Console.ReadLine();
                                 }
                            }
                           
                            
                    }
                    
                    break;
                    case "3":
                    case "information":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Kolla information om ditt konto!");
                        Console.ResetColor();
                        Console.WriteLine("Inloggningsstatus: ");
                        if (loggedIn == true)
                        {
                            Console.WriteLine("Inloggad");
                          
                            
                            Console.WriteLine("Användarnamn:  " + username);
                            
                        }
                        else
                        {
                            Console.WriteLine("Ej inloggad");
                            Console.WriteLine("Användarnamn ej registrerat!");
                        }
                        break;



                    case "4":
                    case "ändra":
                        Console.Clear();
                        Console.WriteLine("Ändra användarnamn!");
                        Console.WriteLine("Vill du byta användarnamn (klicka y/Ja för ja och n/nej för nej)");
                        string taBort = Console.ReadLine();
                        taBort = taBort.ToLower();
                        switch (taBort)
                        {
                            
                           
                            case "y":
                            case "ja":
                                Usernames.Remove(username);
                                Console.WriteLine("Skriv in ditt nya användarnamn här:");
                                string newusername = Console.ReadLine();
                                if (newusername == username)
                                {
                                    Console.WriteLine("Du bör byta till ett nytt namn!");
                                   
                                   
                                    
                                       
                                    
                                }
                                else
                                {
                                Usernames.Add(newusername);
                                    Console.Clear();
                                    Console.WriteLine("Du har bytt användarnamn från " + username +  " till " + newusername);
                                    Console.WriteLine("1, Registrera");
                                    Console.WriteLine("2, Logga in");
                                    Console.WriteLine("3, Information");
                                    Console.WriteLine("4,  Avsluta");
                                    
                                }
                                break;
                        }
                        break;
                   

                        
                    case "5":
                    case "avsluta":
                    return;
                   
                 }
            }
        }
    }
}

