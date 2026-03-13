namespace ProductApp.Services
{
    public interface IProductService
    {
        List<string> GetProducts();
    }

    public class IMessageService: IProductService
    {
        public List<string> GetProducts()
        {
            return new List<string> { "Laptop", "Phone", "Tablet" };
        }

    }
}
