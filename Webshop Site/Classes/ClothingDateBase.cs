using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


        XmlDocument reader = new XmlDocument();

        public List<IProduct>GetProducts()
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

        public void AddProduct()
        {
            XmlTextWriter writer = new XmlTextWriter(Constants.PathToProductDatabaseXml(), Encoding.UTF8);
            writer.WriteStartElement("Products");
            writer.WriteStartElement("Product");//<Product
            writer.WriteStartElement("Brand");
            writer.WriteString("Nike");
            writer.WriteStartElement("Color");
            writer.WriteString("Yellow");
            writer.WriteStartElement("Price");
            writer.WriteString("499");
            writer.WriteStartElement("Size");
            writer.WriteString("33");
            writer.WriteStartElement("Type");
            writer.WriteString("1");
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.Close();

        }






    }
}