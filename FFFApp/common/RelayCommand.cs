using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FFFApp.common
{
    class RelayCommand : ICommand
    {
        private Action _method;

        public RelayCommand(Action method)
        {
            _method = method;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _method?.Invoke();
        }

        public event EventHandler CanExecuteChanged;
    }
}

