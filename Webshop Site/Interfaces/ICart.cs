using System.Collections.Generic;

namespace Webshop_Site.Interfaces
{
    public interface ICart
    {
        List<IProduct> Products { get; set; }
         
        void AddProduct(IProduct product);
        List<IProduct> GetProducts();
        double GetTotalPrice();
        void RemoveProduct(int index);
         
    }

}