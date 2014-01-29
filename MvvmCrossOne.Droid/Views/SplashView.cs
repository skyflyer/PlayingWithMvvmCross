using Android.App;
using Cirrious.MvvmCross.Droid.Views;
using MvvmCrossOne.Droid.Views;

namespace MvvmCrossOne.Droid
{
	[Activity(MainLauncher = true, NoHistory = true)]
	public class SplashView : MvxSplashScreenActivity
	{
		public SplashView() : base(MvvmCrossOne.Droid.Resource.Layout.SplashScreen)
		{
		}
	}
	
}
