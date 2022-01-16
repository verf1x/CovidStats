using System;
using System.Windows.Input;

namespace CovidStats.Commands
{
    internal class RelayCommand : ICommand
    {
        public RelayCommand(Action<Object>? execute, Predicate<Object>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        private readonly Action<Object>? _execute;
        private readonly Predicate<Object>? _canExecute;

        public event EventHandler? CanExecuteChanged { add => CommandManager.RequerySuggested += value; remove => CommandManager.RequerySuggested -= value; }

        public Boolean CanExecute(Object? parameter) 
            => _canExecute == null || _canExecute(parameter);

        public void Execute(Object? parameter) 
            => _execute(parameter);
    }
}
