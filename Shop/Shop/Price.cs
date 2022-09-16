namespace Shop
{
    public class Price
    {
        public Price(int value, Currency currency)
        {
            Value = value;
            Currency = currency;
        }

        public int Value { get; init; }
        public Currency Currency { get; init; }
    }
}
