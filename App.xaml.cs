﻿using Xamarin.Forms;

namespace Project_Milestone_3
{
	public partial class App : Application
	{
		public static bool IsUserLoggedIn { get; set; }
		public static string department { get; set; }

		public App()
		{
			InitializeComponent();
			if (!IsUserLoggedIn)
			{
				MainPage = new NavigationPage(new Login());
			}
			else
			{
				MainPage = new NavigationPage(new Department());
			}
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
