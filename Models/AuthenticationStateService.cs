using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Project1_Lab_Simple.Models
{
	public class AuthenticationStateService : INotifyPropertyChanged
	{
		private bool _isAuthenticated;

		public event PropertyChangedEventHandler? PropertyChanged;

		public bool IsAuthenticated
		{
			get => _isAuthenticated;
			private set
			{
				if (_isAuthenticated != value)
				{
					_isAuthenticated = value;
					OnPropertyChanged();
				}
			}
		}

		public void LogIn()
		{
			IsAuthenticated = true;
		}

		public void LogOut()
		{
			IsAuthenticated = false;
		}

		protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
