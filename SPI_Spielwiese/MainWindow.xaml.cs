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

namespace SPI_Spielwiese
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

        private void btnBindingSimple_Click(object sender, RoutedEventArgs e)
        {

            //f100BspSimple f = new f100BspSimple();
            //Zweiter Konstruktor zur Übergabe von Daten
            f100BspSimple f = new f100BspSimple(this);

            f.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Hide();
            f.Show();

        }

        private void btnBindingObject_Click(object sender, RoutedEventArgs e)
        {
            f110BspObjectBinding f = new f110BspObjectBinding(this);
            f.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Hide();
            f.Show();
        }

        private void btnBindingCollection_Click(object sender, RoutedEventArgs e)
        {
            f120BspCollectionBinding f = new f120BspCollectionBinding(this);
            f.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Hide();
            f.Show();
        }

        private void btnBindingConverter_Click(object sender, RoutedEventArgs e)
        {
            f130BspConverter f = new f130BspConverter(this);
            f.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Hide();
            f.Show();
        }

        private void btnStyles_Click(object sender, RoutedEventArgs e)
        {
            f140BspStyles f = new f140BspStyles(this);
            f.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Hide();
            f.Show();
        }
    }
}
