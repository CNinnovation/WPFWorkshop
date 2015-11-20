using BooksViewModelsLib.ViewModels;
using MVVMSampe.Models;
using MVVMSampe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSampe.ViewModels
{
    public class BookViewModel : ViewModelBase
    {
        private readonly IBooksService _booksService;
        public BookViewModel(IBooksService booksService)
        {
            _booksService = booksService;

            Book = _booksService.GetBooks().First();
        }

        private Book _book;

        public Book Book
        {
            get { return _book; }
            set { SetProperty(ref _book, value); }
        }

    }
}
