using System;
using Cirrious.MvvmCross.ViewModels;
using System.Threading.Tasks;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;

namespace MvvmCrossOne
{
	public class FragViewModel : MvxViewModel
	{
		private string _hello = "Fragmag!";

		public string Hello {
			get { return _hello; }
			set {
				_hello = value;
				RaisePropertyChanged (() => Hello);
			}
		}

		private string _loading;

		public string Loading {
			get { return _loading; }
			set {
				_loading = value;
				RaisePropertyChanged (() => Loading);
			}
		}

		protected override async void InitFromBundle(IMvxBundle parameters)
		{
			base.InitFromBundle (parameters);

			// TODO: heavy loading here
			Loading = "Loading...";
			Mvx.Trace (MvxTraceLevel.Diagnostic, "Before delay... instance id: {0:X}", this.GetHashCode());
			await Task.Delay (3000);
			Loading = null;
			Mvx.Trace (MvxTraceLevel.Diagnostic, "After delay...");
		}
	}
}

