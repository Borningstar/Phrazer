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
			var whoWinsLabel = new Label {
				XAlign = TextAlignment.Center,
				Font = Font.SystemFontOfSize(40),
				Text = Phrases.getWhoWins()
			};

			var tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped += (s, e) => {
				whoWinsLabel.Text = Phrases.getWhoWins();
			};
			whoWinsLabel.GestureRecognizers.Add(tapGestureRecognizer);

			var explainToMeLabel = new Label {
				XAlign = TextAlignment.Center,
				Font = Font.SystemFontOfSize(40),
				Text = Phrases.getExplainToMe()
			};

			var tapGestureRecognizerExplain = new TapGestureRecognizer();
			tapGestureRecognizerExplain.Tapped += (s, e) => {
				explainToMeLabel.Text = Phrases.getExplainToMe();
			};
			explainToMeLabel.GestureRecognizers.Add(tapGestureRecognizerExplain);

			var pages = new List<ContentPage> (0);

			pages.Add (new ContentPage { 
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						whoWinsLabel
					}
				}
			});

			pages.Add (new ContentPage { 
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						explainToMeLabel
					}
				}
			});



			// The root page of your application
			MainPage = new CarouselPage {
				Children = { 
					pages[0],
					pages[1]
				}
			};
					
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

