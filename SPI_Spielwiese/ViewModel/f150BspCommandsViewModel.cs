using SPI_Spielwiese.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPI_Spielwiese.ViewModel
{
    public class f150BspCommandsViewModel
    {

        public string WindowTitle { get; set; }


        public RelayCommand EditCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }




        public f150BspCommandsViewModel()
        {

            WindowTitle = "Beispiel für Commands";

            EditCommand = new RelayCommand(c => { EditItem(); }, c => true );
            DeleteCommand = new RelayCommand(c => { DeleteItem(); }, c => false);


        }




        public void EditItem()
        {
            MessageBox.Show("Edit");
        }

        public void DeleteItem()
        {
            MessageBox.Show("Delete");
        }






    }
}
