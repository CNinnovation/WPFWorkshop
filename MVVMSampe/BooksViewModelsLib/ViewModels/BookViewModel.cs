using BooksViewModelsLib.Events;
using BooksViewModelsLib.ViewModels;
using MVVMSampe.Models;
using MVVMSampe.Services;
using MyEventAggregator;
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

            EventAggregator<SelectedBookEvent>.Instance.Event += SelectedBookChanged;

            Book = _booksService.GetBooks().Skip(1).First();
            EventAggregator<InitBookEvent>.Instance.Publish(this, new InitBookEvent() { Isbn = Book.Isbn });

        }

        private void SelectedBookChanged(object arg1, SelectedBookEvent arg2)
        {
           Book = _booksService.GetBookByIsbn(arg2.Isbn);
        }

        private Book _book;

        public Book Book
        {
            get { return _book; }
            set { SetProperty(ref _book, value); }
        }

    }
}
