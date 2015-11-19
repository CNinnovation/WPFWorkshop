using System;
using System.Collections.Generic;
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

namespace EventSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OuterButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("outer");
            e.Handled = true;
        }

        private void InnerButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("inner");
        }

        private void OnStackPanelButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("stackpanel button click");
        }
    }
}
