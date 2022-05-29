using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Games.Desktop.ViewModels
{
	internal abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
	{
		private bool _disposed;
		public event PropertyChangedEventHandler? PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}

		protected virtual bool Set<T>(ref T field, T value, [CallerMemberName]string prop = "")
		{
			if (Equals(field, value)) return false;
			field = value;
			OnPropertyChanged(prop);
			return true;
		}

		public void Dispose()
		{
			Dispose(true);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing || _disposed) return;
			_disposed = true;
		}
	}
}
