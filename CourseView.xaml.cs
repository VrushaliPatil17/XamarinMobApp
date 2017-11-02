using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project_Milestone_3
{
	public partial class CourseView : MasterDetailPage
	{
		InformationManager manager;
		public CourseView(string cName)
		{
			InitializeComponent();
			manager = InformationManager.DefaultManager;
			getCourse(cName);
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


		async Task getCourse(string cName)
		{
			Display.ItemsSource = await manager.getCDetails(cName);

		}

	}
}
