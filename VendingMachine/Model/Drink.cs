using System;

namespace VendingMachine
{
    public class Drink : VendingItem
    {
        public Drink(string itemName, int itemPrice, int itemID) : base(itemName, itemPrice, itemID)
        {

        }

        public override void UseItem()
        {
            Console.WriteLine("Drink the drink");
        }

    }
}

