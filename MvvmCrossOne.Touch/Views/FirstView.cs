using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System;

namespace MvvmCrossOne.Touch.Views
{
    [Register("FirstView")]
	public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
			View = new UIView(){ BackgroundColor = UIColor.Red};
			var height = View.Bounds.Height;
			//View.Frame = new RectangleF (View.Bounds.X, View.Bounds.Y, View.Bounds.Width, View.Bounds.Height/2); doesn't work
			//View.Bounds = new RectangleF (View.Bounds.X, View.Bounds.Y, View.Bounds.Width, View.Bounds.Height/2);
            base.ViewDidLoad();

			// ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
               EdgesForExtendedLayout = UIRectEdge.None;
			   
			var info = new UILabel (new RectangleF (10, 90, 300, 300));
			info.LineBreakMode = UILineBreakMode.WordWrap;
			info.Lines = 0;
			info.Text = String.Format("Bounds: {0},{1},{2},{3} Frame: {4},{5},{6},{7}", View.Bounds.X, View.Bounds.Y, View.Bounds.Width, View.Bounds.Height, View.Frame.X, View.Frame.Y, View.Frame.Width, View.Frame.Height);
			Add (info);
            var label = new UILabel(new RectangleF(10, 10, 300, 40));
            Add(label);
            var textField = new UITextField(new RectangleF(10, 50, 300, 40));
            Add(textField);

			var button = UIButton.FromType (UIButtonType.System);
			button.Frame = new RectangleF (10, 90, 300, 40);
			button.SetTitle ("Do it", UIControlState.Normal);

			button.TouchUpInside += (object sender, System.EventArgs e) => {
				// navigate to regular UIController implementation
				// nothing to do with MvmmCross
				var test = new Test();
				NavigationController.PushViewController(test, true);
			};
			Add (button);

			var set = this.CreateBindingSet<FirstView, MvvmCrossOne.ViewModels.FirstViewModel>();
            set.Bind(label).To(vm => vm.Hello);
            set.Bind(textField).To(vm => vm.Hello);
            set.Apply();

        }
    }
}