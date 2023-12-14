using BugAndExceptions;
using System;
using Xunit;

namespace ShoppingTest
{
    public class ShopTest
    {
        [Fact]
        public void InitializBankInfoSetsCorrectBalance()
        {
            var expectedResult = 100; 
            var bankInfo = new BankInformation(expectedResult);
            var actualResult = bankInfo.Balance;
            Assert.Equal(expectedResult, actualResult);
        }

        /* 
         *    public int PrintItemsInCart()
        {
            Console.WriteLine("ShoppingCart now has: ");
            var totalPrice = 0;
            foreach(var Item in ShoppingCart)
            {
                Console.WriteLine(Item.ItemName);
                totalPrice += Item.Price;
            }
            Console.WriteLine("total price is: " + totalPrice);
            Console.WriteLine();
            return totalPrice;
        }
        */

        [Fact]
        public void TestTotalPriceWhenPrintingItemsinCart()
        {
            var cust = new Customer("Bjarne", new Address(), new BankInformation(100));
            var shoppingItem = new ShopItem("Banana",20);
            cust.AddItemToShoppingCart(shoppingItem);
            var totalPrice = cust.GetTotalPrice();
            Assert.Equal(20, totalPrice);
        }

        [Fact]
        public void TestItemRemovedFromCartWhenMultipleItems()
        {
            var cust = new Customer("Bjarne", new Address(), new BankInformation(100));
            var shoppingItem = new ShopItem("Banana",20);
            cust.AddItemToShoppingCart(shoppingItem);
            cust.AddItemToShoppingCart(shoppingItem);
            cust.AddItemToShoppingCart(shoppingItem);

            cust.RemoveItemFromShoppingCart(shoppingItem);

            Assert.Equal(2, cust.ShoppingCart.Count);
        }
        [Fact]
        public void TestItemRemovedFromCart()
        {
            var cust = new Customer("Bjarne", new Address(), new BankInformation(100));
            var shoppingItem = new ShopItem("Banana",20);
            cust.AddItemToShoppingCart(shoppingItem);

            cust.RemoveItemFromShoppingCart(shoppingItem);
            Assert.DoesNotContain(shoppingItem, cust.ShoppingCart);
        }

        [Fact]
        public void TestItemAddedToCart()
        {
            var cust = new Customer("Bjarne", new Address(), new BankInformation(100));
            var shoppingItem = new ShopItem();
            cust.AddItemToShoppingCart(shoppingItem);
            Assert.Contains(shoppingItem, cust.ShoppingCart);
        }

        [Fact]
        public void InitializeCustomer()
        {
            var cust = new Customer("Bjarne", new Address(), new BankInformation(100));
            Assert.Equal("Bjarne", cust.Name);
            Assert.NotNull(cust.ShoppingCart);
            Assert.NotNull(cust.Inventory);
            Assert.NotNull(cust.CustomerAddress);
            Assert.NotNull(cust.CustomerBankInfo);
        }
    }
}
