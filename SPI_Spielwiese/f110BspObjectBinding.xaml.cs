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
using System.Windows.Shapes;

namespace SPI_Spielwiese
{
    /// <summary>
    /// Interaction logic for f110BspObjectBinding.xaml
    /// </summary>
    public partial class f110BspObjectBinding : Window
    {
        private Window _callerWindow;
        private Person _person;

        public f110BspObjectBinding()
        {
            InitializeComponent();
        }

        public f110BspObjectBinding(Window f):this()
        {
            _callerWindow = f;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _callerWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Person p = new Person { Name = "Marcel Butterweck", Email = "marcel.butterweck@butterweck.at", Phone = "+43 676" };
            _person = p;

            this.DataContext = _person;
            
        }

        private void btnAddYears_Click(object sender, RoutedEventArgs e)
        {
            //this.txbAge.Text = (Convert.ToInt32(this.txbAge.Text) + 1).ToString();
            _person.Age++;
        }

        private void btnSubstractYears_Click(object sender, RoutedEventArgs e)
        {
            _person.Age--;
        }
    }
}
