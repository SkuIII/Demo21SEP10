using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Välj vad du vill göra med hjälp av alternativen nedan:");

            while (true)
            {
                Console.WriteLine("1 (Skapa ny kund)\n" +
                                  "2 (Visa antal kunder)\n" +
                                  "3 (Visa lista över alla kunder)\n" +
                                  "4 (Avsluta)");
                string alternativ = Console.ReadLine();

                if (alternativ == "1") // Skapa kund
                {
                    Console.WriteLine("1");
                    break;
                }

                if (alternativ == "2") // Visa antal kunder
                {
                    Console.WriteLine("2");
                    break;
                }

                if (alternativ == "3") // Visa lista över alla kunder
                {
                    Console.WriteLine("3");
                    break;
                }

                if (alternativ == "4") // Avsluta
                {
                    break;
                }

                Console.WriteLine("Du måste skriva ett av alternativen nedan! Antingen 1, 2, 3 eller 4.");
            }
        }
    }
    class Customer
    {
        public string name;
        public string adress;
        public string number;
    }
}
