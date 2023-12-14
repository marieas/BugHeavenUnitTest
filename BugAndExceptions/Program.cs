using System;

namespace BugAndExceptions
{
    //Pause til 13.46
    //
    class Program
    {
        static void Main(string[] args)
        {           
            var shop = new Shop();
            var customer = new Customer("Bjarne", new Address(),new BankInformation(100));
            while (true)
            {
                shop.PrintItems();
                Console.WriteLine();
                Console.WriteLine("What do you want to buy?");
                Console.WriteLine("if finished shopping, write 0");
                Console.WriteLine();

                var itemNumber = Console.ReadLine();
                if (itemNumber == "0")
                {
                    shop.CheckOut(customer);
                }
                else
                {
                    customer.AddItemToShoppingCart(shop.ShopItems.Find(item => item.Id == itemNumber));
                    customer.PrintItemsInCart();
                }
                
            }
        }
    }
}
