using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyCoolMVVMFramework
{
    public class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action _execute;
        private Func<bool> _canExecute;

        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public DelegateCommand(Action execute)
            : this(execute, null)
        {

        }


        public bool CanExecute(object parameter) =>
            _canExecute?.Invoke() ?? true;


        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
