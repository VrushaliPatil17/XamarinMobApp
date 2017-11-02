using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project_Milestone_3
{
	public partial class ProfView : MasterDetailPage
	{
		int count = 0;
		String rate, profname;
		InformationManager manager;
		public ProfView(string pName)
		{
			InitializeComponent();
			//DisplayAlert("", pName + " 1 ", "OK");
			manager = InformationManager.DefaultManager;
			getProf(pName);
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

		async Task saveRate(Information item)
		{
			
			bool result = await manager.SaveTaskAsync(item);
			if (result == true)
			{
				await DisplayAlert("Alert", "Thanks for Rating", "OK");
			}
			else
			{
				await DisplayAlert("Alert", "Sorry Couldnt Update", "OK");
			}
		
		}
	
		async Task getProf(string pName)
		{
			profname = pName;
			Display.ItemsSource = await manager.getPDetails(pName);
		}


		void OnClicked(object s, EventArgs e)
		{
			
			hide.IsVisible = true;
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
			
			hide.IsVisible = false;
			ratedisplay.Text = String.Format("Rate : {0}", count);
			rate = count.ToString();
			Information info = new Information
			{
				Rate = rate,
				Proflist=profname

			};

			saveRate(info);
		}

	}
}

