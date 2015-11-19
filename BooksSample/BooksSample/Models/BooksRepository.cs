using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Models
{
    public class BooksRepository
    {
        public Book GetTheBook() =>
            new Book
            {
                Isbn = "34784",
                Title = "Professional C# 5.0",
                Publisher = "Wrox Press"
            };


        public IEnumerable<Book> GetBooks() =>
            new List<Book>()
            {
                new Book("34784", "Professional C# 5.0", "Wrox Press", "Christian Nagel", "Morgan Skinner", "Jay Glynn"),
                new Book("37258345", "Enterprise Services", "AWL", "Christian Nagel"),
                new Book("5445466", "Professional C# 6 and .NET Core 5", "Wrox Press", "Christian Nagel")

            };
    }
}
