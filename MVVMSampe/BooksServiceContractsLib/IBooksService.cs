using System.Collections.Generic;
using MVVMSampe.Models;

namespace MVVMSampe.Services
{
    public interface IBooksService
    {
        void AddNewBook();
        Book GetBookByIsbn(string isbn);
        IEnumerable<Book> GetBooks();
    }
}