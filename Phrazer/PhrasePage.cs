using System;
using Xamarin.Forms;

namespace Phrazer
{
	public class PhrasePage: ContentPage
	{
		public PhrasePage (Phrase phrase)
		{
			var label = new Label {
				XAlign = TextAlignment.Center,
				FontSize = 30,
				Text = phrase.generatePhrase(),
				TextColor = Color.Black
			};

			var tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped += (s, e) => {
				label.Text = phrase.generatePhrase();
			};
			label.GestureRecognizers.Add(tapGestureRecognizer);

			var page = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = {
					label
				}
			};

			this.Content = page;
		}
	}
}

