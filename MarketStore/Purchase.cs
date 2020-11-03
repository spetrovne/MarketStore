using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Purchase
    {
		private decimal price;
		private DiscountCard discount;

		public Purchase(decimal price, DiscountCard discount)
		{
			this.Price = price;
			this.Discount = discount;
		}

		public DiscountCard Discount
		{
			get { return discount; }
			set { discount = value; }
		}


		public decimal Price
		{
			get { return price; }
			set { price = value; }
		}

		public override string ToString()
		{
			var theDiscount = this.Discount.CalculateDiscount(price);
			var discountRate = this.Discount.DiscountRate*100;
			var str = $"Purchase value: {this.price}" + Environment.NewLine
				+ $"Discount rate: {discountRate:f1}%" + Environment.NewLine
				+ $"Discount: {theDiscount:f2}" + Environment.NewLine
				+ $"Total: {(price-theDiscount):f2}"
				;
			return str;
		}

	}
}
