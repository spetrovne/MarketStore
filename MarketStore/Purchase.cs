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
            var theDiscount = this.CalculateDiscount(price);
            var totalPrice = CalculatePriceAfterDiscount(price);            
            var discountRate =this.Discount.DiscountRate*100;
            var type = this.Discount.GetType().Name;
            var str = $"1. {type}: " + Environment.NewLine
                + $"Purchase value: {this.price}" + Environment.NewLine
                + $"Discount rate: {discountRate:f1}%" + Environment.NewLine
                + $"Discount: {theDiscount:f2}" + Environment.NewLine
                + $"Total: {totalPrice:f2}"
                ;
            return str;
        }

        public decimal CalculatePriceAfterDiscount(decimal purchasePrice)
        {
            var theDiscount = this.CalculateDiscount(price);
            return purchasePrice -theDiscount;
        }

        public decimal CalculateDiscount(decimal purchasePrice)
        {
            return purchasePrice * this.Discount.DiscountRate;
        }

    }
}
