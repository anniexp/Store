using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Food : Product
    {
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// constructor, who inherites a constructor in the parent class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="brand"></param>
        /// <param name="price"></param>
        /// <param name="expirationDate"></param>
        public Food(string name, string brand, decimal price,
            DateTime expirationDate) : base(name, brand, price)
        {
            ExpirationDate = expirationDate;
            this.DiscountPercent = SetDiscountInPercent();
            //rounded to .00
            this.Discount = Math.Round(Product.GetValueOfDiscount(Price, DiscountPercent), 2);
            // DiscountPercent = SetDiscountInPercent;

        }
        /// <summary>
        /// Overrides Product.SetDiscountInPercent().  
        /// If perishable products are about to expire a discount is added - 10% if the expiration 
        /// date is within 5 days of the purchase date and 50% if the product expires at the date of purchase.
        /// </summary>
        /// <returns>discount percent</returns>
        public override int SetDiscountInPercent()
        {
            DateTime dateOfPurchase = Cashier.dateOfPurchase;
            int discount = 0;
            if (dateOfPurchase >= this.ExpirationDate.Date.AddDays(-5))
            {
                discount = 10;
                if (dateOfPurchase == this.ExpirationDate.Date)
                {
                    discount = 50;
                }
            }
            this.DiscountPercent = discount;
            return discount;
        }
        public override void PrintProduct()
        {
            //if the name is in plural verb - remove the s to make the mono
            if (this.Name.EndsWith("s"))
            {
                Name = this.Name.Remove(this.Name.Length - 1, 1);
            }
            Console.WriteLine(this.Name.ToLower() + " - " + this.Brand);
            Console.WriteLine();
        }
    }
}
