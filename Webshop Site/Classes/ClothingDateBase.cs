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
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("Products");
            writer.WriteStartElement("Product");//<Product
            writer.WriteStartElement("Brand");
            writer.WriteString("Nike");
            writer.WriteEndElement();
            writer.WriteStartElement("Color");
            writer.WriteEndElement();
            writer.WriteString("Yellow");
            writer.WriteEndElement();
            writer.WriteStartElement("Price");
            writer.WriteEndElement();
            writer.WriteString("499");
            writer.WriteStartElement("Size");
            writer.WriteString("33");
            writer.WriteEndElement();
            writer.WriteStartElement("Type");
            writer.WriteString("1");
            writer.WriteEndElement();
            writer.Close();

        }






    }
}