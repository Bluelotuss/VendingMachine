using System;

namespace VendingMachine
{
    public class Drink : VendingItem
    {
        public Drink(string itemName, int itemPrice, string message, int itemID) : base(itemName, itemPrice, message, itemID)
        {

        }

        public override string UseItem()
        {
            return Message;
        }

    }
}

