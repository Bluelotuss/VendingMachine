using System;
namespace VendingMachine
{
    public class Inventory
    {
        VendingItem[] items = new VendingItem[3];

        public Inventory()
        {
            items[0] = new Drink("CocaCola", 5, "Drink your drink", 1);
            items[1] = new Food("Pizza", 20, "Eat your pizza", 2);
            items[2] = new Toy("Teddybear", 50, "Play with your Teddybear", 3);
        }

        
        public Array Items { get { return items; } }
    }
}
