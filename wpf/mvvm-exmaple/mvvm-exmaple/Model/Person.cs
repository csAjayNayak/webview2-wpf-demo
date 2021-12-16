using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_exmaple.Model
{
    public class Person : INotifyPropertyChanged, IDataErrorInfo
    {
        private string fname;

        public string Fname
        {
            get { return fname; }
            set { fname = value;
                //OnPropertyChanged(Fname); 
            }
        }


        private string lname;

        public string Lname
        {
            get { return lname; }
            set { lname = value;
                // OnPropertyChanged(Lname); 
            }
        }


        private string fullName;


        public string Fullname
        {
            get { return Fname + " " + Lname; }
            set { fullName = value; }
        }

        public DateTime DateAdded { get; set; }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string propertyName] {
            get
            {
                string result = String.Empty;

                switch (propertyName)
                {
                    case "Fname":
                        if (string.IsNullOrEmpty(Fname))
                            result = "First Name is required !!"; 
                            break;

                    case "Lname":
                        if (string.IsNullOrEmpty(Lname))
                            result = "Last Name is required !!";
                        break;
                   
                }

                return result;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
            {
                ph(this,new PropertyChangedEventArgs(p));
            }
        }


    }
}
