using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPI_Spielwiese
{
    public class Person: INotifyPropertyChanged
    {
        private string _name;
        private string _email;
        private string _phone;
        private int _age;

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged(string propertyName)
        {
            //var pc = PropertyChanged;
            //if(pc!=null)
            //{
            //    pc(this, new PropertyChangedEventArgs(propertyName));
            //}
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }



        public string Name
        {
            get { return _name; }
            set { 
                _name = value;
                OnPropertyChanged("Name");
                }
        }
        public string Email
        {
            get { return _email; }
            set { 
                _email = value;
                OnPropertyChanged("Email");
                }
        }
        public string Phone
        {
            get { return _phone; }
            set { 
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }
        public int Age
        {
            get { return _age; }
            set {
                if(value>=0)
                {
                    _age = value;
                    OnPropertyChanged("Age");
                }
            }
        }


    }
}
