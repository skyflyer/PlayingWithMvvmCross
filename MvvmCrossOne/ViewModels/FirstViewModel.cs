using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace MvvmCrossOne.ViewModels
{
	public class FirstViewModel 
		: MvxViewModel
	{
		private string _hello = "Hello MvvmCross";

		public string Hello { 
			get { return _hello; }
			set {
				_hello = value;
				RaisePropertyChanged (() => Hello);
			}
		}

		public string _content;

		public string Content {
			get {
				return _content;
			}
			set { 
				_content = value;
				RaisePropertyChanged (() => Content);
			}
		}

//		public ICommand GoWest {
//			get { return new MvxCommand(() => ShowViewModel<MainViewModel>()); }
//		}

		public  ICommand DoIt { 
			get { 
				return new MvxCommand (async () => {
					Content = await System.Threading.Tasks.Task.Run<string> ( () => {
						return DoItCommand ();
					});

					/*
					Content = await System.Threading.Tasks.Task.Factory.StartNew<string>(() => {
						var contentTask = DoItCommand();
						contentTask.Wait();

						return contentTask.Result;
					});
					*/
				}); 
			}
		}

		int _internalCounter = 0;
		private async Task<string> DoItCommand ()
		{
			// do something big here
			HttpClient cl = new HttpClient ();
			var resp = await cl.GetAsync ("http://www.ijs.si");
			return (_internalCounter++) + (await resp.Content.ReadAsStringAsync ()).Substring (0, 200);
		}
	}

	/*
	public class MainViewModel : MvxViewModel
	{
		public void Init()
		{
//			throw new NotImplementedException ();
		}

		string _text = "Mainviewmodel";
		public string Text {
			get { return _text; }
			set {
				_text = value;
				RaisePropertyChanged (() => Text);
			}
		}

		SubViewModel _inner;
		public SubViewModel Inner {
			get { return _inner; }
			set {
				_inner = value;
				RaisePropertyChanged (() => Inner);
			}
		}
	}

	public class SubViewModel : MvxViewModel
	{
		public void Init()
		{
//			throw new NotImplementedException ();
		}

		string _text = "Subviewmodel";
		public string Text {
			get { return _text; }
			set {
				_text = value;
				RaisePropertyChanged (() => Text);
			}
		}
	}
	*/
}
