using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvvm_1st.Model;
using System.Windows.Input;
namespace Mvvm_1st.ViewModel
{
    internal class PersonViewModel
    {
        public PersonModel Person { get; set; }
        private DelegateCommand savePersonCommand;
        public ICommand SavePersonCommand
        {
            get
            {
                if (savePersonCommand == null)
                    savePersonCommand = new DelegateCommand(new Action(SaveExecuted),
                        new Func<bool>(SaveCanExecute));
                return savePersonCommand;
            }
        }
        public PersonViewModel()
        {
            //This data will load as the default person from the model attached to
            //the view 
            Person = new PersonModel { FirstName = "John", LastName = "Doe", Age = 999 };
        }
        public bool SaveCanExecute()
        {
            return Person.Age > 0 && !string.IsNullOrEmpty(Person.FirstName) &&
                !string.IsNullOrEmpty(Person.LastName);
        }
        public void SaveExecuted()
        {
            System.Windows.MessageBox.Show(string.Format("Saved: {0} {1} - ({2})",
                Person.FirstName, Person.LastName, Person.Age));
        }

    } 
}
