using System;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";

            summerMenu.AddMenuItem("Salmon", "Fresh salmon", 25.50);
            summerMenu.AddMenuItem("Taco", "Great tacos", 10);
            summerMenu.HospitalDirections = "5th right around the corner";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and drive";
            outsideDrinks.AddMenuItem("Virgin Cuba Libre", "A classic drink", 10);
            outsideDrinks.AddMenuItem("Screwdriver", "Great", 15);

            Order hungryGuestOrder = new Order();
            for (int x = 0; x <= summerMenu.items.Count - 1; x++)
            {
                MenuItem currentItem = summerMenu.items[x];
                hungryGuestOrder.items.Add(currentItem);
            }

            foreach (MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            }

            Console.WriteLine($"The total is: ${hungryGuestOrder.Total}");
            Console.ReadKey();
        }
    }
}
