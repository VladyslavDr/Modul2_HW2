using System;

namespace Shop
{
    public class Catalog
    {
        private static Catalog _instance;
        private Vegetable[] _vegetables;

        private Catalog()
        {
            _vegetables = new Vegetable[]
            {
                new Vegetable(Vegetables.Caper, new CostProduct() { Cost = 10 }),
                new Vegetable(Vegetables.Carrot, new CostProduct() { Cost = 35 }),
                new Vegetable(Vegetables.Garlic, new CostProduct() { Cost = 76 }),
                new Vegetable(Vegetables.Onion, new CostProduct() { Cost = 85 }),
                new Vegetable(Vegetables.Pepper, new CostProduct() { Cost = 85 }),
                new Vegetable(Vegetables.Tomato, new CostProduct() { Cost = 40 }),
                new Vegetable(Vegetables.Сucumber, new CostProduct() { Cost = 25 }),
                new Vegetable(Vegetables.Eggplant, new CostProduct() { Cost = 15 }),
                new Vegetable(Vegetables.Broccoli, new CostProduct() { Cost = 215 }),
                new Vegetable(Vegetables.Dill, new CostProduct() { Cost = 13 }),
                new Vegetable(Vegetables.Parsley, new CostProduct() { Cost = 15 }),
            };
        }

        public Vegetable[] GetVegetables => _vegetables;

        public static Catalog GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Catalog();
            }

            return _instance;
        }
    }
}