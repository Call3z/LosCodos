using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webshop_Site.Interfaces
{
     interface ICart
     {
         List<IProduct> Products { get; set; }
         
        void AddProduct(IProduct product);
        List<IProduct> GetProducts();
        double GetTotalPrice();
        void RemoveProduct(int index);
    }

}