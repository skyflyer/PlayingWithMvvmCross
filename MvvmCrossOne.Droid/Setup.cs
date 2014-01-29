using System;
using Cirrious.MvvmCross.Droid.Platform;
using Android.Content;
using Cirrious.CrossCore.Platform;

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
	}
}

