using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer
{
    class Article
    {
        public string ProductName { get; }

        private string ShopName { get; set; }

        private decimal Cost { get; set; }


        public Article(string productName, string shopName, decimal cost)
        {
            ProductName = productName;

            ShopName = shopName;

            Cost = cost;
        }

      

        public void Show()
        {
            Console.WriteLine($"Информация о товаре: {ProductName}, {ShopName}, {Cost}");
        }
    }
}
