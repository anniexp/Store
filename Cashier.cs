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

        public static void PrintReceipt(List<CartProduct> listOfProducts, DateTime dateOfPurchase)
        {

           // Console.WriteLine("Date: " + dateOfPurchase.ToString("yyyy-MM-dd ") + dateOfPurchase.Hour + ":" + dateOfPurchase.Minute + ":" +  dateOfPurchase.Second);
            Console.WriteLine("Date: " + dateOfPurchase.ToString("yyyy-MM-dd HH:mm:ss ") );

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
                    Console.WriteLine("#discount {0}%  -${1}", cart.Product.DiscountPercent, cart.Product.Discount);
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

        }
        private static decimal SumSubtotal(List<CartProduct> listOfProducts)
        {
            decimal sumSubtotal = 0;
            foreach (CartProduct product in listOfProducts)
            {
                sumSubtotal = CartProduct.SumP(product) + sumSubtotal;
            }
            return sumSubtotal;
        }


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
