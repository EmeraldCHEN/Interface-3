using System;

namespace Library
{
    // Ctrl + . --> Extract Interface
    public class CustomerModel : ICustomerModel
    {
        public string City { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
    }
}
