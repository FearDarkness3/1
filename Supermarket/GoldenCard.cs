using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class GoldenCard : DiscountCard
    {
        private static double goldenDiscount = 5;
        public GoldenCard() : base(goldenDiscount)
        {
            
        }
    }
}
