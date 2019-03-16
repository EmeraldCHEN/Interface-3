using System;


namespace Library
{
    public class CourseProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if( HasOrderBeenCompleted == false)
            {
                Console.WriteLine();
                Console.WriteLine($"Sent the link of {Title} course to {customer.FirstName} {customer.LastName}'s account to {customer.EmailAddress}");               
            }
        }
    }
}
