

namespace Library
{
    // implement the IProductModel to bring along its contract
    public interface IDigitalProductModel:IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
