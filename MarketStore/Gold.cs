using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Gold : DiscountCard
    {
        public Gold(string owner, decimal turnover) : base(owner, turnover)
        {
            this.DiscountRate = 2m / 100; ;
        }
       
        public override void CalculateDiscountRate()
        {
            this.DiscountRate = 2m / 100;
            var tempRate = 2;
            var iterations = Math.Ceiling(this.Turnover / 100);
            while (tempRate < 10 && tempRate < iterations)
            {
                tempRate++;
                this.DiscountRate = tempRate / 100m;
            }
        }
    }
}
