using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public enum Size
    {
        XS,
        S,
        M,
        L,
        XL
    }

    class Clothes : Product
    {
        
        public string Colour { get; set; }
        public Size Size { get; set; }
        public  string ClothesName { get; set; }
        public string ClothesBrand { get; set; }
        public decimal ClothesPrice { get; set; }
      //  public int DiscountPercent; public decimal Discount; public string Color;
        //public DateTime ExpirationDate { get; set; }
       /*  public Clothes(string name, string brand, decimal price, Size size, int discountPercent , decimal discount, string color) : base(name, brand, price,discountPercent , discount)
           {
               Colour = color;
            this.Size = size;
            this.DiscountPercent = SetDiscountInPercent();
            this.Discount = Math.Round(Product.GetValueOfDiscount(Price, DiscountPercent), 2);
           }*/

        public Clothes(string name, string brand, decimal price, Size Size, string color) : base(name, brand, price)
        {
            Colour = color;
            this.Size = Size;
            this.DiscountPercent = SetDiscountInPercent();
            this.Discount = Math.Round(Product.GetValueOfDiscount(Price, DiscountPercent), 2);


        }
        /// <summary>
        /// default constructor
        /// </summary>
        public Clothes()
        {
            Size = Size.S;
            ClothesName = "";
            ClothesPrice = 0;
           ClothesBrand = "";
            DiscountPercent = 0;
            Discount = 0;
        }


        public override int SetDiscountInPercent()
        {
            DateTime dateOfPurchase = Cashier.dateOfPurchase;
            int discount = 0;



            if (dateOfPurchase.DayOfWeek is DayOfWeek.Monday || dateOfPurchase.DayOfWeek is DayOfWeek.Tuesday ||
                dateOfPurchase.DayOfWeek is DayOfWeek.Wednesday || dateOfPurchase.DayOfWeek is DayOfWeek.Thursday
                || dateOfPurchase.DayOfWeek is DayOfWeek.Friday)
            {
                discount = 10;

            }
                                   
            this.DiscountPercent = discount;
            return discount;
        }

        public override void PrintProduct()
        {
            Console.WriteLine(this.Name + " " + this.Brand + " " + this.Size + " " + this.Colour.ToLower());
            Console.WriteLine();

        }
    }
}
