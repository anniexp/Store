using System;
using System.Collections.Generic;

namespace Store
{

    class Program
    {
        public static DateTime dateOfPurchase;

        static void Main(string[] args)
        {
             dateOfPurchase = DateTime.Now.Date;
            //dateOfPurchase = DateTime.Now.AddDays(2);


            Clothes clothes1 = new Clothes("T-shirt", "Chanel", 1111.00M, Size.L, "red");
            Clothes clothes2 = new Clothes("T-shirt", "Chanel", 1121.99M, Size.M, "blue");
            Clothes clothes3 = new Clothes("dress", "Versache", 2211.11M, Size.S, "black");
            //Beverage bev1 = new Beverage("");

            Food food1 = new Food("Breads", "Zemel", 1.25M, new DateTime(2021, 10, 30));
            Food food2 = new Food("Sour milk", "Elena", 1.05M, new DateTime(2021, 11, 28));

            Beverage beverage1 = new Beverage("water", "Devin", 1.50M, new DateTime(2022, 02, 24));
            Appliance app1 = new Appliance("laptop", "BrandL", 2345M, "ModelL", new DateTime(2021, 03, 03), "1.125 kg");

            CartProduct prod1 = new CartProduct(clothes1, CartProduct.SetQuantity());
            CartProduct prod2 = new CartProduct(clothes2, CartProduct.SetQuantity());
            CartProduct prod3 = new CartProduct(clothes3, CartProduct.SetQuantity());
            CartProduct prod4 = new CartProduct(food1, CartProduct.SetQuantity());
            CartProduct prod5 = new CartProduct(food2, CartProduct.SetQuantity());
            CartProduct prod6 = new CartProduct(beverage1, CartProduct.SetQuantity());
            CartProduct prod7 = new CartProduct(app1, CartProduct.SetQuantity());

            List<CartProduct> cart = new List<CartProduct> { };
            cart.Add(prod1);
            cart.Add(prod2);
            cart.Add(prod3);
            cart.Add(prod4);
            cart.Add(prod5);
            cart.Add(prod6);
            cart.Add(prod7);

            Cashier.PrintReceipt(cart, dateOfPurchase);
            Console.ReadKey();


        }
    }
}
