using System;
using Xunit;

namespace VendingMachine.Tests
{
    public class VendingMachineTests
    {
        [Fact]
        public void Run_AddToMoneyPool()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.AddToMoneyPool(0);

            int expected = 10;

            //Act
            vendingMachine.AddToMoneyPool(10);

            //Assert
            Assert.Equal(expected, vendingMachine.MoneyPool);

        }

        [Fact]
        public void Run_ReturnCoins()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.AddToMoneyPool(250);

            int[] expected = new int[8] { 0, 1, 0, 0, 0, 6, 7, 8 };

            //Act
            int[] actual = vendingMachine.ReturnCoins();

            //Assert
            Assert.NotEqual(expected, actual);

        }

        [Fact]
        public void Run_ExitMachine()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.AddToMoneyPool(250);

            
            string expected = "Test";

            //Act
            int[] testCoins = vendingMachine.ReturnCoins();

            string actual = vendingMachine.ExitMachine(testCoins);

            //Assert
            Assert.Equal(expected, actual);

        }


    }
}
