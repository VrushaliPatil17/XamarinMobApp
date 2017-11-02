using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Project_Milestone_3
{
	public partial class NLView : ContentPage
	{
		int count = 0;

		public NLView()
		{
			InitializeComponent();


		}

		async void OnMenuButtonClicked(object sender, EventArgs args)
		{
			await DisplayAlert("alert", "hi", "ok");
		}
		void OnRateClicked(object sender, EventArgs args)
		{
			rate.IsVisible = true;
		}

		void On1StarClicked(object s, EventArgs e)
		{
			star1.BackgroundColor = Color.Yellow;
			count++;
		}
		void On2StarClicked(object s, EventArgs e)
		{
			star2.BackgroundColor = Color.Yellow;
			count++;
		}
		void On3StarClicked(object s, EventArgs e)
		{
			star3.BackgroundColor = Color.Yellow;
			count++;
		}
		void On4StarClicked(object s, EventArgs e)
		{
			star4.BackgroundColor = Color.Yellow;
			count++;
		}
		void On5StarClicked(object s, EventArgs e)
		{
			star5.BackgroundColor = Color.Yellow;
			count++;
		}

		async void OnSaveClicked(object s, EventArgs e)
		{
			await DisplayAlert("Saved", "Thank You!", "ok");
			rate.IsVisible = false;
			ratedisplay.Text = String.Format("Rate : {0} / 5", count);
		}
	}
}
