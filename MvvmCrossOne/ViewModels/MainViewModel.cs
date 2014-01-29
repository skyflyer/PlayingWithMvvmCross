using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System;
using Cirrious.CrossCore.Platform;
using Cirrious.CrossCore;

namespace MvvmCrossOne.ViewModels
{

	public class MainViewModel : MvxViewModel
	{
		public void Init()
		{
//			var loaderService = Mvx.Resolve<IMvxViewModelLoader> ();
//			MvxViewModelRequest request = new MvxViewModelRequest (typeof(FirstSubViewModel), null, null, null);
//			var viewModel = loaderService.LoadViewModel (request, null /* saved state */);
//			First = (FirstSubViewModel)viewModel;
			First = new FirstSubViewModel (this);
			Second = new SecondSubViewModel ();
		}

		public ICommand GoToFirst {
			get {
				return new MvxCommand (() => ShowViewModel<FirstViewModel> ());
			}
		}

		string _text = "Mainviewmodel";
		public string Text {
			get { return _text; }
			set {
				_text = value;
				RaisePropertyChanged (() => Text);
			}
		}

		FirstSubViewModel _first;
		public FirstSubViewModel First {
			get { return _first; }
			set {
				_first = value;
				RaisePropertyChanged (() => First);
			}
		}

		SecondSubViewModel _second;
		public SecondSubViewModel Second {
			get { return _second; }
			set {
				_second = value;
				RaisePropertyChanged (() => Second);
			}
		}
	}

}
