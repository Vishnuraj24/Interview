﻿namespace Caching
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Product(int id,string name,string description,int price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

    }
}
