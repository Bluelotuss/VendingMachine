using System;
namespace VendingMachine
{
    public abstract class VendingItem
    {
        readonly string itemName;
        readonly int itemPrice;
        readonly int itemID;

        public string ItemName { get { return itemName; } }
        public int ItemPrice { get { return itemPrice; } }
        public int ItemID { get { return itemID; } }


        public VendingItem(string itemName, int itemPrice, int itemID)
        {
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.itemID = itemID;
        }

        public void Purchase(int moneyPool)
        {
            if (moneyPool >= ItemPrice)
            {
                moneyPool -= ItemPrice;
            }
            else
            {
                throw new InvalidOperationException("Not enough money.");
            }
        }

        public void Examine()
        {
            Console.WriteLine("Item: {0} Price: {1}", ItemName, ItemPrice);
        }

        public abstract void UseItem();
    }
}
