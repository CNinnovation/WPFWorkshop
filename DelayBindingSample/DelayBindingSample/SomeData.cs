using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelayBindingSample
{
    public class SomeData : INotifyPropertyChanged
    {
        private string text;

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                TextOut = text;
            }
        }

        private string _textOut;

        public string TextOut
        {
            get { return _textOut; }
            set
            {
                _textOut = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TextOut)));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
