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

        public int Purchase(int moneyPool)  // Hur fattar den att den ska uppdatera moneyPool i VM?
        {
            if (moneyPool >= ItemPrice)
            {
                moneyPool -= ItemPrice;
                return moneyPool;
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
