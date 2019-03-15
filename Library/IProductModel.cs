

namespace Library
{
    public interface IProductModel
    {
        // An interface is a contract so everything in it is public
        string Title { get; set; }
        bool HasOrderBeenCompleted { get;}
        void ShipItem ( CustomerModel customer );
    }
}
