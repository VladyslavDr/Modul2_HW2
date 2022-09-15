using System;

namespace Shop
{
    public class Product
    {
        public Price Price { get; set; }
        public ConsoleColor Color { get; set; }
        public Enums.ClothingType ClothingType { get; set; }
        public Enums.Material Material { get; set; }
        public Enums.Size Size { get; set; }
    }
}
