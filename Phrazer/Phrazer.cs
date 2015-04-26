using System;
using Xamarin.Forms;
using System.Diagnostics;
using System.Collections.Generic;

namespace Phrazer
{
	public class App : Application
	{
		public App ()
		{

			MainPage = new MasterPage ();
					
		}
			
		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

