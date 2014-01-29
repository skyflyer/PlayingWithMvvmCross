using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Android.Support.V4.App;
using Cirrious.CrossCore.Platform;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using MvvmCrossOne.Droid;


namespace MvvmCrossOne.Droid.Views
{
	public class FragFragment : MvxFragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			MvxTrace.Trace (MvxTraceLevel.Diagnostic, "Fragment OnCreate");
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView (inflater, container, savedInstanceState);
			MvxTrace.Trace (MvxTraceLevel.Diagnostic, "Fragment OnCreateView");
			if (ViewModel == null) {
				var loaderService = Mvx.Resolve<IMvxViewModelLoader> ();
				MvxViewModelRequest request = new MvxViewModelRequest (typeof(FragViewModel), null, null, MvxRequestedBy.Unknown);
				var viewModel = loaderService.LoadViewModel (request, null /* saved state */);
				ViewModel = viewModel;
			}
			return this.BindingInflate (Resource.Layout.Frag, null);
		}
	}
}

