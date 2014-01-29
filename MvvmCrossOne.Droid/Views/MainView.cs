using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Cirrious.MvvmCross.Droid.Fragging;
using MvvmCrossOne.Core;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using MvvmCrossOne.ViewModels;
using Cirrious.CrossCore.Platform;
using Android.App;

namespace MvvmCrossOne.Droid
{
	[Activity]
	public class MainView : MvxFragmentActivity
	{
		protected override void OnCreate (Android.OS.Bundle bundle)
		{
			base.OnCreate (bundle);
		}

		protected override void OnViewModelSet ()
		{
			base.OnViewModelSet ();
			SetContentView (Resource.Layout.Main);

			// set the child view models to fragments
			MvxTrace.Trace (MvxTraceLevel.Diagnostic, "Setting view models on child fragments...");
			var firstFragment = (MvxFragment)SupportFragmentManager.FindFragmentById (Resource.Id.first);
			firstFragment.ViewModel = ((MainViewModel)ViewModel).First;
			var secondFragment = (MvxFragment)SupportFragmentManager.FindFragmentById (Resource.Id.second);
			secondFragment.ViewModel = ((MainViewModel)ViewModel).Second;
		}
	}
}

