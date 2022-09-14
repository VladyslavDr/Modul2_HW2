using System;

namespace Shop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var catalog = Catalog.GetInstance();

            var myCart = new Cart();

            myCart.AddItemToCart(catalog.GetVegetables[0]);
            myCart.AddItemToCart(catalog.GetVegetables[1]);
            myCart.AddItemToCart(catalog.GetVegetables[5]);
            myCart.AddItemToCart(catalog.GetVegetables[3]);

            myCart.PlaceAnOrder(myCart);
        }
    }
}
