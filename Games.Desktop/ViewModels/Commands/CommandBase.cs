﻿using System;
using System.Windows.Input;

namespace Games.Desktop.ViewModels.Commands
{
	internal abstract class CommandBase : ICommand
	{
		public event EventHandler? CanExecuteChanged
		{
			add => CommandManager.RequerySuggested += value;
			remove => CommandManager.RequerySuggested -= value;
		}

		public abstract bool CanExecute(object? parameter);

		public abstract void Execute(object? parameter);
	}
}
