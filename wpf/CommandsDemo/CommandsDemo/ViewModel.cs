using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CommandsDemo
{
    public class ViewModel
    {
        public ICommand  MyCommand { get; set; }

        public ViewModel()
        {
            MyCommand = new Command(ExecuteMethod, CanExecuteMethod);
        }
        private bool CanExecuteMethod(object paramter)
        {
            return true;
        }

        private void ExecuteMethod(object paramter)
        {
            MessageBox.Show("Command Executed no code behind!!");
        }

    }

    
}
