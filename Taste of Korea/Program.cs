using System;
using System.Collections.Generic;

namespace FoodOrderingSystem
{
    class Program
    {
        static List<string> foods = new List<string>()
        {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Dessert",
            "Snacks",

        };

        static Dictionary<string, decimal> foodPrices = new Dictionary<string, decimal>()
        {
            { "Breakfast",250 },
            { "Lunch", 350 },
            { "Dinner", 450 },
            { "Dessert", 100 },
            { "Snacks", 50 },

        };

        static Dictionary<string, List<string>> Food = new Dictionary<string, List<string>>()
        {
            { "Breakfast", new List<string>() { "Sweet Korean Pancake + Coffee Milk" , "Kimchi Stew + Rice + Boiled Eggs", "Fried Rice + Omelette Eggs + Strawberry Milk"} },
            { "Lunch", new List<string>() { "Korean Fried Chicken + Rice + Kimchi + Sprite", "Fried Rice + Omelette Eggs + Kimchi + Coke", "Rice + Main meat + Kimchi +Sprite", "Kimchi + Baked Potatoes + Coke + Gimbap" } },
            { "Dinner" , new List<string>() { "Bulgogi(korean beef barbecue) + Lettuce Wraps + Coke", "Mandoo(korean dumplings) + Rice + Sprite", "Bossam (korean pork belly) + Lettuce Wraps + Coke", "Galbi(korean grilled short ribs) + Lettuce Wraps + Rice + Sprite" } },
            { "Dessert", new List<string>() { "Tea Cookies + Green Tea", "Twisted Donuts + Dalgona Coffee ", "Mochi Rice Cake + Makgeolli Ice Cream" } },
            { "Snacks", new List<string>() { "Bibigo Roasted Seaweeds", "Nongshim Chocolate Banana Kick", "Orion Market O Rael Brownie", "Melona Ice Cream", "Tom's Farm Almond", "Lotte Waffle Mate", "Ramyeon" } },

        };

        static void Main()
        {
            Console.WriteLine("Welcome to the Taste Of Korea Ordering System!");

            DisplayFoods();

            Console.Write("Enter your food of choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice < 1 || choice > foods.Count)
            {
                Console.WriteLine("Invalid choice!");
                return;
            }
            string selectedFoods = foods[choice - 1];
            List<string> comboOptions = Food[selectedFoods];

            Console.WriteLine("You have selected: " + selectedFoods);
            Console.WriteLine("Please select the combo option:");

            for (int i = 0; i < comboOptions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {comboOptions[i]}");
            }

            Console.Write("Enter your combo choice: ");
            int comboChoice = int.Parse(Console.ReadLine());

            if (comboChoice < 1 || comboChoice > comboOptions.Count)
            {
                Console.WriteLine("Invalid combo choice!");
                return;
            }

            string selectedCombo = comboOptions[comboChoice - 1];
            string foodType = $"{selectedFoods} ({selectedCombo})";

            decimal foodPrice = foodPrices[selectedFoods];
            Console.WriteLine("Total Price: PHP" + foodPrice);

            Console.Write("Enter your name: ");
            string customerName = Console.ReadLine();
            Console.WriteLine("Thank you, " + customerName + "!");

            Console.Write("Enter your payment amount: PHP");
            decimal paymentAmount = decimal.Parse(Console.ReadLine());

            if (paymentAmount < foodPrice)
            {
                Console.WriteLine("Insufficient payment!");
                return;
            }


            decimal change = paymentAmount - foodPrice;
            Console.WriteLine("Payment successful. Your change: PHP" + change);

            Console.WriteLine();
            Console.WriteLine("Order Processing and Receipt");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Food Type: " + foodType);
            Console.WriteLine("Total Price: Php" + foodPrice);
            Console.WriteLine("Payment Amount: Php" + paymentAmount);
            Console.WriteLine("Change: Php" + change);
            Console.WriteLine("Thank you for your order!");
        }

        static void DisplayFoods()
        {
            Console.WriteLine("Please select the type of food you want to order:");

            for (int i = 0; i < foods.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {foods[i]}");
            }
        }
    }
}


