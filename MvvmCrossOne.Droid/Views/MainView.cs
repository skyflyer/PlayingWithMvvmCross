using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Fragging;
using MvvmCrossOne.Core;

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
//			SetContentView (Resource.Layout.MainView);
		}
	}
}

