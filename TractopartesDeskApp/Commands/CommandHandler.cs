using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TractopartesDeskApp.Commands
{
    public class CommandHandler : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested+= value;
            }
            remove
            {
               CommandManager.RequerySuggested -= value;
            }
        }
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        public CommandHandler(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public CommandHandler(Action<object> execute): this(execute,null)
        {
            _execute = execute;
        }
        public bool CanExecute(object? parameter)
        {

            return _canExecute == null ? true : _canExecute(parameter);

        }
        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
