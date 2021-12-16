using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CommandsDemo
{
    public class Command : ICommand
    {
        Action<object> executeMehod;
        Func<object, bool> canExecuteMehod;

        
        public Command(Action<object> executeMehod, Func<object, bool> canExecuteMehod)
        {
            this.executeMehod = executeMehod;
            this.canExecuteMehod = canExecuteMehod;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return canExecuteMehod(parameter);
        }

        public void Execute(object parameter)
        {
            executeMehod(parameter);
        }
    }
}
