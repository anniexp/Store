using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Cashier
    {
        public static DateTime dateOfPurchase = Program.dateOfPurchase;
        public Cashier()
        {

        }
        /// <summary>
        /// Method to print a receipt -  prints all purchased products with their price, quantity, the total sum and the total discount 
        /// </summary>
        /// <param name="listOfProducts"> cart (collection of cart products) </param>
        /// <param name="dateOfPurchase">  the date and time of purchase</param>
        public static void PrintReceipt(List<CartProduct> listOfProducts, DateTime dateOfPurchase)
        {

            // Console.WriteLine("Date: " + dateOfPurchase.ToString("yyyy-MM-dd ") + dateOfPurchase.Hour + ":" + dateOfPurchase.Minute + ":" +  dateOfPurchase.Second);
            Console.WriteLine("Date: " + dateOfPurchase.ToString("yyyy-MM-dd HH:mm:ss "));

            Console.WriteLine();

            Console.WriteLine("---Products---");
            Console.WriteLine();



            foreach (CartProduct cart in listOfProducts)
            {
                Console.WriteLine();

                cart.Product.PrintProduct();
                Console.WriteLine(cart.Quantity + " x $" + cart.Product.Price + " = $" + CartProduct.SumP(cart));
                Console.WriteLine();
                if (cart.Product.Discount != 0)
                {
                    Console.WriteLine("#discount {0}% -${1}", cart.Product.DiscountPercent, cart.Product.Discount);
                    Console.WriteLine();

                }

            }

            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("SUBTOTAL: $" + SumSubtotal(listOfProducts));

            Console.WriteLine("DISCOUNT: -$" + SumDiscount(listOfProducts));
            decimal total = SumSubtotal(listOfProducts) - SumDiscount(listOfProducts);
            Console.WriteLine();
            Console.WriteLine("TOTAL: $" + total);

        }/// <summary>
         /// Calculates the total sum of all products in the cart in $
         /// </summary>
         /// <param name="listOfProducts">cart</param>
         /// <returns>sum of all products</returns>
        private static decimal SumSubtotal(List<CartProduct> listOfProducts)
        {
            decimal sumSubtotal = 0;
            foreach (CartProduct product in listOfProducts)
            {
                sumSubtotal = CartProduct.SumP(product) + sumSubtotal;
            }
            return sumSubtotal;
        }
        /// <summary>
        /// Calculates the total discount of the products in the cart, as it sums all the discounts of the products in the cart
        /// </summary>
        /// <param name="listOfProducts">cart</param>
        /// <returns>the whole discount</returns>
        private static decimal SumDiscount(List<CartProduct> listOfProducts)
        {
            decimal sumDiscount = 0;
            foreach (CartProduct product in listOfProducts)
            {
                sumDiscount = product.Product.Discount + sumDiscount;
            }
            return sumDiscount;
        }
    }
}
