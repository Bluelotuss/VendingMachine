using System;
namespace VendingMachine
{
    public class VendingMachine
    {
        private static VendingItem[] item = new VendingItem[0];

        readonly static int[] acceptedCoin = new int[8] { 1000, 500, 100, 50, 20, 10, 5, 1 };
        public int[] AcceptedCoin { get { return acceptedCoin; } }


        int moneyPool = 0;
        public int MoneyPool { get { return moneyPool; } }


        public void AddToMoneyPool(int coin)
        {
            moneyPool += coin;
        }



        /* private void PurchaseItem(int enteredItemID)
         {
             for(var i = 0; i < item.Length; i++)
             {
                 if(item[i].ItemID == enteredItemID)
                 {
                     item[i].Purchase(moneyPool);
                 }
             }
         }*/

        public int[] ReturnCoins()
        {
            int[] coinsBack = new int[acceptedCoin.Length];
            int newMoneyPool = moneyPool;

            for (var i = 0; i < acceptedCoin.Length; i++)
            {
                if (newMoneyPool < acceptedCoin[i])
                {
                    coinsBack[i] = 0;
                }
                else if ((newMoneyPool / acceptedCoin[i]) > 0)
                {
                    coinsBack[i] = (newMoneyPool / acceptedCoin[i]);
                    newMoneyPool = (newMoneyPool % acceptedCoin[i]);
                }

            }
            return coinsBack;
        }

        public string ExitMachine(int[] coinsBack)
        {
            string newString = "";
            for (var i = 0; i < acceptedCoin.Length; i++)
            {
                newString += (acceptedCoin[i] + " x " + coinsBack[i] + ", ");
            }

            return newString;
        }



        
    }
}
