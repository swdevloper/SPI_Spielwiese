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
    /// Interaction logic for f100BspSimple.xaml
    /// </summary>
    public partial class f100BspSimple : Window
    {

        private Window _callerWindow;

        public f100BspSimple()
        {
            InitializeComponent();
        }


        public f100BspSimple(Window f):this()
        {
            _callerWindow = f;

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _callerWindow.Show();
        }
    }
}
