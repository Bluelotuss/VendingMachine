using System;

namespace VendingMachine
{
    public class Toy : VendingItem
    {
        public Toy(string itemName, int itemPrice, int itemID) : base(itemName, itemPrice, itemID)
        {
        }

        public override void UseItem()
        {
            Console.WriteLine("Play with the toy");
        }
    }
}
