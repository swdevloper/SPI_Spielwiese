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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace SPI_Spielwiese
{
    /// <summary>
    /// Interaction logic for f150BspCommands.xaml
    /// </summary>
    public partial class f150BspCommands : Window
    {

        private Window _callerWindow;




        public f150BspCommands()
        {
            InitializeComponent();

        }

        public f150BspCommands(Window f) : this()
        {
            _callerWindow = f;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New document", "New", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            DialogResult result= MessageBox.Show("Exit App?", "Exit", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(result==System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void CloseCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void InfoCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {


        }

        private void InfoCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
