using Android.App;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Fragging;
using MvvmCrossOne.Droid;

namespace MvvmCrossOne.Droid.Views
{
	[Activity()]
	public class FirstView : MvxFragmentActivity
	{
		public FirstView ()
		{
			MvxTrace.Trace (MvxTraceLevel.Diagnostic, "Ctor");
		}

		protected override void OnCreate (Android.OS.Bundle bundle)
		{
			base.OnCreate (bundle);
		}

		protected override void OnViewModelSet ()
		{
			base.OnViewModelSet ();
			SetContentView (Resource.Layout.First);
		}
	}
}

