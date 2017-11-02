using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;


namespace Project_Milestone_3
{
	public partial class loginManager
	{
		static loginManager defaultInstance = new loginManager();
		MobileServiceClient client;

		IMobileServiceTable<Users> loginTable;

		const string offlineDbPath = @"localstore.db";

		private loginManager()
		{
			this.client = new MobileServiceClient(Constants.ApplicationURL);


			this.loginTable = client.GetTable<Users>();
		}


		public static loginManager DefaultManager
		{
			get
			{
				return defaultInstance;
			}
			private set
			{
				defaultInstance = value;
			}
		}

		public MobileServiceClient CurrentClient
		{
			get { return client; }
		}


		public async Task<ObservableCollection<Users>> GetTodoItemsAsync(bool syncItems = false)
		{
			try
			{

				IEnumerable<Users> items = await loginTable
					.ToEnumerableAsync();

				return new ObservableCollection<Users>(items);
			}
			catch (MobileServiceInvalidOperationException msioe)
			{
				Debug.WriteLine(@"Invalid sync operation: {0}", msioe.Message);
			}
			catch (Exception e)
			{
				Debug.WriteLine(@"Sync error: {0}", e.Message);
			}
			return null;
		}


		public async Task<Boolean> SaveTaskAsync(Users item)
		{
			List<Users> items = await loginTable.Where(Users => Users.Username == item.Username).ToListAsync();
			if (items.Count <= 0)
			{
				if (item.Id == null)
				{
					await loginTable.InsertAsync(item);
				}
				else
				{
					await loginTable.UpdateAsync(item);
				}
				return true;
			}
			else
			{
				return false;
			}

		}

		public async Task<Boolean> CheckTaskAsync(Users item)
		{
			List<Users> items = await loginTable.Where(Users => Users.Username == item.Username && Users.Pass == item.Pass && Users.Answer == item.Answer).ToListAsync();
			if (items.Count == 1)
			{
				return true;
			}
			return false;
		}

		public async Task<List<Users>> checkUserName(Users item)
		{
			List<Users> items = await loginTable.Where(login => login.Username == item.Username).ToListAsync();
			return items;
		}
	}
}