using System;
namespace VendingMachine
{
    public class VendingMachine
    { 
        private static VendingItem[] item = new VendingItem[3];

        private VendingMachine()
        {
            item[0] = new Drink("CocaCola", 10, 1);
            item[1] = new Food("Pizza", 20, 2);
            item[2] = new Toy("Teddybear", 50, 3);
        }

        readonly static int[] acceptedCoin = new int[8] { 1, 5, 10, 20, 50, 100, 500, 1000 };


        private int moneyPool = 0;
        private int MoneyPool(int coin)
        {
            return moneyPool += coin;
        }

        private void DepositCoin(int addedCoin)
        {
            
            for(var i = 0; i < acceptedCoin.Length; i++)
            {
                if (acceptedCoin[i] == addedCoin)
                {
                    MoneyPool(addedCoin);
                }
                else
                {
                    throw new InvalidOperationException("Entry was invalid.");
                }
            }
        }

        private void PurchaseItem(int enteredItemID)
        {
            for(var i = 0; i < item.Length; i++)
            {
                if(item[i].ItemID == enteredItemID)
                {
                    item[i].Purchase(moneyPool);
                }
            }
        }

        readonly int[] coinsBack = new int[acceptedCoin.Length];

        private void ReturnCoins(int moneyPool, int[] coinsBack, int[] acceptedCoin)
        {
            for (int i = 0; i < acceptedCoin.Length; i++)
            {
                if (moneyPool < acceptedCoin[i])
                {
                    coinsBack[i] = 0;
                }
                else if ((moneyPool / acceptedCoin[i]) > 0)
                {
                    coinsBack[i] = (moneyPool / acceptedCoin[i]);
                    moneyPool = (moneyPool % acceptedCoin[i]);
                }
            }
        }

        private void ExitMachine()
        {
            for (int i = 0; i < acceptedCoin.Length; i++)
            {
                
                Console.WriteLine(acceptedCoin[i] + "x" + coinsBack[i]);
            }
        }



        
    }
}
