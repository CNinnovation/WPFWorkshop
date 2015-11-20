using Microsoft.Practices.Prism.PubSubEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksViewModelsLib.Events
{
    public class SelectedBookEvent : EventArgs
    {
        public string Isbn { get; set; }
    }


    public class InitBookEvent : EventArgs
    {
        public string Isbn { get; set; }
    }
}
