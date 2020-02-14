using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MQTTDemoApp.Common
{

    public class DelegateCommand : ICommand
    {
        Action<object> _execteMethod;
        Func<object, bool> _canexecuteMethod;

        //public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<object> execteMethod)
        {
            _execteMethod = execteMethod;
        }

        public DelegateCommand(Action<object> execteMethod, Func<object, bool> canexecuteMethod)
        {
            _execteMethod = execteMethod;
            _canexecuteMethod = canexecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            //if (_canexecuteMethod != null)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            _execteMethod(parameter);
        }
    }
}
