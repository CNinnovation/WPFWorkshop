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

namespace FirstWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Canvas.SetLeft(button1, 200);
        }

        //public int MyProperty { get; set; }
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}



        public int MySimple
        {
            get { return (int)GetValue(MySimpleProperty); }
            set { SetValue(MySimpleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MySimple.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MySimpleProperty =
            DependencyProperty.Register("MySimple", typeof(int), typeof(MainWindow), new PropertyMetadata(0));



    }
}
