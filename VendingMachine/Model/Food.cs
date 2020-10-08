using System;

namespace VendingMachine
{
    public class Food : VendingItem
    {
        public Food(string itemName, int itemPrice, string message, int itemID) : base(itemName, itemPrice, message, itemID)
        {
        }

        public override string UseItem()
        {
            return Message;
        }
    }
}
