using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;


namespace Project_Milestone_3
{
	public class Users
	{
		string id;
		string username;
		string pass;
		string cpass;
		string question;
		string answer;

		[JsonProperty(PropertyName = "id")]
		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		[JsonProperty(PropertyName = "UserName")]			
		public string Username
		{
			get { return username; }				
			set { username = value; }
		}

		[JsonProperty(PropertyName = "Password")]
		public string Pass			
		{
			get { return pass; }
			set { pass = value; }
		}

		[JsonProperty(PropertyName = "CPassword")]
		public string CPass
		{
			get { return cpass; }
			set { cpass = value; }
		}


		[JsonProperty(PropertyName = "SecurityQuestion")]
		public string Question
		{
			get { return question; }
			set { question = value; }
		}

		[JsonProperty(PropertyName = "Answers")]
		public string Answer
		{
			get { return answer; }
			set { answer = value; }
		}


	

	}
}

