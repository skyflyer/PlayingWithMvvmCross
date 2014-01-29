using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System;
using Cirrious.CrossCore.Platform;

namespace MvvmCrossOne.ViewModels
{
	public class FirstSubViewModel : MvxViewModel
	{
		MainViewModel _parent;

		public FirstSubViewModel(MainViewModel parent)
		{
			this._parent = parent;
		}

		public void Init ()
		{
		}

		string _text = "First Subviewmodel";

		public string Text {
			get { return _text; }
			set {
				_text = value;
				RaisePropertyChanged (() => Text);
			}
		}

		public ICommand CloseMe {
			get { 
				return new MvxCommand (() => {
					MvxTrace.Trace (MvxTraceLevel.Diagnostic, "Closing the first sub view model...");
					//ChangePresentation (new MvxClosePresentationHint (this));
					Close (_parent);
				}); 
			}
		}
	}
}
