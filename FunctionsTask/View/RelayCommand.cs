using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FunctionsTask.View
{
    /// <summary>
    /// Этот класс используется для создания команд, которые могут быть привязаны к элементам UI
    /// для выполнения определённых действий
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Поля для хранения делегатов действия и проверки возможности выполнения команды
        /// </summary>
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        /// <summary>
        /// Конструктор, принимающий делегат для выполнения команды,
        /// и по желанию для проверки возможности выполнения
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExecute"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        /// <summary>
        /// Метод для проверки возможности выполнения команды
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;

        /// <summary>
        /// Метод для выполнения команды
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter) => _execute(parameter);

        /// <summary>
        /// Событие, сообщающее системе WPF о необходимости повторной проверки возможности выполнения команды
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
