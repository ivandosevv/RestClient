using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Drawing;

namespace RestClient1
{
	public class BaseRectangle : BaseFigure
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

		public BaseRectangle(RestClient client, string pathUrl)
			: base(client, pathUrl)
		{
			this.PathUrl = pathUrl;
			this.Client = client;
			this.ItemProperties = new string[10];
		}


	}
}
