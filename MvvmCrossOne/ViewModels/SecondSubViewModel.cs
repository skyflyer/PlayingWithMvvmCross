using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System;
using Cirrious.CrossCore.Platform;

namespace MvvmCrossOne.ViewModels
{

	public class SecondSubViewModel : MvxViewModel
	{
		public void Init()
		{
		}

		string _text = "Second Subviewmodel";
		public string Text {
			get { return _text; }
			set {
				_text = value;
				RaisePropertyChanged (() => Text);
			}
		}

		public ICommand GoThere {
			get { return new MvxCommand (() => {
				MvxTrace.Trace(MvxTraceLevel.Diagnostic, "Showing first view model...");
				ShowViewModel<FirstViewModel>();
			}); }
		}
	}

}
