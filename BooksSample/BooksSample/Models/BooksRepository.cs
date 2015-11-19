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
                new Book
                {
                    Isbn = "34784",
                    Title = "Professional C# 5.0",
                    Publisher = "Wrox Press"
                },
                new Book
                {
                    Isbn = "37258345",
                    Title = "Enterprise Services",
                    Publisher = "AWL"
                },
                new Book
                {
                    Isbn = "5445466",
                    Title = "Professional C# 6 and .NET Core 5",
                    Publisher = "Wrox Press"
                }
            };
    }
}
