using System;
using System.Collections.Generic;
using System.Text;

namespace BugAndExceptions
{
    public class ShopItem
    {
        public string ItemName { get; set; }
        public int Price { get; set; }
        public string Id { get; set; }

        public ShopItem()
        {

        }
        public ShopItem(string itemName, int price)
        {
            ItemName = itemName;
            Price = price;  
        }
    }
}
