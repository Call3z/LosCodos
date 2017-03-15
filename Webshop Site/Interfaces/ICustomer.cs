namespace Webshop_Site.Interfaces
{
    public interface ICustomer
    {
        string Address { get; set; }
        string City { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string Phone { get; set; }
        string SocialSecurityNumber { get; set; }
        string ZipCode { get; set; }

    }
}