using LibraryManagement_DI.Models;

namespace LibraryManagement_DI.Repositories
{
    public class BookRepository:IBookRepository
    {
        private List<Book> books = new List<Book>
        {
            new Book{ Id=1, Title="Harry Potter", Author="J K Rowling"},
            new Book{ Id=2, Title="Lord of The Rings", Author="J R R Tolkien"},
            new Book{ Id=3, Title="The Housemaid", Author="Freida Mcfadden"}
        };

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
    }
}
