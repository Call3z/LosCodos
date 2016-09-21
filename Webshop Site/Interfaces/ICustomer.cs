using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webshop_Site.Interfaces
{
    public class ICustomer
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string ZipCode { get; set; }
    }
}