using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Project_Milestone_3
{
	public partial class CourseViewPage : ContentPage
	{
		public CourseViewPage()
		{
			InitializeComponent();
		}

		async void OnMenuButtonClicked(object sender, EventArgs args)
		{
			await DisplayAlert("alert", "hi", "ok");
		}
	}
}
