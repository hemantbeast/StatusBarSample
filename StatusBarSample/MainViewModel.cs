using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace StatusBarSample
{
	[ObservableObject]
	public partial class MainViewModel
	{
		[RelayCommand]
		void Change()
		{
			IsChanged = !IsChanged;
		}

		[ObservableProperty]
		[NotifyPropertyChangedFor(nameof(ChangedColor))]
		bool isChanged;

		public Color ChangedColor => IsChanged ? Colors.Red : Colors.Green;
	}
}

