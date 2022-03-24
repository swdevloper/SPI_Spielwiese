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
    /// Interaction logic for f140BspStyles.xaml
    /// </summary>
    public partial class f140BspStyles : Window
    {
        private Window _callerWindow;

        public f140BspStyles()
        {
            InitializeComponent();
        }


        public f140BspStyles(Window f) : this()
        {
            _callerWindow = f;
        }
    }
}
