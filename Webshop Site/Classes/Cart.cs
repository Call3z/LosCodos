using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webshop_Site.Interfaces;

namespace Webshop_Site.Classes
{
    public class Cart: ICart
    {
        public List<IProduct> Products { get; set; }
        public void AddProduct(IProduct product)
        {
            Products.Add(product);
        }

        public List<IProduct> GetProducts()
        {
            return Products;
        }

        public double GetTotalPrice()
        {
            double sum = 0;
            foreach (var product in Products)
            {
                sum += product.Price;
            }
            return sum;


        }

        public void RemoveProduct(int index)
        {
            Products.RemoveAt(index);
        }
    }
}