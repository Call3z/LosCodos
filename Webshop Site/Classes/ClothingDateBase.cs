using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webshop_Site.Interfaces;

namespace Webshop_Site.Classes
{
    public class ClothingDateBase : IClothingDataBase
    {
        public List<IProduct> wareHouse { get; set; }

        public void SetDummyShoes(Product list)
        {
            list.Brand = "Nike";
            list.Color = "Blå";
            list.Price = 299;
            list.Size = "42";
        }

        public void SetDummyShirts(Product list)
        {
            list.Brand = "Tiger of sweden";
            list.Color = "Svart";
            list.Price = 1500;
            list.Size = "M";
        }

        public void SetDummyPants(Product list)
        {
            list.Brand = "Crocker";
            list.Color = "Blå";
            list.Price = 250;
            list.Size = "30/32";
        }

        public List<IProduct> ShoesList;

    }
}