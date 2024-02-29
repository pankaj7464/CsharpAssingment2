﻿namespace InventoryManagement
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }

        public Product(string name, decimal price, int quantity, string type)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Name}, {Price} RS, {Quantity}, {Type}";
        }
    }
}