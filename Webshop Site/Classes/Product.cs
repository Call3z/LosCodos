﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webshop_Site.Interfaces;

namespace Webshop_Site.Classes
{
    public class Product : IProduct
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }

        public string Typ { get; set; }
    }
}