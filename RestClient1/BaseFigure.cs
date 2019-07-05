using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Drawing;

namespace RestClient1
{
	public class BaseFigure
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

		public BaseFigure(RestClient client, string pathUrl)
		{
			this.Client = client;
			this.PathUrl = pathUrl;
			this.ItemProperties = new string[10];
		}

		public virtual string[] GetItemProperties()
		{
			try
			{
				RestRequest requestLeft = new RestRequest(PathUrl + "/Left/", Method.GET);
				requestLeft.AddUrlSegment("projectid", 1);

				var queryResultLeft = Client.Execute(requestLeft).Content;
				int queryLeft = int.Parse(queryResultLeft);
				ItemProperties[0] = queryLeft.ToString();

				RestRequest requestTop = new RestRequest(PathUrl + "/Top/", Method.GET);
				requestTop.AddUrlSegment("projectid", 1);

				var queryResultTop = Client.Execute(requestTop).Content;
				int queryTop = int.Parse(queryResultTop);
				ItemProperties[1] = queryTop.ToString();


				RestRequest requestWidth = new RestRequest(PathUrl + "/Width/", Method.GET);
				requestWidth.AddUrlSegment("projectid", 1);

				var queryResultWidth = Client.Execute(requestWidth).Content;
				int queryWidth = int.Parse(queryResultWidth);
				ItemProperties[2] = queryWidth.ToString();

				RestRequest requestHeight = new RestRequest(PathUrl + "/Height/", Method.GET);
				requestHeight.AddUrlSegment("projectid", 1);

				var queryResultHeight = Client.Execute(requestHeight).Content;
				int queryHeight = int.Parse(queryResultHeight);
				ItemProperties[3] = queryHeight.ToString();
			}
			catch (Exception)
			{
				ItemProperties[0] = "0";
				ItemProperties[1] = "0";

				RestRequest requestWidth = new RestRequest(PathUrl + "/Width/", Method.GET);
				requestWidth.AddUrlSegment("projectid", 1);

				var queryResultWidth = Client.Execute(requestWidth).Content;
				int queryWidth = int.Parse(queryResultWidth);
				ItemProperties[2] = queryWidth.ToString();

				RestRequest requestHeight = new RestRequest(PathUrl + "/Height/", Method.GET);
				requestHeight.AddUrlSegment("projectid", 1);

				var queryResultHeight = Client.Execute(requestHeight).Content;
				int queryHeight = int.Parse(queryResultHeight);
				ItemProperties[3] = queryHeight.ToString();
			}

			return ItemProperties;
		}

		public virtual string GetPropertyText()
		{
			string queryText = String.Empty;

			try
			{
				RestRequest requestText = new RestRequest(PathUrl + "/Text/", Method.GET);
				requestText.AddUrlSegment("projectid", 1);

				var queryResultText = Client.Execute(requestText).Content;
				queryText = queryResultText.ToString();
			}
			catch (Exception)
			{
				return "";
			}

			return queryText;
		}

		public virtual string GetPropertyColor()
		{
			string queryColor = String.Empty;

			try
			{
				RestRequest requestText = new RestRequest(PathUrl + "/Color/", Method.GET);
				requestText.AddUrlSegment("projectid", 1);

				var queryResultText = Client.Execute(requestText).Content;
				queryColor = queryResultText.ToString();

				string[] queryColorSplit = queryColor.Split('=', '$');
				queryColor = queryColorSplit[queryColorSplit.Length - 1];
			}
			catch (Exception)
			{
				return "FFFFFFFF";
			}

			return queryColor;
		}

		public virtual string GetItemName()
		{
			string queryName = String.Empty;

			RestRequest requestName = new RestRequest(PathUrl + "/Name/", Method.GET);
			requestName.AddUrlSegment("projectid", 1);

			var queryResultName = Client.Execute(requestName).Content;
			queryName = queryResultName.ToString();

			return queryName;
		}

		public virtual int GetPropertyLeft()
		{
			ItemProperties[0] = GetItemProperties()[0];
			try
			{
				int.Parse(ItemProperties[0]);
			}
			catch (Exception)
			{
				return 0;
			}

			return int.Parse(ItemProperties[0]);
		}


		public virtual int GetPropertyTop()
		{
			ItemProperties[1] = GetItemProperties()[1];
			try
			{
				int.Parse(ItemProperties[1]);
			}
			catch (Exception)
			{
				return 0;
			}

			return int.Parse(ItemProperties[1]);
		}

		public virtual int GetPropertyWidth()
		{
			ItemProperties[2] = GetItemProperties()[2];
			try
			{
				int.Parse(ItemProperties[2]);
			}
			catch (Exception)
			{
				return 0;
			}

			return int.Parse(ItemProperties[2]);
		}

		public virtual int GetPropertyHeight()
		{
			ItemProperties[3] = GetItemProperties()[3];
			try
			{
				int.Parse(ItemProperties[3]);
			}
			catch (Exception)
			{
				return 0;
			}

			return int.Parse(ItemProperties[3]);
		}

	}
}
