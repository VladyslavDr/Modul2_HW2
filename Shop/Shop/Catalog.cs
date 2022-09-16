namespace Shop
{
    public class Catalog
    {
        private static Catalog _instance;

        private Catalog()
        {
            Products = new Product[]
            {
                new Product()
                {
                    ClothingType = Enums.ClothingType.T_shirt,
                    Material = Enums.Material.Cotton,
                    Color = System.ConsoleColor.Red,
                    Size = Enums.Size.S,
                    Price = new Price(value: 25, currency: Currency.USD)
                },

                new Product()
                {
                    ClothingType = Enums.ClothingType.T_shirt,
                    Material = Enums.Material.Linen,
                    Color = System.ConsoleColor.Yellow,
                    Size = Enums.Size.M,
                    Price = new Price(value: 15, currency: Currency.USD)
                },

                new Product()
                {
                    ClothingType = Enums.ClothingType.Shorts,
                    Material = Enums.Material.Cotton,
                    Color = System.ConsoleColor.DarkGray,
                    Size = Enums.Size.XL,
                    Price = new Price(value: 55, currency: Currency.USD)
                },
                new Product()
                {
                    ClothingType = Enums.ClothingType.Jacket,
                    Material = Enums.Material.Viscose,
                    Color = System.ConsoleColor.Blue,
                    Size = Enums.Size.XS,
                    Price = new Price(value: 120, currency: Currency.USD)
                },
                new Product()
                {
                    ClothingType = Enums.ClothingType.Sweater,
                    Material = Enums.Material.Wool,
                    Color = System.ConsoleColor.White,
                    Size = Enums.Size.M,
                    Price = new Price(value: 55, currency: Currency.USD)
                },
                new Product()
                {
                    ClothingType = Enums.ClothingType.Sweater,
                    Material = Enums.Material.Wool,
                    Color = System.ConsoleColor.Yellow,
                    Size = Enums.Size.S,
                    Price = new Price(value: 60, currency: Currency.USD)
                },
                new Product()
                {
                    ClothingType = Enums.ClothingType.Pants,
                    Material = Enums.Material.Cotton,
                    Color = System.ConsoleColor.Red,
                    Size = Enums.Size.S,
                    Price = new Price(value: 60, currency: Currency.USD)
                },
                new Product()
                {
                    ClothingType = Enums.ClothingType.Shorts,
                    Material = Enums.Material.Viscose,
                    Color = System.ConsoleColor.Black,
                    Size = Enums.Size.L,
                    Price = new Price(value: 75, currency: Currency.USD)
                },
            };
        }

        public Product[] Products { get; init; }

        public static Catalog GetInstance()
        {
            if (_instance is null)
            {
                _instance = new Catalog();
            }

            return _instance;
        }
    }
}
