using System;

using Xamarin.Forms;

namespace Project_Milestone_3
{
	public class NBView : ContentPage
	{
		public NBView()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

