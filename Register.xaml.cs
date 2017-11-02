using System;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;

namespace Project_Milestone_3
{
	public partial class Register : ContentPage
	{
		loginManager manager;
		public Register()
		{
			InitializeComponent();
			manager = loginManager.DefaultManager;
		}


		async void OnRegisterClicked(object s, EventArgs e)
		{
			var todo = new Users
			{
				Username = Sid.Text,
				Pass= pw.Text,
				CPass=cpw.Text,
				Question = sq.Text,
				Answer = an.Text
			};
			await AddItem(todo);


			//// Sign up logic goes here
		}

		async Task AddItem(Users item)

		{
			Boolean result = await manager.SaveTaskAsync(item);
			if (result == true)
			{
				if (item.Pass == item.CPass)
				{
					await Navigation.PushAsync(new Login());
					Sid.Text = "";
					pw.Text = "";
					cpw.Text = "";
					sq.Text = "";
					an.Text = "";
				}
				else 
				{
					await DisplayAlert("Alert", "Passwords did not match!!", "Try Again");
				}

			}
			else
			{
				await DisplayAlert("Sorry", "Username Already Exits", "Try Again");
				Sid.Text = "";
			}
		}


		bool AreDetailsValid(User user)
		{
			if (user.Password == user.CPassword && !string.IsNullOrWhiteSpace(user.Username) && !string.IsNullOrWhiteSpace(user.Password) && !string.IsNullOrWhiteSpace(user.Password))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
