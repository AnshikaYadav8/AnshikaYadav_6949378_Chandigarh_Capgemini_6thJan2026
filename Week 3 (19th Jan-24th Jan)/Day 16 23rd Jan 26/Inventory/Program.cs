namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> inventory = new List<Book>
        {
            new Book { Title = "Lord Of The Rings", Price = 500, Stock = 10 },
            new Book { Title = "The Belljar", Price = 300, Stock = 0 },
            new Book { Title = "Little Women", Price = 700, Stock = 5 }
        };
            inventory.Add(new Book { Title = "The Handmaiden", Price = 450, Stock = 8 });

            double targetPrice = 500;
            var cheapBooks = inventory.Where(b => b.Price < targetPrice);

            Console.WriteLine("Books cheaper than 500:");
            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title);

            inventory.ForEach(b => b.Price *= 1.10);

            inventory.RemoveAll(b => b.Stock == 0);

            Console.WriteLine("\nFinal Inventory:");
            foreach (var book in inventory)
                Console.WriteLine($"{book.Title} - {book.Price:F2} - Stock: {book.Stock}");
        }
    }
}
