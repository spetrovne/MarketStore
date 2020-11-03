using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class DiscountCard
    {
		private string owner;		
		private decimal turnover;
		private decimal discountRate;

		public decimal DiscountRate
		{
			get { return discountRate; }
			set { discountRate = value; }
		}

		public DiscountCard( decimal turnover)
		{
			
			this.Turnover = turnover;
			
		}

		public string Owner
		{
			get { return owner; }
			set { owner = value; }
		}
	
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

		public virtual decimal CalculateDiscount(decimal purchasePrice) 
		{
			return purchasePrice;
		}

		
	}
}
