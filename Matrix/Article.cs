using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{//• название товара;
    //• название магазина, в котором продается товар;
    //• стоимость товара в гривнах.
    class Article
    {
        private string ProductName { get; set; }

        private string ShopName { get; set; }

        private decimal Cost { get; set; }

        public Article(string productName, string shopName, decimal cost)
        {
            ProductName = productName;

            ShopName = shopName;

            Cost = cost;
        }
    }
}
