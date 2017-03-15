using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webshop_Site.Enums;
using Webshop_Site.Interfaces;

namespace Webshop_Site.Classes
{
    public class CheckOut : ICheckOut
    {


        //todo calle: lägg varukorgen i en session/cache
        

        //todo ta bort varukorgen från session/cache
        
        //public ICart cart { get; set; }

        public ICart GetCart()
        {
            ICart cart = new Cart();

            IProduct product1 = new Product();
            product1.Brand = "Nike";
            product1.Price = 130;
            product1.Color = "Black";
            product1.Size = "43";
            product1.Type = ProductType.Shoe;

            IProduct product2 = new Product();
            product2.Brand = "Addidas";
            product2.Price = 140;
            product2.Color = "White";
            product2.Size = "45";
            product2.Type = ProductType.Shoe;

            IProduct product3 = new Product();
            product3.Brand = "Reebok";
            product3.Price = 150;
            product3.Color = "Blue";
            product3.Size = "42";
            product3.Type = ProductType.Shoe;

            cart.AddProduct(product1);
            cart.AddProduct(product2);
            cart.AddProduct(product3);

            return cart;
        }


        //public string receipt()
        //{
        //    var createreceit = cart.GetProducts();
        //    StringBuilder sb = new StringBuilder();

        //    sb.Append("You have bought: ");
        //    for (int i = 0; i < createreceit.Count; i++)     
        //    {

        //        sb.Append(createreceit.ElementAt(i).Brand + " " + createreceit.ElementAt(i).Price + " \n");
        //    }
        //    sb.Append($"Total Price: {cart.GetTotalPrice().ToString()}");
        //    return sb.ToString();
        //}
    }
}