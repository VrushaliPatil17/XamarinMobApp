using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Project_Milestone_3
{
	public partial class SelectPage : ContentPage
	{
		public SelectPage()
		{
			InitializeComponent();
		}

		async void OnCourseClicked(object s, EventArgs e)
		{
			Navigation.InsertPageBefore(new CourseListPage(), this);
			await Navigation.PopAsync();
		}

		async void OnProfClicked(object s, EventArgs e)
		{
			Navigation.InsertPageBefore(new ProfessorListPage(), this);
			await Navigation.PopAsync();
		}

		void OnSyllabusClicked(object s, EventArgs e)
		{
			Navigation.InsertPageBefore(new SyllabusListPage(), this);
			//await Navigation.PopAsync();
		}
	}
}
