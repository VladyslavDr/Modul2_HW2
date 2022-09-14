using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Cart
    {
        private Vegetable[] _vegetables;
        private int _counter;

        public Cart()
        {
            _vegetables = new Vegetable[10];
        }

        public Vegetable[] GetCartVegetables => _vegetables;

        public void AddItemToCart(Vegetable vegetable)
        {
            _vegetables[_counter++] = vegetable;
        }

        public void ShowCart()
        {
            for (int index = 0; index < _counter; index++)
            {
                Console.Write($"{index + 1}) {_vegetables[index].GetTypeVegetable} cost: {_vegetables[index].GetCostVegetable.Cost}");
                Console.WriteLine($"{_vegetables[index].GetCostVegetable.Currencies}/Kg");
            }
        }

        public int GetTotalOrderPrice()
        {
            int totalOrderPrice = 0;

            for (int index = 0; index < _counter; index++)
            {
                totalOrderPrice += _vegetables[index].GetCostVegetable.Cost;
            }

            return totalOrderPrice;
        }

        public void PlaceAnOrder(Cart cart)
        {
            string name;
            string lastName;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine($"Dear {lastName} {name}, your order number is {new Random().Next()}");
            Console.WriteLine($"Your order: ");

            ShowCart();

            Console.WriteLine($"Total order price is {cart.GetTotalOrderPrice()}{cart._vegetables[0].GetCostVegetable.Currencies}");

            _vegetables = null;
        }
    }
}
