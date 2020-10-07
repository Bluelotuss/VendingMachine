using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink drink = new Drink("CocaCola", 10, "Drinkit", 1);

            drink.PurchaseItem(moneyPool);
        }
    }
}
