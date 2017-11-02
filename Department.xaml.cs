using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_Milestone_3
{
	public partial class Department : ContentPage
	{
		InformationManager manager;
		public Department()
		{
			InitializeComponent();
			manager = InformationManager.DefaultManager;

		}

		async void OnDepartButtonClicked(object s, EventArgs e)
		{
			Button bt = (Button)s;
			string b = bt.Text;
			App.department = b;
			await Navigation.PushAsync(new MainPage(b));
		}
	}
}
