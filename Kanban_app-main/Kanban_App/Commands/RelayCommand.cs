using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Kanban_App.Commands
{
    // RelayCommand class implements ICommand interface which is used for handling commands in WPF MVVM(model-view-viewmodel).
    class RelayCommand : ICommand
    {
        // Fields to store the execute and canExecute methods passed in through the constructor.
        private Action<object> _execute;
        private Func<object, bool> _canExecute;
        private Action addTask;

        public RelayCommand(Action addTask)
        {
            this.addTask = addTask;
        }

        // Constructor that takes in the execute action and an optional canExecute function.
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute; // The action to be executed when the command is invoked.
            _canExecute = canExecute; // The function that determines whether the command can execute.
        }

        // The CanExecuteChanged event handler is used to indicate that the result
        // of the CanExecute method has changed. This is used by the command source to re-evaluate
        // the CanExecute method if necessary.
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; } // Add event handler.
            remove { CommandManager.RequerySuggested -= value; } // Remove event handler.
        }

        // This method determines whether the command can be executed.
        public bool CanExecute(object parameter)
        {
            // If _canExecute is null, it means the command can always execute.
            // Otherwise, it invokes the _canExecute function.
            return _canExecute == null || _canExecute(parameter);
        }

        // Execute the command's action.
        public void Execute(object parameter)
        {
            // Invoke the execute action with the given parameter.
            _execute(parameter);
        }
    }
}
