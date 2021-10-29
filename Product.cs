using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public abstract class Product
    {

        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int DiscountPercent { get; set; }
        public decimal Discount { get; set; }

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
            this.Price = Math.Round(price,2);

            //this.Discount = GetValueOfDiscount(price, discountPercent);
        }
        public Product() {

            Name = "";
            Price = 0;
            Brand = "";
            DiscountPercent = 0;
            Discount = 0;
        }
    



        // Implementation of IEquatable<T> interface
      /*  public bool Equals(Product product)
        {
            return (this.Name, this.Brand, this.Price, this.Discount) ==
                (product.Name, product.Brand, product.Price, product.Discount);
        }*/


        /// <summary>
        /// 
        /// </summary>
        /// <returns>discount in percent</returns>
        public abstract int SetDiscountInPercent();
        /// <summary>
        /// 
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
        
        

        //must be overide
        // public abstract int SetDiscount();


    }
}
