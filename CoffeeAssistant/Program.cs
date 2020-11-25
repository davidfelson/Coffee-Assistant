using System;

namespace CoffeeAssistant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good morning! How would you like to brew your coffee?");
            Console.WriteLine("Press (A) for Aeropress");
            Console.WriteLine("Press (C) for Chemex");
            Console.WriteLine("Press (D) for Drip");
            Console.WriteLine("Press (E) for Espresso");
            string brewMethod = Console.ReadLine();


            if (brewMethod == "A")
            {
                //You can only make 1-cup at a time using Aeropress. Are you still interested?
                //Console.WriteLine("Press (Y) for Yes or (N) to pick another brew method");

                Console.WriteLine("\r\nGreat choice for early morning reading!");
                Console.WriteLine("You'll need 18 grams of coffee at grind size 15 and 200 mL filtered water.");

            }

            if (brewMethod == "C")
            {
                //You can only make 1-cup at a time using Aeropress. Are you still interested?
                //Console.WriteLine("Press (Y) for Yes or (N) to pick another brew method");

                Console.WriteLine("\r\nPerfect for a cozy morning with your partner!");
                Console.WriteLine("You'll need 35 grams of coffee at grind size 20 and 650 mL filtered water.");

            }


            if (brewMethod == "D")
            {

                Console.WriteLine("\r\nLet's spend some quality family time!");
                Console.WriteLine("How many people are drinking coffee this morning?\r\n");
                string peopleDrinkingCoffee = Console.ReadLine();
                int numberPeopleDrinkingCoffee = Convert.ToInt32(peopleDrinkingCoffee);
                int gramsCoffeePerPerson = 12;
                int mlWaterPerPerson = 175;


                if (numberPeopleDrinkingCoffee < 3)
                {
                    Console.WriteLine("\r\nAeropress or Chemex might be better for such a small group. If you want to try these brew methods, press (A) for Aeropress or (C) for Chemex");
                    string revisedBrewMethod = Console.ReadLine();

                    if (revisedBrewMethod == "A")
                    {
                        Console.WriteLine("\r\nGreat choice for early morning reading!");
                        Console.WriteLine("You'll need 18 grams of coffee at grind size 15 and 200 mL filtered water.");
                    }

                    else if (revisedBrewMethod == "C")
                    {
                        Console.WriteLine("\r\nPerfect for a cozy morning with your partner!");
                        Console.WriteLine("You'll need 35 grams of coffee at grind size 20 and 650 mL filtered water.");
                    }


                }

                else Console.WriteLine($"You'll need {gramsCoffeePerPerson * numberPeopleDrinkingCoffee} grams of coffee at grind size 18 and {mlWaterPerPerson * numberPeopleDrinkingCoffee} mL filtered water.");



            }


            if (brewMethod == "E")
            {

                Console.WriteLine("\r\nLet's leave this to the experts! Here's a list of amazing local coffee shops near you.\r\n");
                Console.WriteLine("(1) Rising Star in Hingetown | 1455 W 29th Cleveland, OH 44113");
                Console.WriteLine("(2) Phoenix Coffee in Ohio City | 3000 Bridge Ave, Cleveland, OH 44113, United States\r\n");
                Console.WriteLine("Press (1) for Rising Star");
                Console.WriteLine("Press (2) for Phoenix Coffee");
                string chosenCoffeeShop = Console.ReadLine();
                //int chosenCoffeeShopAsInt = int.Parse(chosenCoffeeShop);

                if (chosenCoffeeShop == "1")
                {
                    Console.WriteLine("Let's take a break from coding and go for a walk. Rising Star is a 4-minute walk from your desk");
                }

                else if (chosenCoffeeShop == "2")
                {
                    Console.WriteLine("Let's take a break from coding and go for a walk. Phenoix Coffee is a 6-minute walk from your desk");
                }




            }








        }
    }
}
