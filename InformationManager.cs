using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace Project_Milestone_3
{
	public partial class InformationManager
	{
		static InformationManager defaultInstance = new InformationManager();
		MobileServiceClient client;

		IMobileServiceTable<Information> infoTable;


		const string offlineDbPath = @"localstore.db";

		private InformationManager()
		{
			this.client = new MobileServiceClient(Constants.ApplicationURL);


			this.infoTable = client.GetTable<Information>();

		}

		public static InformationManager DefaultManager
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

		public async Task<ObservableCollection<Information>> GetTitleItemsAsync(bool syncItems = false)
		{
			try
			{
				IEnumerable<Information> lists = await infoTable
					.ToEnumerableAsync();

				return new ObservableCollection<Information>(lists);
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

		public async Task<Boolean> SaveTaskAsync(Information item)
		{
			List<Information> info = await infoTable.Where(Information => Information.Proflist==item.Proflist ).ToListAsync();
			if (info.Count <= 0)
			{
				await infoTable.InsertAsync(item);
				return false;
			}
			else
			{
				await infoTable.UpdateAsync(info[0]);
				return true;
			}
		}

		public async Task<List<Information>> getProfDetails(string profname)
		{
			//.Where(Informat => Employee.Email == item.Email)
			List<Information> profInfo = await infoTable.Where(Information => Information.Dept == profname).ToListAsync();
		
			return profInfo;
		}

		public async Task<List<Information>> getCourseDetails(string courseName)
		{
			
			List<Information> cInfo = await infoTable.Where(Information => Information.Dept == courseName).ToListAsync();

			return cInfo;
		}

		public async Task<List<Information>> getCDetails(string name)
		{
			//.Where(Informat => Employee.Email == item.Email)
			List<Information> dInfo = await infoTable.Where(Information => Information.Cnlist == name).ToListAsync();

			return dInfo;
		}

		public async Task<List<Information>> getPDetails(string name)
		{
			//.Where(Informat => Employee.Email == item.Email)
			List<Information> dInfo = await infoTable.Where(Information => Information.Proflist == name).ToListAsync();

			return dInfo;
		}


		public async Task<List<Information>> getUrl(string url)
		{
			//.Where(Informat => Employee.Email == item.Email)
			List<Information> urlInfo = await infoTable.Where(Information => Information.Slink == url ).ToListAsync();

			return urlInfo;
		}


	}
}

