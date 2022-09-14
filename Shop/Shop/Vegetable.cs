namespace Shop
{
    public class Vegetable
    {
        private Vegetables _vegetables;
        private CostProduct _cost;

        public Vegetable(Vegetables vegetables, CostProduct cost)
        {
            _vegetables = vegetables;
            _cost = cost;
        }

        public Vegetables GetTypeVegetable => _vegetables;
        public CostProduct GetCostVegetable => _cost;
    }
}
