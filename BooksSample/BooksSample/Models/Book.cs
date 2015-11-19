using System.Collections.Generic;
using TheBestAndCoolestMvvmFramework;

namespace BooksSample.Models
{
    public class Book : BindableBase
    {
        public Book()
        {

        }

        public Book(string isbn, string title, string publisher, params string[] authors)
        {
            Isbn = isbn;
            _title = title;
            _publisher = publisher;
            _authors = new List<string>(authors); 
        }

        public string Isbn { get; set; }

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private string _publisher;

        public string Publisher
        {
            get { return _publisher; }
            set { SetProperty(ref _publisher, value); }
        }

        private readonly IEnumerable<string> _authors;

        public IEnumerable<string> Authors
        {
            get { return _authors; }
        }



        public override string ToString() => Title;

    }
}
