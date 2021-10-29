using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Appliance : Product
    {
        public Appliance(string name, string brand, decimal price,
            string model, DateTime productionDate, string weight) : base(name, brand, price)
        {
            this.Model = model;
            this.ProductionDate = productionDate;
            this.Weight = weight;
            //  this.Price = Math.Round(price, 2);
            this.DiscountPercent = SetDiscountInPercent();
            this.Discount = Math.Round(Product.GetValueOfDiscount(Price, DiscountPercent), 2);
        }

        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public string Weight { get; set; }

        /// <summary>
        /// Overrides Product.SetDiscountInPercent(). There is a 5% discount on all appliances that cost above $999 and are purchased during the weekend
        /// </summary>
        /// <returns></returns>
        public override int SetDiscountInPercent()
        {
            DateTime dateOfPurchase = Cashier.dateOfPurchase;
            int discount = 0;
            if ((dateOfPurchase.DayOfWeek is DayOfWeek.Saturday
                || dateOfPurchase.DayOfWeek is DayOfWeek.Sunday) && this.Price > 999)
            {
                discount = 5;

            }

            this.DiscountPercent = discount;
            return discount;
        }
        public override void PrintProduct()
        {
            Console.WriteLine(this.Name + " " + this.Brand + " " + this.Model);
            Console.WriteLine();

        }
    }
}
