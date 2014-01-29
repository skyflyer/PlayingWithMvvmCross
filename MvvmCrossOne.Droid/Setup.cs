using System;
using Cirrious.MvvmCross.Droid.Platform;
using Android.Content;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using MvvmCrossOne.ViewModels;
using MvvmCrossOne.Droid.Views;


namespace MvvmCrossOne.Droid
{
	public class Setup : MvxAndroidSetup
	{
		public Setup (Context ctx) : base (ctx)
		{
		}

		protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp ()
		{
			return new MvvmCrossOne.App ();
		}

		protected override IMvxTrace CreateDebugTrace ()
		{
			return new DebugTrace ();
		}

//		protected override IMvxAndroidViewPresenter CreateViewPresenter ()
//		{
//			return new CustomPresenter ();
//		}
	}
	/* not used
	public class CustomPresenter : MvxAndroidViewPresenter
	{
		public override void Show (MvxViewModelRequest request)
		{
			MvxTrace.Trace (MvxTraceLevel.Diagnostic, "Show MvxViewModelRequest");
//			base.Show (request);
			if (request.ViewModelType == typeof(FirstViewModel)) {
				var intent = new Intent (Activity, typeof(FirstView));
				intent.SetFlags (ActivityFlags.NewTask);
				Activity.StartActivity (intent);
			} else {
				base.Show (request);
			}
		}

		protected override void Show (Intent intent)
		{
			MvxTrace.Trace (MvxTraceLevel.Diagnostic, "Show Intent");
			Activity.StartActivity (intent);
			//base.Show (intent);
		}
	}
	*/
}

