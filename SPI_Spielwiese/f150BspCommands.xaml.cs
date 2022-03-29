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

        public delegate decimal Berechnung(decimal zahl1, decimal zahl2);


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
            //Anonyme Klasse
            var p = new { Vorname = "Marcel", Nachname = "Butterweck", Email = "marcel.butterweck@butterweck.at" };
            MessageBox.Show(p.Vorname, "New", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information);

            List<Person> _personList = new List<Person>();
            Person p1 = new Person { Name = "Marcel Butterweck", Email = "marcel.butterweck@butterweck.at", Phone = "+43 676", Age = 13 };
            Person p2 = new Person { Name = "Andrea Butterweck", Email = "andrea.butterweck@butterweck.at", Phone = "+43 676", Age = 18 };
            Person p3 = new Person { Name = "Luca Butterweck", Email = "luca.butterweck@butterweck.at", Phone = "+43 676", Age = 25 };
            _personList.Add(p1);
            _personList.Add(p2);
            _personList.Add(p3);

            //Liste mit anonymer Klasse
            var emailList = _personList.Select(pe => new { Mail = pe.Email, Telefon = pe.Phone });
            MessageBox.Show(emailList.Count().ToString(), "Anzahl E-Mail Empfänger", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Liste mit definierter Klasse
            var emailList2 = _personList.Select(pe => new EMail { Mail = pe.Email});
            MessageBox.Show(emailList.Count().ToString(), "Anzahl E-Mail Empfänger", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information);


            //Delegate
            Berechnung rechne = new Berechnung(Addiere);
            decimal summe = rechne(2m, 3m);

            rechne = new Berechnung(Subtrahiere);
            decimal differenz = rechne(2m, 3m);

            rechne = new Berechnung(Multipliziere);
            decimal produkt = rechne(2m, 3m);

            //Vordefinierte Delegates
            //Action() => void als Rückgabewert und bis zu 16 Inputparamter
            //Func() => Rückgabewert ist beliebig und bis zu 16 Inputparameter
            //Predicate() => Rückgabewert ist Bool und 1 generischer Inputparameter

            Func<DateTime> calculateNextWeekDay = () => { return DateTime.Now.AddDays(7); };
            
            
            DateTime nextWeekDay = calculateNextWeekDay();
            MessageBox.Show(nextWeekDay.ToString(), "Tag in der nächste Woche", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            Func<Person, bool> isTeenager = (pers) => {return pers.Age > 12 && pers.Age < 20;};


            List<Person> teenagerList = _personList.Where(isTeenager).ToList();
            foreach (var teenager in teenagerList)
            {
                MessageBox.Show(teenager.Name, "Teenager", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            List<Person> teenagerList2 = _personList.Where(perso => perso.Age >12 && perso.Age < 20).ToList();
            foreach (var teenager in teenagerList)
            {
                MessageBox.Show(teenager.Name, "Teenager", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }


        private bool IsTeenagerAsMethode(Person pers)
        {
            return pers.Age > 12 && pers.Age < 20;
        }


        private void InfoCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }


        public decimal Addiere(decimal n1, decimal n2)
        {
            return n1 + n2;
        }
        public decimal Subtrahiere(decimal n1, decimal n2)
        {
            return n1 - n2;
        }
        public decimal Multipliziere(decimal n1, decimal n2)
        {
            return n1 * n2;
        }

    }
}
