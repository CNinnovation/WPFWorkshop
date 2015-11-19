using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BooksSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Book _theBook;
        private ObservableCollection<Book> _books;

        public MainWindow()
        {
            InitializeComponent();
            // _theBook = new BooksRepository().GetTheBook();
            _books = new ObservableCollection<Book>(new BooksRepository().GetBooks());
            this.DataContext = _books;

            CollectionViewSource.GetDefaultView(_books).Filter = o => (o as Book)?.Publisher == "Wrox Press";
        }

        private void OnShowBook(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_theBook.Title, _theBook.Publisher);
        }

        private void OnChangeBook(object sender, RoutedEventArgs e)
        {
            _theBook.Title = "Professional C# 6";
        }

        private void OnAddBook(object sender, RoutedEventArgs e)
        {
            _books.Add(new Book { Isbn = "37475", Title = "Programming Windows Apps", Publisher = "Self" });
        }
    }
}
