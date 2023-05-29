using System;

namespace VendingMachineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 x 4 array of Items
            Item[,] products = new Item[3,4];

            products[0, 0] = new SnackItem("Mhandire", 7);
            products[0, 1] = new SnackItem("GoldenBites", 5);
            products[0, 2] = new SnackItem("Doritos", 3);
            products[0, 3] = new SnackItem("Chompkins", 5);

            products[1, 0] = new ChocolateItem("KitKat", 5);
            products[1, 1] = new ChocolateItem("Bounty", 6);
            products[1, 2] = new ChocolateItem("Cadbury", 8);
            products[1, 3] = new ChocolateItem("Pascal", 7);

            products[2, 0] = new DrinkItem("CoCola", 2);
            products[2, 1] = new DrinkItem("Miranda", 3);
            products[2, 2] = new DrinkItem("Sprite", 4);
            products[2, 3] = new DrinkItem("7Up", 4);


            // Passing the products array to the vending machine
            // Aggregation relationship
            VendingMachine myvendy = new VendingMachine(products);
            // Turning on the vending machine
            myvendy.TurnOn();
        }
    }
}
