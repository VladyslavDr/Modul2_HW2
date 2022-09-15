using System;

namespace Shop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var catalog = Catalog.GetInstance();
            var myCart = new Cart();

            var user1 = new User() { Name = "Vlad", Email = "Vlad228@gmaol.com" };

            user1.Cart.AddItemToCart(catalog.Products[1]);
            user1.Cart.AddItemToCart(catalog.Products[2]);
            user1.Cart.AddItemToCart(catalog.Products[3]);
            user1.Cart.ShowCart();
            Console.WriteLine($"total cost: {myCart.TotalOrderValue().Value}\n");
            user1.Cart.AddItemToCart(catalog.Products[5]);
            user1.Cart.ShowCart();
            Console.WriteLine($"total cost: {myCart.TotalOrderValue().Value}\n");
            user1.Cart.RemoveItemFromTheCart(catalog.Products[1]);
            user1.Cart.RemoveItemFromTheCart(catalog.Products[2]);
            user1.Cart.ShowCart();
            Console.WriteLine($"total cost: {myCart.TotalOrderValue().Value}\n");
            user1.Cart.Order();
            user1.Cart.ShowCart();
        }
    }
}
