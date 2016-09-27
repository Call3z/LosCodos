using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using Webshop_Site.Database;
using Webshop_Site.Enums;
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

        XmlDocument reader = new XmlDocument();

        public List<IProduct>ProductShoesList()
        {
            List<IProduct> temp = new List<IProduct>();         
            reader.Load(Constants.PathToProductDatabaseXml());
            foreach (XmlNode node in reader.SelectNodes("Products/Product"))
            {
                IProduct product = new Product();
                product.Brand = node.SelectSingleNode("Brand").InnerText;
                product.Color = node.SelectSingleNode("Color").InnerText;
                product.Price = int.Parse(node.SelectSingleNode("Price").InnerText);              
                product.Size = node.SelectSingleNode("Size").InnerText;
                product.Type = (ProductType) Convert.ToInt32(node.SelectSingleNode("Type").InnerText);

                temp.Add(product);
            }

            return temp;

        }

       
        



    }
}