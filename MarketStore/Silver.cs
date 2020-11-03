using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Silver : DiscountCard
    {
        private decimal discountRate;

        public Silver(decimal turnover) : base( turnover)
        {
            base.DiscountRate = this.DiscountRate;
        }

        public new decimal DiscountRate
        {
            get 
            {
                this.discountRate = 2m / 100;

                if (this.Turnover >= 300)
                {
                    this.discountRate = 3.5m / 100;
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
