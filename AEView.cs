using System;

using Xamarin.Forms;

namespace Project_Milestone_3
{
	public class AEView : ContentPage
	{
		public AEView()
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

