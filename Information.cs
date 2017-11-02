using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using Xamarin.Forms;


namespace Project_Milestone_3
{
	public class Information
	{
		string id;
		string proflist;
		string cnlist;
		string slink;
		string dept;
		string code;
		string descp;
		string unit;
		string rate;
		string seat; 

		[JsonProperty(PropertyName = "id")]
		public string Id
		{
			get { return id; }
			set { id = value; }
		}


		[JsonProperty(PropertyName = "Professors")]
		public string Proflist
		{
			get { return proflist; }
			set { proflist = value; }
		}


		[JsonProperty(PropertyName = "CourseName")]
		public string Cnlist
		{
			get { return cnlist; }
			set { cnlist = value; }
		}

		[JsonProperty(PropertyName = "SyllabusLink")]
		public string Slink
		{
			get { return slink; }
			set { slink = value; }
		}

		[JsonProperty(PropertyName = "Department")]
		public string Dept
		{
			get { return dept; }
			set { dept = value; }
		}

		[JsonProperty(PropertyName = "CourseCode")]
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		[JsonProperty(PropertyName = "Description")]
		public string Descp
		{
			get { return descp; }
			set { descp = value; }
		}

		[JsonProperty(PropertyName = "Units")]
		public string Unit
		{
			get { return unit; }
			set { unit = value; }
		}

		[JsonProperty(PropertyName = "Rating")]
		public string Rate
		{
			get { return rate; }
			set { rate = value; }
		}

		[JsonProperty(PropertyName = "Seats")]
		public string Seat
		{
			get { return seat; }
			set { seat = value; }
		}
	}
}
