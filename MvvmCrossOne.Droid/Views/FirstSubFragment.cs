using Android.OS;
using Android.Views;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;


namespace MvvmCrossOne.Droid.Views
{

	public class FirstSubFragment : MvxFragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			MvxTrace.Trace (MvxTraceLevel.Diagnostic, "FirstSubFragment OnCreate");
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView (inflater, container, savedInstanceState);
			MvxTrace.Trace (MvxTraceLevel.Diagnostic, "First SubFragment OnCreateView");
//			if (ViewModel == null) {
//				var loaderService = Mvx.Resolve<IMvxViewModelLoader> ();
//				MvxViewModelRequest request = new MvxViewModelRequest (typeof(FragViewModel), null, null, MvxRequestedBy.Unknown);
//				var viewModel = loaderService.LoadViewModel (request, null /* saved state */);
//				ViewModel = viewModel;
//			}
			return this.BindingInflate (Resource.Layout.FirstSub, null);
		}

//		protected override void OnViewModelSet ()
//		{
//			MvxTrace.Trace (MvxTraceLevel.Diagnostic, "First SubFragment Model has been set!");
//		}
	}
	
}
