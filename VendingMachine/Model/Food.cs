using System;

namespace VendingMachine
{
    public class Food : VendingItem
    {
        public Food(string itemName, int itemPrice, int itemID) : base(itemName, itemPrice, itemID)
        {
        }

        public override void UseItem()
        {
            Console.WriteLine("Eat the food");
        }
    }
}
