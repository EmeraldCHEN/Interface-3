using System;
using System.Collections.Generic;

using Library; // Must add Library as a reference
               // Library's output type should be Class Library


// An interface is a contract that any class that implements this will have

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use interface as the variable type then that variable will be able to directly access anything the contract specifies
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach(IProductModel product in cart)
            {
                product.ShipItem(customer);
                // checking if a type implements an interface IDigitalProductModel
                 Console.WriteLine($"check the value of this first : {product is IDigitalProductModel digital}");
               // if (product is IDigitalProductModel digital)
             //   {
             //       Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left.");
             //   }
              //  Console.ReadLine();
            }

        }
        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                City = "Scranton",
                EmailAddress = "tim@IAmTimCorey.com",
                PhoneNumber = "555-1212"
            };
        }
        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();
            output.Add(new PhysicalProductModel { Title = "Football" });
            output.Add(new PhysicalProductModel { Title = "T-Shirt" });
            output.Add(new DigitalProductModel { Title = "Source Code" });

            return output;
        }
    }
}
