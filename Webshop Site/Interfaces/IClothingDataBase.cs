using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Webshop_Site.Interfaces
{
    public interface IClothingDataBase
    {
        //todo Path till "clothes.xml" eller vad nu databasen kan komma att heta?
        //todo Lista av IProduct??

        //todo om kläderna inte skall hårdkodas, kanske vi ska ha en GetClothesFromDatabase? där vi hämtar kläderna ur databasen och lägger in dem i Listan av IProduct?

        //todo En funktion som sparar ett objekt av IProduct till databasen? detta blir ju väldigt väsentligt om vi skall använda oss av admingränssnitt.
    }
}
