namespace Webshop_Site.Interfaces
{
    interface IProduct
    {
        string Brand { get; set; }
        string Color { get; set; }
        double Price { get; set; }
        string Size { get; set; }
    }
}
