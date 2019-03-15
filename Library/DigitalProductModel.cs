using System;


namespace Library
{
    public class DigitalProductModel : IDigitalProductModel
    {
        public int TotalDownloadsLeft { get; private set; } = 5;

        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            // Interface doesn't lock you into only having what's in the contract
            if(HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing {Title} to {customer.EmailAddress}");
                TotalDownloadsLeft--;
                if(TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }
    }
}
