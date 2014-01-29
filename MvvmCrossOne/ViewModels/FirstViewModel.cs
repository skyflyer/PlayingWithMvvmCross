using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System;
using Cirrious.CrossCore.Platform;

namespace MvvmCrossOne.ViewModels
{
	public class FirstViewModel 
		: MvxViewModel
	{

		public FirstViewModel() {
			MvxTrace.Trace (MvxTraceLevel.Diagnostic, "Ctor");
		}

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

		public ICommand GoWest {
			get { return new MvxCommand(() => ShowViewModel<MainViewModel>()); }
		}

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





}
