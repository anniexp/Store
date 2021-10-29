using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class CartProduct
    {
        public decimal Quantity { get; set; }
        public Product Product { get; }
        //constructors
        public CartProduct()
        {
        }
        public CartProduct(Product product, decimal quantity)
        {
            this.Product = product;
            this.Quantity = SetQuantity();
        }

        /// <summary>
        /// sets the number of each product ( )
        /// </summary>
        /// <returns></returns>
        public static decimal SetQuantity()
        {

            decimal quantity;

            Random random = new Random();
            quantity = random.Next(1, 5);


            return quantity;
        }
        //virtual mwthod can be overrided
        /*public virtual decimal SumPrice(List<Product> listOfProducts)
        {
            decimal sum = 0;
            foreach (Product currentProduct in listOfProducts)
            {
                sum = sum + currentProduct.Price;
            }


            return sum;
        }*/
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        public static decimal SumP(CartProduct cart)
        {
            decimal sum;

            sum = cart.Quantity * cart.Product.Price;

            return sum;
        }
        /*  private static void IterateThruDictionary()

          {
              List<Product> listOfProducts = Program.listOfProducts;
              Dictionary<string, Element> elements = BuildDictionary(listOfProducts);

              foreach (KeyValuePair<string, Element> kvp in elements)
              {
                  Element theElement = kvp.Value;

                  Console.WriteLine("key: " + kvp.Key);
                  Console.WriteLine("values: " + theElement.Name + " " +
                      theElement.Name + " " + theElement.AtomicNumber);
              }
          }

          private static Dictionary<string, Element> BuildDictionary(List <Product> listOfProducts)
          {
              var elements = new Dictionary<string, Element>();



              for (int i = 0; i < listOfProducts.Count; i++)
              {
                 // AddToDictionary(elements, listOfProducts[i], 1);
              }
              return elements;
          }

          private static void AddToDictionary(Dictionary<string, Element> elements,
              string name, double quantity, int atomicNumber)
          {
              Element theElement = new Element();

              theElement.Name = name;
              theElement.Quantity = quantity;
              theElement.AtomicNumber = atomicNumber;

              elements.Add(key: theElement.Name, value: theElement);
          }


          public class Element : Product
          {
             // public 
              public double Quantity { get; set; }
              public int AtomicNumber { get; set; }

              public override int SetDiscountInPercent()
              {
                  throw new NotImplementedException();
              }
          }

          */

    }


}
