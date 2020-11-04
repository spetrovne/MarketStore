using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Bronze : DiscountCard
    {
        public Bronze(string owner, decimal turnover) : base(owner, turnover)
        {
        }

        public override void CalculateDiscountRate()
        {
            if (this.Turnover < 100)
            {
                this.DiscountRate = 0;
            }
            else if (this.Turnover >= 100 && this.Turnover <= 300)
            {
                this.DiscountRate = 1m / 100;
            }
            else if (this.Turnover > 300)
            {
                this.DiscountRate = 2.5m / 100;

            }
        }
    }
}
