using System;
using Xamarin.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net.Http;

namespace Phrazer
{
	public class App : Application
	{
		public App ()
		{

			MainPage = new MasterPage ();

			RunAsync ();
					
		}

		static async Task RunAsync()
		{
			using (var httpClient = new HttpClient()) {
				httpClient.BaseAddress = new Uri ("http://106.185.52.74:8888/");
				HttpResponseMessage response = await httpClient.GetAsync("phrases/insultpraise");
				if (response.IsSuccessStatusCode) {
					string json = await response.Content.ReadAsStringAsync ();
					Debug.WriteLine (json);
				} 
			}
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

