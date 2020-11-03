using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Bronze : DiscountCard
    {
        private decimal discountRate;

        public Bronze(decimal turnover) : base(turnover)
        {
            base.DiscountRate = this.DiscountRate;
        }

        public new decimal DiscountRate
        {
            get 
            {

                if (this.Turnover < 100)
                {
                    this.discountRate = 0;
                }
                else if (this.Turnover >= 100 && this.Turnover <= 300)
                {
                    this.discountRate = 1m / 100;
                }
                else if (this.Turnover > 300)
                {
                    this.discountRate = 2.5m / 100;

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
