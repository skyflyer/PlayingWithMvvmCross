using System;
using Cirrious.MvvmCross.Droid.Platform;
using Android.Content;
using Cirrious.CrossCore.Platform;
using Android.Util;

namespace MvvmCrossOne.Droid
{
	public class DebugTrace : IMvxTrace
	{
		#region IMvxTrace implementation
		public void Trace (MvxTraceLevel level, string tag, Func<string> message)
		{
			Log.Debug(tag, String.Format("[{0}] - {1}", level.ToString(), message()));
		}
		public void Trace (MvxTraceLevel level, string tag, string message)
		{
			Log.Debug(tag, String.Format("[{0}] - {1}", level.ToString(), message));
		}
		public void Trace (MvxTraceLevel level, string tag, string message, params object[] args)
		{
			Log.Debug(tag, String.Format("[{0}] - {1}", level.ToString(), String.Format(message, args)));
		}
		#endregion
	}
}

