using mvvm_exmaple.Command;
using mvvm_exmaple.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mvvm_exmaple.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person _person;

        public Person Person
        {
            get { return _person; }
            set { _person = value; OnPropertyChanged("Person"); }
        }

        public PersonViewModel()
        {
            Person = new Person();
            Persons = new ObservableCollection<Person>();
        }

        private ObservableCollection<Person> _persons;

        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; OnPropertyChanged("Persons"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;



        private ICommand _SummitCommnd;
        public ICommand  SummitCommnd
        {
            get { 
                if(_SummitCommnd == null)
                {
                    _SummitCommnd = new RelayCommand(SubmitExecute, CanSubmitExecute, false);
                }

                return _SummitCommnd;
            }
           
        }

        private void SubmitExecute(object parameter)
        {
            Persons.Add(Person);
        }


        private bool CanSubmitExecute(object parameter)
        {
            if(string.IsNullOrEmpty(Person.Fname) || string.IsNullOrEmpty(Person.Lname))
            {
                return false; 
            }
            else
            {
                return true;
            }
        }



        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
