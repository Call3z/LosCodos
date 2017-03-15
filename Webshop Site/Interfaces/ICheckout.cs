using System.Collections.Generic;
using Webshop_Site.Classes;

namespace Webshop_Site.Interfaces
{
    public interface ICheckOut
    {
        

        ICart GetCart();
        
    }
}