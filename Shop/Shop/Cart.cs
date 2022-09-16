using System;

namespace Shop
{
    public class Cart
    {
        private Product[] _products;
        private int _counter;

        public Cart()
        {
            _products = new Product[10];
        }

        public Price TotalOrderValue()
        {
            int current = 0;

            for (int index = 0; index < _counter; index++)
            {
                current += _products[index].Price.Value;
            }

            return new Price(value: current, currency: Currency.USD);
        }

        public void Order()
        {
            Console.WriteLine($"order №{new Random().Next()} is ready, await shipment!");
            Console.WriteLine($"Total order value is {TotalOrderValue().Value}{TotalOrderValue().Currency}");

            Empty();
        }

        public void Empty()
        {
            _counter = 0;

            for (int index = 0; index < _products.Length; index++)
            {
                _products[index] = null;
            }
        }

        public void AddItem(Product product)
        {
            if (_counter < 10)
            {
                _products[_counter++] = product;
            }
        }

        public void RemoveItem(Product product)
        {
            bool status = false;

            for (int index = 0; index < _counter - 1; index++)
            {
                if (product == _products[index])
                {
                    status = true;
                }

                if (status)
                {
                    _products[index] = _products[index + 1];
                }
            }

            if (_counter > 0)
            {
                _counter--;
            }
            else
            {
                _counter = 0;
            }
        }

        public void Show()
        {
            if (_counter is 0)
            {
                Console.WriteLine("The cart is empty!");
            }

            for (int index = 0; index < _counter; index++)
            {
                Console.Write($"{index + 1}) {_products[index].ClothingType} ");
                Console.Write($"cost: {_products[index].Price.Value}");
                Console.WriteLine($"{_products[index].Price.Currency}");
            }

            Console.WriteLine();
        }
    }
}
