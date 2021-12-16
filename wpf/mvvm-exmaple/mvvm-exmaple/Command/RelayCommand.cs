using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mvvm_exmaple.Command
{
    public class RelayCommand : ICommand
    {

        Action<object> executeMehod;
        Func<object, bool> canExecuteMehod;

        bool canExecuteCache;

        public RelayCommand(Action<object> executeMehod, Func<object, bool> canExecuteMehod, bool canExecuteCache)
        {
            this.executeMehod = executeMehod;
            this.canExecuteMehod = canExecuteMehod;
            this.canExecuteCache = canExecuteCache;
        }

        public event EventHandler CanExecuteChanged {

            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
           if(canExecuteMehod == null)
            {
                return true;
            }
            else
            {
                return canExecuteMehod(parameter);
            }
           
        }

        public void Execute(object parameter)
        {
            executeMehod(parameter);
        }
    }
}
