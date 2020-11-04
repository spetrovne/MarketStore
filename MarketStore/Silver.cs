using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Silver : DiscountCard
    {
        public Silver(string owner, decimal turnover) : base(owner, turnover)
        {
            this.CalculateDiscountRate();//Calling the method here so that every time a new instace is made it has a proper discount rate
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
