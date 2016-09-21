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
            throw new NotImplementedException();
        }

        public List<IProduct> GetProducts()
        {
            throw new NotImplementedException();
        }

        public double GetTotalPrice()
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(int index)
        {
            throw new NotImplementedException();
        }
    }
}