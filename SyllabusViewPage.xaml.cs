using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Project_Milestone_3
{
	public partial class SyllabusViewPage : MasterDetailPage
	{
		
		InformationManager manager;
		public SyllabusViewPage(string url)
		{
			
			InitializeComponent();
			manager = InformationManager.DefaultManager;
			//DisplayAlert("Alert", "Hello", "Ok");
			getLink(url);
			CButton.Clicked += (object sender, EventArgs e) =>
							{
								Navigation.PushAsync(new CourseListPage(App.department));
							};

			PButton.Clicked += (object sender, EventArgs e) =>
			{
				Navigation.PushAsync(new ProfessorListPage(App.department));
			};

			SButton.Clicked += (object sender, EventArgs e) =>
			{
				Navigation.PushAsync(new SyllabusList(App.department));
			};
		}

		void OnLink(object s,EventArgs e)
		{
			Label l = (Label)s;
			DisplayAlert("Wait", "Opening in Browser", "Ok");
			Device.OpenUri(new Uri(l.Text));
		}

		async Task getLink(string url)
		{
			link1.ItemsSource = await manager.getCDetails(url);
		}
	
	}
}


/*//WebView webView1;
		InformationManager manager;
		public SyllabusViewPage(string slink)
		{
			DisplayAlert("Alert", slink, "OK");
			InitializeComponent();
			manager = InformationManager.DefaultManager;
			getlink(slink);
			 

		}
		async Task getlink(string slink)

		{
			List<Information> result = await manager.getUrl(slink);
			string link = result[0].Slink;
			await DisplayAlert("Alert", link, "OK");
			webView.Source = link;

			                      //s webView.Source = link;
			//webView.BindingContext = new { Source = link};
			//await DisplayAlert("Alert", " " + slink, "OK");
			//webView.Source = await manager.getCourseDetails(cname);


		}*/