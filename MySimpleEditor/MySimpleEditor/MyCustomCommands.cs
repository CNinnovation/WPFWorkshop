using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MySimpleEditor
{
    public static class MyCustomCommands
    {
        public static RoutedUICommand MyAction { get; } = new RoutedUICommand(nameof(MyAction), nameof(MyAction), typeof(MyCustomCommands));
    }
}
