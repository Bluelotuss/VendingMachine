using System;

namespace VendingMachine
{
    public class Toy : VendingItem
    {
        public Toy(string itemName, int itemPrice, string message, int itemID) : base(itemName, itemPrice, message, itemID)
        {
        }

        public override string UseItem()
        {
            return Message;
        }
    }
}
