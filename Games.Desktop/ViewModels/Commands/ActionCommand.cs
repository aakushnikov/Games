using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Desktop.ViewModels.Commands
{
	internal class ActionCommand : CommandBase
	{
		private readonly Action<object?> _execute;
		private readonly Func<object, bool>? _canExecute;

		public ActionCommand(Action<object?> execute, Func<object, bool>? canExecute = null)
		{
			_execute = execute ?? throw new ArgumentNullException(nameof(execute));
			_canExecute = canExecute;
		}
		public override bool CanExecute(object? parameter)
		{
			if (parameter == null || _canExecute == null) return true;
			return _canExecute.Invoke(parameter);
		}

		public override void Execute(object? parameter) => _execute(parameter);
	}
}
