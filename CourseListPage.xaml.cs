using System;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Milestone_3
{
	public partial class CourseListPage : MasterDetailPage
	{
		InformationManager listItem;
		public CourseListPage(string dname)
		{
			
			InitializeComponent();
			listItem = InformationManager.DefaultManager;
			getlist(dname);
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

		private async Task getlist(string dname)
		{
			clist.ItemsSource = await listItem.getCourseDetails(dname);
		}

		async void OnCourse(object s, EventArgs e)
		{
			Label l = (Label)s;
			string cd = l.Text;
			await Navigation.PushAsync(new CourseView(cd));
		}


	}
}
