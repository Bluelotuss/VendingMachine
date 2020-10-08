using System;
namespace VendingMachine
{
    public abstract class VendingItem
    {
        readonly string itemName;
        readonly int itemPrice;
        readonly string message;
        readonly int itemID;

        public string ItemName { get { return itemName; } }
        public int ItemPrice { get { return itemPrice; } }
        public string Message { get { return message; } }
        public int ItemID { get { return itemID; } }

        public VendingItem(string itemName, int itemPrice, string message, int itemID)
        {
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.message = message;
            this.itemID = itemID;
        }

        public void Purchase(int[] moneyPool)
        {
            if (moneyPool[0] >= ItemPrice)
            {
                moneyPool[0] -= ItemPrice;
            }
            else
            {
                throw new InvalidOperationException("Not enough money.");
            }
        }

        public string Examine()
        {
            return "ID: " + ItemID + " Name: " + ItemName + " Price: " + ItemPrice;
        }

        public abstract string UseItem();
    }
}
