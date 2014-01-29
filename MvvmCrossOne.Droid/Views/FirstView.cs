using System;
using Cirrious.MvvmCross.Droid.Views;
using Android.App;
using MvvmCrossOne.ViewModels;
using Cirrious.MvvmCross.Droid.Fragging;
using MvvmCrossOne.Droid;

namespace MvvmCrossOne.Core
{
	[Activity(MainLauncher = true)]
	public class FirstView : MvxFragmentActivity
	{
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

