using System;

using Xamarin.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace Phrazer
{
	public class MasterPage : MasterDetailPage
	{
		public MasterPage ()
		{
			Label header = new Label
			{
				Text = "Phrases",
				FontSize = 20,
				HorizontalOptions = LayoutOptions.Start
			};
					
			string[] phrases = 
			{
				"Who Wins",
				"Explain to Me"
			};
				
			ListView listView = new ListView
			{
				ItemsSource = phrases
			};
					
			this.Master = new ContentPage
			{
				Title = header.Text,
				Content = new StackLayout
				{
					Children = 
					{
						header, 
						listView
					}
				}
			};

			var pages = new List<ContentPage> (0);

			var whoWinsPhrase =new Phrase(Phrases.WhoWins());
			var explainToMePhrase = new Phrase(Phrases.ExplainToMe());
			var whoWinsPage = new PhrasePage(whoWinsPhrase);
			var explainToMePage = new PhrasePage(explainToMePhrase);

			pages.Add (whoWinsPage);
			pages.Add (explainToMePage);

			var carousel = new CarouselPage {
				BackgroundColor = Color.White,
				Children = { 
					pages[0],
					pages[1]
				}
			};
					
			this.Detail = carousel;

			listView.ItemSelected += (sender, args) =>
			{
				switch((string)args.SelectedItem)
				{
				case "Who Wins":
					carousel.CurrentPage = pages[0];
					break;
				case "Explain to Me":
					carousel.CurrentPage = pages[1];
					break;
				}
					
				this.IsPresented = false;
			};
				
			// Initialize the ListView selection.
			listView.SelectedItem = phrases[0];

		}
	}
}


