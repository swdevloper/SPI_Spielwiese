using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for f120BspCollectionBinding.xaml
    /// </summary>
    public partial class f120BspCollectionBinding : Window
    {
        private Window _callerWindow;
        //List<Person> _personList;
        ObservableCollection<Person> _personList;

        public f120BspCollectionBinding()
        {
            InitializeComponent();

            //_personList = new List<Person>();
            _personList = new ObservableCollection<Person>();

            Person p1 = new Person { Name = "Marcel Butterweck", Email = "marcel.butterweck@butterweck.at", Phone = "+43 676" };
            Person p2 = new Person { Name = "Andrea Butterweck", Email = "andrea.butterweck@butterweck.at", Phone = "+43 676" };
            Person p3 = new Person { Name = "Luca Butterweck", Email = "luca.butterweck@butterweck.at", Phone = "+43 676" };
            _personList.Add(p1);
            _personList.Add(p2);
            _personList.Add(p3);

            lstPerson.ItemsSource = _personList;
            this.DataContext = _personList;

        }

        public f120BspCollectionBinding(Window f) : this()
        {
            _callerWindow = f;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Person p4 = new Person { Name = "Gina Butterweck", Email = "gina.butterweck@butterweck.at", Phone = "+43 676" };
            _personList.Add(p4);
        }
    }
}
