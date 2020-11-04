using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Silver : DiscountCard
    {
        public Silver(string owner, decimal turnover) : base(owner, turnover)
        {
            this.DiscountRate = 2m / 100;
        }       

        public override void CalculateDiscountRate()
        {
            this.DiscountRate = 2m / 100;

            if (this.Turnover >= 300)
            {
                this.DiscountRate = 3.5m / 100;
            }
        }
    }
}
