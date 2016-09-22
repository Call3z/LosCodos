using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Webshop_Site.Classes;


namespace Webshop_Site.Interfaces
{
    public interface IClothingDataBase
    {

        List<IProduct> ProductShoesList();

        //todo Path till "clothes.xml" eller vad nu databasen kan komma att heta?
        //todo Lista av IProduct??
        List<IProduct> wareHouse { get; set; }

        //todo om kläderna inte skall hårdkodas, kanske vi ska ha en GetClothesFromDatabase? där vi hämtar kläderna ur databasen och lägger in dem i Listan av IProduct?
        void SetDummyShoes(Product list);
        void SetDummyShirts(Product list);
        void SetDummyPants(Product list);
        //todo En funktion som sparar ett objekt av IProduct till databasen? detta blir ju väldigt väsentligt om vi skall använda oss av admingränssnitt.
        //todo Användaren ska ha en funktion som kan hantera alt. spara användaren.
    }
   // public interface I




}
