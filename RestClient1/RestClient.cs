using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text;

namespace RestClient1
{
	public enum HttpVerb
	{
		GET,
		POST,
		PUT,
		DELETE
	}
	class RestClient123
	{
		public string endPoint { get; set; }
		public HttpVerb httpMethod { get; set; }

		public RestClient123()
		{
			endPoint = string.Empty;
			httpMethod = HttpVerb.GET;
		}

		public string MakeRequest()
		{
			string strResponseValue = string.Empty;

			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

			request.Method = httpMethod.ToString();

			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			{
				if (response.StatusCode != HttpStatusCode.OK)
				{
					throw new ApplicationException("error code: " + response.StatusCode.ToString());
				}
				//Process the response stream... (In case of JSON, XML, HTML, etc)

				using (Stream responseStream = response.GetResponseStream())
				{
					if (responseStream != null)
					{
						using (StreamReader reader = new StreamReader(responseStream))
						{
							strResponseValue = reader.ReadToEnd();
						}//End of StreamReader
					}

				}//End of using ResponseStream


			}//End of using response

			return strResponseValue;
		}
	}
}

/*
 *var client = new RestClient("http://127.0.0.1:9191/");

			var request = new RestRequest("projects/{projectid}", Method.GET);
			request.AddUrlSegment("projectid", 1);

			var queryResult = client.Execute(request).Content;
 * 
 * 
 */
