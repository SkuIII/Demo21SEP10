using System;
using System.Collections.Generic;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> myCustomers = new List<Customer>(); // Skapa customerlistan

            while (true) // Programmet körs
            {
                Console.WriteLine("Välj vad du vill göra med hjälp av alternativen nedan:\n" +
                                  "1 (Skapa ny kund)\n" +
                                  "2 (Visa antal kunder)\n" +
                                  "3 (Visa lista över alla kunder)\n" +
                                  "4 (Avsluta)");
                string alternativ = Console.ReadLine();

                if (alternativ == "1") // Skapa kund
                {
                    Console.WriteLine("Mata in kundens namn:");
                    string customerName = Console.ReadLine();
                    Console.WriteLine("Mata in kundens adress:");
                    string customerAdress = Console.ReadLine();
                    Console.WriteLine("Mata in kundens nummer:");
                    string customerNumber = Console.ReadLine();

                    // Lägg till kunden i listan
                    myCustomers.Add(new Customer() { Name = customerName, Adress = customerAdress, Number = customerNumber });

                    Console.Clear(); // Ta bort allting från consolen, blir väldigt rörigt annars
                    Console.WriteLine($"Ny kund \"{customerName}\" har skapats!");
                }

                if (alternativ == "2") // Visa antal kunder
                {
                    Console.Clear();
                    Console.WriteLine($"Det finns just nu {myCustomers.Count} kunder i systemet, " +
                                       "för att se en lista över alla kunder välj alternativ 3.");
                }

                if (alternativ == "3") // Visa lista över alla kunder
                {
                    Console.Clear();

                    // Loopa genom listan och mata ut all information om varje Customer
                    foreach (Customer c in myCustomers)
                    {
                        Console.WriteLine($"Namn: {c.Name}\n" +
                                          $"Adress: {c.Adress}\n" +
                                          $"Nummer: {c.Number}\n");
                    }
                }

                if (alternativ == "4") // Avsluta
                {
                    break; // Avsluta loopen
                }

                // Om input inte är ett av alternativen påpeka det så personen som matar in förstår vad som behövs göras
                if (alternativ != "1" && alternativ != "2" && alternativ != "3" && alternativ != "4")
                {
                    Console.Clear();
                    Console.WriteLine("Du måste skriva ett av alternativen 1, 2, 3 eller 4!");
                }

                // Gör så att man får lite rum att andas och läsa vad som händer innan alternativen postas igen
                Console.ReadLine();
            }
        }
    }
    class Customer
    {
        public string Name;
        public string Adress;
        public string Number;
    }
}
