using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BooksSample.Utilities
{
    public class BookTemplateSelector : DataTemplateSelector
    {
        public DataTemplate WroxBookTemplate { get; set; }
        public DataTemplate DefaultBookTemplate { get; set; }


        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            DataTemplate selectedTemplate = null;

            var b = item as Book;
            if (b != null)
            {
                switch (b.Publisher)
                {
                    case "Wrox Press":
                        selectedTemplate = WroxBookTemplate;
                        break;
                    default:
                        selectedTemplate = DefaultBookTemplate;
                        break;
                }
            }

            return selectedTemplate;
        }
    }
}
