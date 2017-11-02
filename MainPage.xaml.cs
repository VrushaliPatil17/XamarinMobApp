using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project_Milestone_3
{
	public partial class MainPage : ContentPage
	{
		InformationManager manager;
		public MainPage(string dname)
		{
			InitializeComponent();
			manager = InformationManager.DefaultManager;
			getdept(dname);

		}


		async Task getdept(string dname)

		{
			if (dname == "Computer Science")
			{
				CButton.Clicked += (object sender, EventArgs e) =>
				{
					 Navigation.PushAsync(new CourseListPage(dname));
				};

				PButton.Clicked += (object sender, EventArgs e) =>
				{
					Navigation.PushAsync(new ProfessorListPage(dname));
				};

				SButton.Clicked += (object sender, EventArgs e) =>
				{
					Navigation.PushAsync(new SyllabusList(dname));
				};
			}

			else if (dname == "Engineering Management")
			{
				CButton.Clicked += (object sender, EventArgs e) =>
				{
					Navigation.PushAsync(new CourseListPage(dname));
				};

				PButton.Clicked += (object sender, EventArgs e) =>
				{
					Navigation.PushAsync(new ProfessorListPage(dname));
				};
				SButton.Clicked += (object sender, EventArgs e) =>
				{
					Navigation.PushAsync(new SyllabusList(dname));
				};
			}

			else if (dname == "Civil Engineering")
			{
				CButton.Clicked += (object sender, EventArgs e) =>
				{
					Navigation.PushAsync(new CourseListPage(dname));
				};
				PButton.Clicked += (object sender, EventArgs e) =>
				{
					Navigation.PushAsync(new ProfessorListPage(dname));
				};
				SButton.Clicked += (object sender, EventArgs e) =>
				{
					Navigation.PushAsync(new SyllabusList(dname));
				};
			}

		}
	}
}
