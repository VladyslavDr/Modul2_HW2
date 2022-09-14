using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class CostProduct
    {
        public int Cost { get; set; }
        public Currencies Currencies => Currencies.UAH;
    }
}
