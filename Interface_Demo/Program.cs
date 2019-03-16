using System;
using System.Collections.Generic;

using Library; // Must add Library as a reference
               // Library's output type should be Class Library


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // An interface is a contract that any class that implements this will have

            // Use interface as the variable type then that variable will be able to directly access anything the contract specifies
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach(IProductModel product in cart)
            {
                product.ShipItem(customer);
                Console.WriteLine();

                // checking if a type implements an interface IDigitalProductModel
                if (product is IDigitalProductModel digitalProduct)
                {
                    Console.WriteLine($"For the {digitalProduct.Title} you have {digitalProduct.TotalDownloadsLeft} downloads left.");
                }
                // Console.ReadLine(); foreach loop would stop here to wait for user input, so must pay attention to detail
            }
            Console.ReadLine();
        }
        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Emerald",
                LastName = "C",
                City = "CH",
                EmailAddress = "emerald@IAmEmerald.com",
                PhoneNumber = "123-456"
            };
        }
        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();
            output.Add(new PhysicalProductModel { Title = "Football" });
            output.Add(new PhysicalProductModel { Title = "T-Shirt" });
            output.Add(new DigitalProductModel { Title = "Source Code" });
            output.Add(new CourseProductModel { Title = ".NET Core" });

            return output;
        }
    }
}
