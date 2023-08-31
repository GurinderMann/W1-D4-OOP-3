using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Login
    {
        bool loggedIn = false;
        public static List<LoginList> list = new List<LoginList>();
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("===============OPERAZIONI==============");
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("1.: Login");
                Console.WriteLine("2.: Logout");
                Console.WriteLine("3.: Verifica ora e data di login");
                Console.WriteLine("4.: Lista degli accessi");
                Console.WriteLine("5.: Esci");
                Console.WriteLine("========================================");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    if (loggedIn ==false)
                    {
                   
                        Console.Write("Nuovo username: ");
                        string newUsername = Console.ReadLine();
                        Console.Write("Nuova password: ");
                        string newPassword = Password.ReadPassword();
                        Console.WriteLine();
                        Console.Write("Conferma nuova password: ");

                        string confirmPassword = Password.ReadPassword();
                        Console.WriteLine();

                        if (newPassword.Length >= 7) 
                        {
                       
                        if (newPassword == confirmPassword)
                        {
                            User.UserName = newUsername;
                            User.Password = newPassword;
                            Console.WriteLine("Account creato con successo.");
                            loggedIn = true;
                            list.Add(new LoginList(newUsername, DateTime.Now));
                        }
                        else
                        {
                            Console.WriteLine("Le password non coincidono. Creazione account fallita.");
                        }
                        } 
                        else  
                        {
                            Console.WriteLine("La password deve contenere almeno 8 caratteri. Creazione account fallita. ");
                        }
                    }
                   
                }
                else if (choice == "2")
                {
                    if (loggedIn)
                    {
                       
                        loggedIn = false;
                        Console.WriteLine("Logout effettuato con successo.");
                    
                    }
                    else
                    {
                        Console.WriteLine("Nessun utente loggato.");
                    }
                }
                else if (choice == "3")
                {
                    if (loggedIn)
                    {
                        if (list.Count > 0)
                        {
                            var lastLogin = list[list.Count - 1];
                            Console.WriteLine("Account creato da " + lastLogin.UserName + " il  " + lastLogin.AccessTime);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nessun utente loggato.");
                    }
                }
                else if (choice == "4")
                {
                    if (list.Count > 0)
                    {
                        Console.WriteLine("Storico degli accessi");
                        foreach (var loginItem in list)
                        {
                            Console.WriteLine(loginItem.UserName + " - " + loginItem.AccessTime);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nessun utente loggato.");
                    }
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Uscendo dall'applicazione...");
                    return;
                }
                else
                {
                    Console.WriteLine("Scelta non valida.");
                }
            }
                    
                    
        }
    }

}
    

