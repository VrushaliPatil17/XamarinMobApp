using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace Project_Milestone_3
{
	public partial class Login : ContentPage
	{
		loginManager manager;
		public Login()
		{
			InitializeComponent();
			manager = loginManager.DefaultManager;
		}

		async void OnRegisterClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Register());
		}

		async void OnLoginClicked(object sender, EventArgs e)
		{
			var user = new Users
			{
				Username = id.Text,
				Pass = pass.Text,
				Answer = ans.Text
			};
			await checkItem(user);
		}

		async Task checkItem(Users item)

		{
			Boolean result = await manager.CheckTaskAsync(item);
			if (result == true)
			{
				await Navigation.PopAsync();
				await Navigation.PushAsync(new Department());
			}
			else 
			{
				await DisplayAlert("Alert", "Login Failed!", "Enter Again!");	
			} 
		}


		bool AreCredentialsCorrect(User user)
		{
			return user.Username == Input.Username && user.Password == Input.Password;
		}
	}
}
