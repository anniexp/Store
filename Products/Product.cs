using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public abstract class Product
    {
        //properties
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int DiscountPercent { get; set; }
        public decimal Discount { get; set; }

        //constructors
        /* protected Product(string name, string brand, decimal price, int discountPercent, decimal discount)

         {
             this.Name = name;
             this.Brand = brand;
             this.Price = Math.Round(price, 2);
             this.DiscountPercent = discountPercent;
             this.Discount = Math.Round(discount, 2);
             //this.Discount = GetValueOfDiscount(price, discountPercent);
         }
        */
        protected Product(string name, string brand, decimal price)

        {
            this.Name = name;
            this.Brand = brand;
            this.Price = Math.Round(price, 2);

            //this.Discount = GetValueOfDiscount(price, discountPercent);
        }
        public Product()
        {

            Name = "";
            Price = 0;
            Brand = "";
            DiscountPercent = 0;
            Discount = 0;
        }

        /// <summary>
        /// abstract method for calculating discount percent - must be overrided in each child class
        /// </summary>
        /// <returns>discount in percent</returns>
        public abstract int SetDiscountInPercent();
        /// <summary>
        /// Gets the value of the discount. Equals original price * discount in percents / 100
        /// </summary>
        /// <param name="price">original price </param>
        /// <param name="discount">discount in percent</param>
        /// <returns> discount in lv</returns>
        public static decimal GetValueOfDiscount(decimal price, int discountInPercent)
        {
            decimal discount;
            //x - x*y/100 (new price = old price - discount)
            discount = (discountInPercent * price) / 100;

            return discount;
        }

        public abstract void PrintProduct();

    }
}
