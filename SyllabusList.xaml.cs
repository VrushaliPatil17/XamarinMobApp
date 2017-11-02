using System;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Milestone_3
{
	public partial class SyllabusList : MasterDetailPage
	{
		InformationManager listItem;
		public SyllabusList(string dname)
		{
			InitializeComponent();
			listItem = InformationManager.DefaultManager;
			getlist(dname);

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

		private async Task getlist(string dname)
		{
			slist.ItemsSource = await listItem.getCourseDetails(dname);
		}

		void OnSelected(object s, EventArgs e)
		{
			
		}

		async void OnCourse(object s, EventArgs e)
		{
			Label cn = (Label)s;
			string d = cn.Text;
			await Navigation.PushAsync(new SyllabusViewPage(cn.Text));

		}



	}
}

