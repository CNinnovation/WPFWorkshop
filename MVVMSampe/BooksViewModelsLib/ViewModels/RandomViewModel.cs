using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksViewModelsLib.ViewModels
{
    public class Foo
    {

    }
    public class Bar
    {

    }

    public class RandomViewModel : ViewModelBase
    {
        public RandomViewModel()
        {
            Random r = new Random();
            int x = r.Next(3);
            if (x == 0)
            {
                _something = new Foo();
            }
            else
            {
                _something = new Bar();
            }
        }
        private object _something;
        public object Something
        {
            get { return _something; }
        }
    }
}
