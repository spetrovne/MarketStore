using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Gold : DiscountCard
    {
        private decimal discountRate;

        public Gold(decimal turnover) : base( turnover)
        {
            base.DiscountRate = this.DiscountRate;
        }

        public new decimal DiscountRate
        {
            get
            {
                this.discountRate = 2m / 100;
                var tempRate = 2;
                var iterations = Math.Ceiling(this.Turnover / 100);
                while (tempRate < 10 && tempRate < iterations)
                {
                    tempRate++;
                    this.discountRate = tempRate / 100m;
                }
                return this.discountRate; 
            }
            
        }

        public override decimal CalculateDiscount(decimal purchasePrice)
        {
            return purchasePrice * this.DiscountRate;
        }

       
    }
}
