using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Drawing;

namespace RestClient1
{
	class BaseText : BaseFigure
	{
		private string PathUrl
		{
			get;
			set;
		}

		private RestClient Client
		{
			get;
			set;
		}
		private string[] ItemProperties
		{
			get;
			set;
		}

		public BaseText(RestClient client, string pathUrl)
			: base(client, pathUrl)
		{
			this.PathUrl = pathUrl;
			this.Client = client;
			this.ItemProperties = new string[10];
		}

		public virtual string[] GetFontDetails()
		{
			string[] queryFont = new string[10];
			string currFont = string.Empty;

			try
			{
				RestRequest requestFont = new RestRequest(PathUrl + "/Font/", Method.GET);
				requestFont.AddUrlSegment("projectid", 1);

				var queryResultFont = Client.Execute(requestFont).Content;
				currFont = queryResultFont.ToString();
				string[] currQueryFont = currFont.Split('=', '$', '|');

				queryFont[6] = currQueryFont[0];
				queryFont[7] = currQueryFont[1];
				queryFont[8] = currQueryFont[currQueryFont.Length - 1];
			}
			catch (Exception)
			{
				return queryFont;
			}
			return queryFont;
		}

		public virtual string GetFontStyle()
		{
			string[] fontDetails = GetFontDetails();

			return fontDetails[6];
		}

		public virtual int GetFontSize()
		{
			string[] fontDetails = GetFontDetails();

			return int.Parse(fontDetails[7]);
		}

		public virtual string GetFontColor()
		{
			string[] fontDetails = GetFontDetails();

			return fontDetails[8];
		}
	}
}
