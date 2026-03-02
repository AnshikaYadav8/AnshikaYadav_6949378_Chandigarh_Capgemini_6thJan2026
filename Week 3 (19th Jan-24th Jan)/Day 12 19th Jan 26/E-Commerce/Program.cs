using static System.Reflection.Metadata.BlobBuilder;

namespace E_Commerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Display();

            Console.WriteLine("1.Electronics 2.Clothing 3.Books");
            int choice = Convert.ToInt32(Console.ReadLine());

            Product product = null;

            switch (choice)
            {
                case 1:
                    product = new Electronics();
                    break;
                case 2:
                    product = new Clothing();
                    break;
                case 3:
                    product = new Books();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            product.AddProduct();
            product.ViewProduct();

            Cart cart = new Cart();
            cart.AddToCart(product);

            Order order = new Order();
            order.PlaceOrder(cart);
        }
    }
}
