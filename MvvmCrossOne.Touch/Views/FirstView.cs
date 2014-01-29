using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace MvvmCrossOne.Touch.Views
{
    [Register("FirstView")]
	public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView(){ BackgroundColor = UIColor.White};
            base.ViewDidLoad();

			// ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
               EdgesForExtendedLayout = UIRectEdge.None;
			   
            var label = new UILabel(new RectangleF(10, 10, 300, 40));
            Add(label);
            var textField = new UITextField(new RectangleF(10, 50, 300, 40));
            Add(textField);

			var button = UIButton.FromType (UIButtonType.System);
			button.Frame = new RectangleF (10, 90, 300, 40);
			button.SetTitle ("Do it", UIControlState.Normal);
			//button.SetTitleColor (UIColor.Blue, UIControlState.Normal);
			button.TouchUpInside += (object sender, System.EventArgs e) => {
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