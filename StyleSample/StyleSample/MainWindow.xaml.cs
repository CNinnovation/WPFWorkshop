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

namespace StyleSample
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

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            GradientStop[] gradientStops = new GradientStop[]
            {
                new GradientStop(Colors.DarkGreen, 0),
                new GradientStop(Colors.White, 1)
            };
            this.Resources["myBrush"] = new LinearGradientBrush(
                new GradientStopCollection(gradientStops));
        }

        private void OnAnotherButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("button clicked");
        }
    }
}
