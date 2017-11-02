using System;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;


namespace Project_Milestone_3
{
	public partial class ProfessorListPage : MasterDetailPage
	{
		InformationManager listItem;
		public ProfessorListPage(string dname)
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
			plist.ItemsSource = await listItem.getProfDetails(dname);
		}

		async void OnProf(object s, EventArgs e)
		{
			Label pn = (Label)s;
			String c = pn.Text;
			await Navigation.PushAsync(new ProfView(c));
		}

	}
}
