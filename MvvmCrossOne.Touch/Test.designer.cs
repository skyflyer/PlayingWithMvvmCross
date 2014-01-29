// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace MvvmCrossOne.Touch
{
	[Register ("Test")]
	partial class Test
	{
		[Outlet]
		MonoTouch.UIKit.UIButton ButtonTest { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblText { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ButtonTest != null) {
				ButtonTest.Dispose ();
				ButtonTest = null;
			}

			if (lblText != null) {
				lblText.Dispose ();
				lblText = null;
			}
		}
	}
}
