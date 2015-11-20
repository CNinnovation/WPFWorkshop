using BooksViewModelsLib.Events;
using BooksViewModelsLib.ViewModels;
using Microsoft.Practices.Prism.Commands;
using MVVMSampe.Models;
using MVVMSampe.Services;
using MyEventAggregator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSampe.ViewModels
{
    public class BooksViewModel : ViewModelBase
    {
        private readonly IMessagingService _messagingService;
        private readonly IBooksService _booksService;
        public BooksViewModel(IBooksService booksService, IMessagingService messagingService)
        {
            _booksService = booksService;
            _messagingService = messagingService;
            NewBookCommand = new DelegateCommand(OnNewBook);

            EventAggregator<InitBookEvent>.Instance.Event += OnInitBook;


        }

        private void OnInitBook(object arg1, InitBookEvent arg2)
        {
            Book initBook = _booksService.GetBookByIsbn(arg2.Isbn);
            SelectedBook = initBook;
        }

        public IEnumerable<Book> Books => _booksService.GetBooks();


        public DelegateCommand NewBookCommand { get; }

        public void OnNewBook()
        {
            _booksService.AddNewBook();
            _messagingService.ShowMessage("created a new book");
        }

        private Book _selectedBook;

        public Book SelectedBook
        {
            get { return _selectedBook; }
            set {
                SetProperty(ref _selectedBook, value);
                EventAggregator<SelectedBookEvent>.Instance.Publish(this, new SelectedBookEvent() { Isbn = _selectedBook.Isbn });
            }
        }



    }
}
