using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliverCode.MVVM.Model
{
        internal class PersonModel : System.ComponentModel.INotifyPropertyChanged
        {
            private string firstName;
            public string FirstName
            {
                get { return firstName; }
                set
                {
                    firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }

            private string lastName;
            public string LastName
            {
                get { return lastName; }
                set
                {
                    lastName = value;
                    OnPropertyChanged("LastName");
                }
            }

            private int age;
            public int Age
            {
                get { return age; }
                set
                {
                    age = value;
                    OnPropertyChanged("Age");
                }
            }

            #region INotifyPropertyChanged Members

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            private void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }

            #endregion
        }
    }
