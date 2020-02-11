using System;
using System.Collections.Generic;
using System.Text;

namespace ShopCore.Data
{
    public class ProductData
    {
        private string _productName;
        private string _description;
        private int _price;
        private int _amount;

        public ProductData(string productName, string description, int price, int amount)
        {
            ProductName = productName;
            Description = description;
            Price = price;
            Amount = amount;
        }

        public string ProductName { get => _productName; set => _productName = value; }
        public string Description { get => _description; set => _description = value; }
        public int Price { get => _price; set => _price = value; }
        public int Amount { get => _amount; set => _amount = value; }

    }
}
