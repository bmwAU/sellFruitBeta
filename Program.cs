// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Threading;

namespace fruitStandBeta
{
    public class FruitSeller
    {
        public static void Main(string[] args)
        {
            static string SayHello() {
            var hour = DateTime.Now.Hour;
            if (hour < 12) return "Good Morning!";
            if (hour < 18) return "Good Afternoon!";
            return "Good Evening!";
        }
            
            // Create a list of fruits and their prices.
            List<Fruit> fruits = new List<Fruit>
        {
            new Fruit("Apple", 1.00),
            new Fruit("Banana", 0.50),
            new Fruit("Orange", 0.75),
            new Fruit("Pear", 1.25)
        };

            // Prompt the user to select a fruit.
            Console.WriteLine(SayHello() + " Please select a fruit:");
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {fruits[i].Name}");
            }

            // Get the user's selection.
#pragma warning disable CS8604 // Possible null reference argument.
            int selection = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            // Get the quantity of fruit the user wants.
            Console.WriteLine("How many of this fruit would you like?");
#pragma warning disable CS8604 // Possible null reference argument.
            int quantity = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            // Calculate the total price.
            double totalPrice = fruits[selection - 1].Price * quantity;

            // Display the total price.
            Console.WriteLine($"The total price is ${totalPrice}.");

            //asks for user's credit card information
            Console.WriteLine("Please enter your credit card number, expiration date, and three digit secruity code now.");
        
            // Start a timer to skip Console.ReadLine after 5 seconds.
            Timer timer = new Timer(SkipReadLine, null, 5000, Timeout.Infinite);

            // Read the user's input.
            string input = Console.ReadLine();

            // Stop the timer.
            timer.Dispose();

            if (input != null)
        {
            Console.WriteLine("Thank you for your information!");
        }
        else
        {
            Console.WriteLine("Just kidding, enjoy your fruit!");
        }
        }

        private static void SkipReadLine(object state)
        {
             //haha
            Console.WriteLine("Just kidding, enjoy your fruit!");
        }

           
        }
    }

    public class Fruit
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Fruit(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
// }