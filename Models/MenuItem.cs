using System;
using System.Collections.Generic;

namespace laboop.Models
{
    public abstract class MenuItem
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public MenuItem(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public abstract string GetInfo
        {
            get;
        }
    }
}