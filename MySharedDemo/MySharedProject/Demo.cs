using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace MySharedProject
{
    public class Demo
    {
        public string Foo(string input)
        {
            return input.ToUpper();
        }

#if WPF
        public void Bar(string input)
        {
            MessageBox.Show(input);
        }
#endif
    }
}
