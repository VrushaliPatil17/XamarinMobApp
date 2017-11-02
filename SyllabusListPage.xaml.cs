using System;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Milestone_3
{
	public partial class SyllabusListPage : ContentPage
	{
		InformationManager listItem;
		public SyllabusListPage()
		{
			InitializeComponent();
			listItem = InformationManager.DefaultManager;
			getlist();
		}

		private async Task getlist()
		{
			slist.ItemsSource = await listItem.GetTitleItemsAsync();
		}

		async void OnSelected(object s, EventArgs e)
		{
			await Navigation.PushAsync(new SyllabusViewPage());
		}

		void OnCourse(object s, EventArgs e)
		{
		}

		async void OnSyllabusClicked(object s, EventArgs e)
		{
			Button newButton = (Button)s;

			switch(newButton.Text)
			{ 
				case "Cloud Computing": await Navigation.PushAsync(new CloudSyllabus()); break;
				case "Mobile App Dev": await Navigation.PushAsync(new MbSyllabus()); break;
				case "Operating System": await Navigation.PushAsync(new OSSyllabus()); break;
				case "Machine Learning": await Navigation.PushAsync(new SyllabusViewPage()); break;
			}

		}

		async void OnMenuButtonClicked(object sender, EventArgs args)
		{
			await DisplayAlert("alert", "hi", "ok");
		}

	}
}
