using MVVMSampe.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSampe.Services
{
    public class BooksService : IBooksService
    {
        private ObservableCollection<Book> _books;

        public BooksService()
        {
            _books = new ObservableCollection<Book>()
            {
                new Book("34784", "Professional C# 5.0", "Wrox Press", "Christian Nagel", "Morgan Skinner", "Jay Glynn"),
                new Book("37258345", "Enterprise Services", "AWL", "Christian Nagel"),
                new Book("5445466", "Professional C# 6 and .NET Core 5", "Wrox Press", "Christian Nagel")

            };
        }

        public IEnumerable<Book> GetBooks() => _books;       

        public Book GetBookByIsbn(string isbn) =>
            _books.SingleOrDefault(b => b.Isbn == isbn);

        public static BooksService Instance { get; } = new BooksService();

        public void AddNewBook()
        {
            _books.Add(new Book("init", "init", "init"));
        }
        
    }
}
