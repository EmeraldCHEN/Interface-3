using System;


namespace Library
{
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if(HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping {Title} to {customer.FirstName} {customer.LastName} in {customer.City}");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
