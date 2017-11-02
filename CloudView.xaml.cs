using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Project_Milestone_3
{
	public partial class CloudView : ContentPage
	{
		public CloudView()
		{
			InitializeComponent();
		}

		async void OnMenuButtonClicked(object sender, EventArgs args)
		{
			await DisplayAlert("alert", "hi", "ok");
		}
		//async void OnProfClicked(object sender, EventArgs args)
		//{
		//	await Navigation.PushAsync(new ProfessorViewPage());
		//}
	}
}
