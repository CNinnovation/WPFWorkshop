using MVVMSampe.ViewModels;
using System.Windows.Controls;
using Microsoft.Framework.DependencyInjection;

namespace MVVMSampe.Views
{
    /// <summary>
    /// Interaction logic for BookUC.xaml
    /// </summary>
    public partial class BookUC : UserControl
    {
        public BookUC()
        {
            InitializeComponent();
            this.DataContext = (App.Current as App).Container.GetService<BookViewModel>();
        }
    }
}
