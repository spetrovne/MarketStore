using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public abstract class DiscountCard
    {
        private string owner;
        private decimal turnover;
        private decimal discountRate;

        public decimal DiscountRate
        {
            get { return discountRate; }
            set { discountRate = value; }
        }

        public DiscountCard(string owner, decimal turnover)
        {
            this.Owner = owner;
            this.Turnover = turnover;
            this.DiscountRate = 0;
        }

        public string Owner { get; }

        public decimal Turnover
        {
            get { return turnover; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("The turnover can't be negative");
                }
                turnover = value;
            }
        }

        public virtual void CalculateDiscountRate() { }
    }
}
