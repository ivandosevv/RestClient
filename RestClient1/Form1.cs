using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace RestClient1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cmdGO_Click(object sender, EventArgs e)
		{
			//RestClient client = new RestClient("http://127.0.0.1:9191");

			string pathUrl = txtRestURL.Text;
			//string connectionUrl = GetConnectionURL(url);
			//string pathUrl = GetPathUrl(url);

			RestClient client = new RestClient(connectionBox.Text);

			if (buttonGetClicked)
			{
				GetQuery(client, pathUrl);
			}
			else if (buttonPutClicked)
			{
				PutQuery(client, pathUrl);
			}
			else if (buttonDeleteClicked)
			{
				DeleteQuery(client, pathUrl);
			}

			/*client.endPoint = txtRestURL.Text;
            debugOutput("RESTClient Object created.");

			string strJSON = client.MakeRequest();

            debugOutput(strJSON);
			*/
		}



		private void debugOutput(string strDebugText)
		{
			try
			{
				System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
				txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
				txtResponse.SelectionStart = txtResponse.TextLength;
				txtResponse.ScrollToCaret();
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
			}
		}

		private void TxtResponse_TextChanged(object sender, EventArgs e)
		{

		}

		private bool buttonGetClicked = false;
		private bool buttonPutClicked = false;
		private bool buttonDeleteClicked = false;
		private Form2 frm2;

		private void ButtonGet_Click(object sender, EventArgs e)
		{
			buttonGetClicked = true;
			buttonPutClicked = false;
			buttonDeleteClicked = false;

			buttonGet.BackColor = Color.Yellow;
			buttonDelete.BackColor = Color.LightGray;
			buttonPut.BackColor = Color.LightGray;

			jsonLabel.Visible = false;
			jsonBox.Visible = false;
			jsonBox.Text = String.Empty;
		}

		private void ButtonPut_Click_1(object sender, EventArgs e)
		{
			buttonGetClicked = false;
			buttonPutClicked = true;
			buttonDeleteClicked = false;

			buttonGet.BackColor = Color.LightGray;
			buttonDelete.BackColor = Color.LightGray;
			buttonPut.BackColor = Color.Yellow;

			jsonLabel.Visible = true;
			jsonBox.Visible = true;
		}

		private void ButtonDelete_Click_1(object sender, EventArgs e)
		{
			buttonGetClicked = false;
			buttonPutClicked = false;
			buttonDeleteClicked = true;

			buttonGet.BackColor = Color.LightGray;
			buttonDelete.BackColor = Color.Yellow;
			buttonPut.BackColor = Color.LightGray;

			jsonLabel.Visible = false;
			jsonBox.Visible = false;
			jsonBox.Text = String.Empty;
		}

		public void GetQuery(RestClient client, string pathUrl)
		{
			string[] wordAddress = pathUrl.Split('/').ToArray();


			var request = new RestRequest(pathUrl, Method.GET);
			request.AddUrlSegment("projectid", 1);

			var queryResult = client.Execute(request).Content;
			string strQuery = queryResult.ToString();
			string[] wordQuery = strQuery.Split('[', ']', '{', '}', ',', ' ').ToArray();

			//Console.WriteLine(String.Join("\n", wordQuery));

			for (int i = 2; i < wordQuery.Length; i++)
			{
				txtResponse.AppendText(wordQuery[i]);
				txtResponse.AppendText(Environment.NewLine);
			}
		}

		public void PutQuery(RestClient client, string pathUrl)
		{
			string[] splitURL = pathUrl.Split('/').ToArray();
			var request = new RestRequest(pathUrl, Method.PUT);
			string itemName = splitURL[splitURL.Length - 1];
			string[] jsonTextSplit = jsonBox.Text.Split('{', '}', ':', ',');

			request.AddParameter("application/json", jsonBox.Text, ParameterType.RequestBody);

			client.Execute(request);

			txtResponse.AppendText("The following changes have been made: " + Environment.NewLine);
			for (int i = 3; i < jsonTextSplit.Length - 2; i += 2)
			{
				if (jsonTextSplit[i].ToLower() != "\"name\"" && jsonTextSplit[i].ToLower() != "\"name\"")
				{
					txtResponse.AppendText(jsonTextSplit[i] + "set to" + jsonTextSplit[i + 1] + Environment.NewLine);
				}
			}


			//string newParameter = "{" + jsonTextSplit[1] + ":{";

			//txtResponse.Clear();
			//txtResponse.AppendText(newParameter + Environment.NewLine);

			//for (int i = 2; i < jsonTextSplit.Length - 1; i+=2)
			//{
			//	if (i >= jsonTextSplit.Length - 1)
			//	{
			//		newParameter += jsonTextSplit[i] + ":" + jsonTextSplit[i + 1];
			//	}
			//	else
			//	{
			//		newParameter += jsonTextSplit[i] + ":" + jsonTextSplit[i + 1] + ",";
			//	}

			//	txtResponse.AppendText(newParameter + Environment.NewLine);
			//}

			//newParameter += "}}";
			//txtResponse.AppendText(newParameter + Environment.NewLine);

			//request.AddParameter("application/json","{ \"item\":{ \"Name\":\"Text2\",\"Text\":\"dawe\"} }", ParameterType.RequestBody);
		}

		public void DeleteQuery(RestClient client, string pathUrl)
		{
			var request = new RestRequest(pathUrl, Method.DELETE);
			client.Execute(request);
			txtResponse.AppendText("Item has been deleted");
			txtResponse.AppendText(Environment.NewLine);
		}

		public void GetQueryComboBoxStuff(RestClient client, string pathUrl)
		{
			string[] wordAddress = pathUrl.Split('/').ToArray();


			var request = new RestRequest(pathUrl, Method.GET);
			request.AddUrlSegment("projectid", 1);

			var queryResult = client.Execute(request).Content;
			string strQuery = queryResult.Trim().ToString();
			string[] wordQuery = strQuery.Split('[', ']', '{', '}', ',', ' ').ToArray();

			//Console.WriteLine(String.Join("\n", wordQuery));
			comboBoxStuff.Items.Clear();
			for (int i = 2; i < wordQuery.Length - 2; i++)
			{
				comboBoxStuff.Items.Add(wordQuery[i]);	
			}
		}

		public void GetQueryComboBoxItems(RestClient client, string pathUrl)
		{
			string[] wordAddress = pathUrl.Split('/').ToArray();
			var request = new RestRequest(pathUrl, Method.GET);
			request.AddUrlSegment("projectid", 1);

			var queryResult = client.Execute(request).Content;
			string strQuery = queryResult.Trim().ToString();
			string[] wordQuery = strQuery.Split('[', ']', '{', '}', ',', ' ').ToArray();

			//Console.WriteLine(String.Join("\n", wordQuery));
			comboBoxItems.Items.Clear();
			for (int i = 2; i < wordQuery.Length - 2; i++)
			{
				comboBoxItems.Items.Add(wordQuery[i]);
			}
		}

		public void PutQueryWithoutPrinting(RestClient client, string pathUrl, string command, string valueChange)
		{
			var request = new RestRequest(pathUrl, Method.PUT);
			string jsonQuery = "{\"item\":{" + command + ":" + valueChange + "}}";

			request.AddParameter("application/json", jsonQuery,ParameterType.RequestBody);

			client.Execute(request);		
		}

		public string GetConnectionURL(string url)
		{
			string connectionUrl = string.Empty;
			string pathUrl = string.Empty;

			int sideCount = 0;
			for (int i = 0; i < url.Length; i++)
			{
				if (url[i] == '/')
				{
					sideCount++;
				}
				if (sideCount <= 2)
				{
					connectionUrl += url[i];
				}				
			}

			return connectionUrl;
		}

		public string GetPathUrl(string url)
		{
			string pathUrl = string.Empty;

			int sideCount = 0;
			for (int i = 0; i < url.Length; i++)
			{
				if (url[i] == '/')
				{
					sideCount++;
				}
				if (sideCount > 2)
				{
					pathUrl += url[i];
				}
			}

			return pathUrl;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			
			int errorCheck = 0;
			try
			{
				RestClient rc = new RestClient(connectionBox.Text);
			}
			catch (Exception ex)
			{
				errorCheck++;
			}

			if (errorCheck == 0)
			{
				colorButton.BackColor = Color.Green;
				requestLabel.Visible = true;
				txtRestURL.Visible = true;
				cmdGO.Visible = true;
				responseLabel.Visible = true;
				txtResponse.Visible = true;
				buttonGet.Visible = true;
				buttonPut.Visible = true;
				buttonDelete.Visible = true;
				jsonBox.Visible = false;
				jsonLabel.Visible = false;
				txtResponse.Visible = true;
				labelGet.Visible = true;
				urlCmd.Visible = true;
				showButton.Visible = true;
				comboBoxStuff.Visible = true;
				itemButton.Visible = false;
				comboBoxItems.Visible = false;
				button1.Visible = true;
				buttonWidth.Visible = false;
				buttonHeight.Visible = false;
				buttonTop.Visible = false;
				buttonLeft.Visible = false;
				buttonHide.Visible = false;
				buttonShow.Visible = false;
				buttonDraw.Visible = false;
			}
			else
			{
				colorButton.BackColor = Color.Red;
				requestLabel.Visible = false;
				txtRestURL.Visible = false;
				cmdGO.Visible = false;
				responseLabel.Visible = false;
				responseLabel.Visible = false;
				buttonGet.Visible = false;
				buttonPut.Visible = false;
				buttonDelete.Visible = false;
				jsonBox.Visible = false;
				jsonLabel.Visible = false;
				txtResponse.Visible = false;
				labelGet.Visible = false;
				urlCmd.Visible = false;
				showButton.Visible = false;
				comboBoxStuff.Visible = false;
				itemButton.Visible = false;
				comboBoxItems.Visible = false;
				button1.Visible = false;
				buttonWidth.Visible = false;
				buttonHeight.Visible = false;
				buttonTop.Visible = false;
				buttonLeft.Visible = false;
				buttonHide.Visible = false;
				buttonShow.Visible = false;
				buttonDraw.Visible = false;
			}
		}

		private void Label3_Click(object sender, EventArgs e)
		{

		}

		private void UrlCmd_TextChanged(object sender, EventArgs e)
		{

		}

		string CurrentPath
		{
			get;
			set;
		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			string pathUrl = urlCmd.Text;
			//string connectionUrl = GetConnectionURL(url);
			//string pathUrl = GetPathUrl(url);

			RestClient client = new RestClient(connectionBox.Text);


			GetQueryComboBoxStuff(client, pathUrl);

			itemButton.Visible = true;
			comboBoxItems.Visible = true;
		}

		public Dictionary<string, string[]> itemProperties = new Dictionary<string, string[]>();

		private void ItemButton_Click(object sender, EventArgs e)
		{
			CurrentPath = String.Empty;
			string pathUrl = urlCmd.Text;

			string selectedName = comboBoxStuff.SelectedItem.ToString().Remove(0,1);
			selectedName = selectedName.Remove(selectedName.Length - 1);

			RestClient client = new RestClient(connectionBox.Text);

			if (pathUrl[pathUrl.Length - 1] == '/')
			{
				//pathUrl += comboBoxStuff.SelectedItem.ToString() + "/items";
				if (pathUrl[pathUrl.Length - 2] == 's')
				{
					pathUrl = pathUrl.Remove(pathUrl.Length - 2);
					pathUrl += '/' + selectedName + "/items";
				}
			}
			else
			{
				if (pathUrl[pathUrl.Length - 1] == 's')
				{
					pathUrl = pathUrl.Remove(pathUrl.Length - 1);
					pathUrl += '/' + selectedName + "/items";
				}
			}

			CurrentPath = pathUrl.Remove(pathUrl.Length - 1) + "/";
			GetQueryComboBoxItems(client, pathUrl);

			buttonWidth.Visible = true;
			buttonHeight.Visible = true;
			buttonTop.Visible = true;
			buttonLeft.Visible = true;
			buttonHide.Visible = true;
			buttonShow.Visible = true;
			buttonDraw.Visible = true;

			itemProperties = GetDataRect();
		}

		private bool buttonHideClicked = false;
		private bool buttonShowClicked = false;
		private bool buttonWidthClicked = false;
		private bool buttonHeightClicked = false;
		private bool buttonTopClicked = false;
		private bool buttonLeftClicked = false;

		private void ButtonHide_Click(object sender, EventArgs e)
		{
			RestClient client = new RestClient(connectionBox.Text);

			buttonHide.BackColor = Color.Yellow;
			buttonShow.BackColor = Color.LightGray;
			buttonWidth.BackColor = Color.LightGray;
			buttonHeight.BackColor = Color.LightGray;
			buttonTop.BackColor = Color.LightGray;
			buttonLeft.BackColor = Color.LightGray;
			putLabel.Visible = false;
			putTextBox.Visible = false;
			buttonChange.Visible = false;

			string currentItem = comboBoxItems.SelectedItem.ToString();
			currentItem = currentItem.Remove(0, 1);
			currentItem = currentItem.Remove(currentItem.Length - 1);

			PutQueryWithoutPrinting(client, CurrentPath + currentItem, "Visible", "false");
		}

		private void ButtonShow_Click(object sender, EventArgs e)
		{
			RestClient client = new RestClient(connectionBox.Text);

			buttonHide.BackColor = Color.LightGray;
			buttonShow.BackColor = Color.Yellow;
			buttonWidth.BackColor = Color.LightGray;
			buttonHeight.BackColor = Color.LightGray;
			buttonTop.BackColor = Color.LightGray;
			buttonLeft.BackColor = Color.LightGray;
			putLabel.Visible = false;
			putTextBox.Visible = false;
			buttonChange.Visible = false;

			string currentItem = comboBoxItems.SelectedItem.ToString();
			currentItem = currentItem.Remove(0, 1);
			currentItem = currentItem.Remove(currentItem.Length - 1);

			PutQueryWithoutPrinting(client, CurrentPath + currentItem, "Visible", "true");
		}

		private void ButtonWidth_Click(object sender, EventArgs e)
		{
			RestClient client = new RestClient(connectionBox.Text);

			buttonHide.BackColor = Color.LightGray;
			buttonShow.BackColor = Color.LightGray;
			buttonWidth.BackColor = Color.Yellow;
			buttonHeight.BackColor = Color.LightGray;
			buttonTop.BackColor = Color.LightGray;
			buttonLeft.BackColor = Color.LightGray;
			putLabel.Visible = true;
			putTextBox.Visible = true;
			buttonChange.Visible = true;

			buttonWidthClicked = true;
			buttonHeightClicked = false;
			buttonTopClicked = false;
			buttonLeftClicked = false;
		}

		private void ButtonHeight_Click(object sender, EventArgs e)
		{
			RestClient client = new RestClient(connectionBox.Text);

			buttonHide.BackColor = Color.LightGray;
			buttonShow.BackColor = Color.LightGray;
			buttonWidth.BackColor = Color.LightGray;
			buttonHeight.BackColor = Color.Yellow;
			buttonTop.BackColor = Color.LightGray;
			buttonLeft.BackColor = Color.LightGray;
			putLabel.Visible = true;
			putTextBox.Visible = true;
			buttonChange.Visible = true;

			buttonWidthClicked = false;
			buttonHeightClicked = true;
			buttonTopClicked = false;
			buttonLeftClicked = false;
		}

		private void ButtonTop_Click(object sender, EventArgs e)
		{
			RestClient client = new RestClient(connectionBox.Text);

			buttonHide.BackColor = Color.LightGray;
			buttonShow.BackColor = Color.LightGray;
			buttonWidth.BackColor = Color.LightGray;
			buttonHeight.BackColor = Color.LightGray;
			buttonTop.BackColor = Color.Yellow;
			buttonLeft.BackColor = Color.LightGray;
			putLabel.Visible = true;
			putTextBox.Visible = true;
			buttonChange.Visible = true;

			buttonWidthClicked = false;
			buttonHeightClicked = false;
			buttonTopClicked = true;
			buttonLeftClicked = false;
		}

		private void ButtonLeft_Click(object sender, EventArgs e)
		{
			buttonHide.BackColor = Color.LightGray;
			buttonShow.BackColor = Color.LightGray;
			buttonWidth.BackColor = Color.LightGray;
			buttonHeight.BackColor = Color.LightGray;
			buttonTop.BackColor = Color.LightGray;
			buttonLeft.BackColor = Color.Yellow;
			putLabel.Visible = true;
			putTextBox.Visible = true;
			buttonChange.Visible = true;

			buttonWidthClicked = false;
			buttonHeightClicked = false;
			buttonTopClicked = false;
			buttonLeftClicked = true;
		}

		private void ButtonChange_Click(object sender, EventArgs e)
		{
			RestClient client = new RestClient(connectionBox.Text);

			string currentItem = comboBoxItems.SelectedItem.ToString();
			currentItem = currentItem.Remove(0, 1);
			currentItem = currentItem.Remove(currentItem.Length - 1);

			if (buttonWidthClicked)
			{
				PutQueryWithoutPrinting(client, CurrentPath + currentItem, "Width", putTextBox.Text);
			}
			else if (buttonHeightClicked)
			{
				PutQueryWithoutPrinting(client, CurrentPath + currentItem, "Height", putTextBox.Text);
			}
			else if (buttonTopClicked)
			{
				PutQueryWithoutPrinting(client, CurrentPath + currentItem, "Top", putTextBox.Text);
			}
			else if (buttonLeftClicked)
			{
				PutQueryWithoutPrinting(client, CurrentPath + currentItem, "Left", putTextBox.Text);
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			frm2 = new Form2(itemProperties);
			frm2.Show();
		}

		public Dictionary<string, string[]> GetDataRect()
		{
			Dictionary<string,string[]> dataInfo = new Dictionary<string, string[]>();
			string[] allItems = new string[comboBoxItems.Items.Count];
			int count = comboBoxStuff.Items.Count;
			RestClient client = new RestClient(connectionBox.Text);


			foreach (var item in comboBoxItems.Items)
			{
				count++;
			}

			for (int i = 0; i < comboBoxItems.Items.Count; i++)
			{
				string currentItem = comboBoxItems.GetItemText(comboBoxItems.Items[i]);
				currentItem = currentItem.Remove(0, 1);
				currentItem = currentItem.Remove(currentItem.Length - 1);

				allItems[i] = currentItem;

				string[] currItemProperties = new string[10];

				BaseFigure currFig = new BaseFigure(client, CurrentPath + currentItem);

				if (String.IsNullOrEmpty(currFig.GetPropertyText()))
				{
					BaseRectangle currRect = new BaseRectangle(client, CurrentPath + currentItem);

					currItemProperties[0] = currRect.GetPropertyLeft().ToString();
					currItemProperties[1] = currRect.GetPropertyTop().ToString();
					currItemProperties[2] = currRect.GetPropertyWidth().ToString();
					currItemProperties[3] = currRect.GetPropertyHeight().ToString();
					currItemProperties[4] = currRect.GetPropertyText();
					currItemProperties[5] = currRect.GetPropertyColor();
				}
				else
				{
					BaseText currText = new BaseText(client, CurrentPath + currentItem);

					currItemProperties[0] = currText.GetPropertyLeft().ToString();
					currItemProperties[1] = currText.GetPropertyTop().ToString();
					currItemProperties[2] = currText.GetPropertyWidth().ToString();
					currItemProperties[3] = currText.GetPropertyHeight().ToString();
					currItemProperties[4] = currText.GetPropertyText();
					currItemProperties[5] = currText.GetPropertyColor();
					currItemProperties[6] = currText.GetFontStyle();
					currItemProperties[7] = currText.GetFontSize().ToString();
					currItemProperties[8] = currText.GetFontColor();
				}


				//if (i == 0)
				//{
				//	currItemProperties = GetBackgroundProperties(CurrentPath + currentItem);
				//}
				//else
				//{
				//	currItemProperties = GetItemProperties(CurrentPath + currentItem);
				//}

				//currItemProperties[4] = CheckPropertyText(CurrentPath + currentItem);
				//currItemProperties[5] = CheckPropertyColor(CurrentPath + currentItem);

				//string[] currFontDetails = CheckFontDetails(CurrentPath + currentItem);
				//for (int j = 6; j < 9; j++)
				//{
				//	currItemProperties[j] = currFontDetails[j];
				//}

				dataInfo.Add(currentItem, currItemProperties);
			}

			return dataInfo;
		}

		private string[] GetBackgroundProperties(string pathUrl)
		{
			RestClient client = new RestClient(connectionBox.Text);
			string[] itemProperties = new string[10];
			itemProperties[0] = "";
			itemProperties[1] = "";

			RestRequest requestWidth = new RestRequest(pathUrl + "/Width/", Method.GET);
			requestWidth.AddUrlSegment("projectid", 1);

			var queryResultWidth = client.Execute(requestWidth).Content;
			int queryWidth = int.Parse(queryResultWidth);
			itemProperties[2] = queryWidth.ToString();

			RestRequest requestHeight = new RestRequest(pathUrl + "/Height/", Method.GET);
			requestHeight.AddUrlSegment("projectid", 1);

			var queryResultHeight = client.Execute(requestHeight).Content;
			int queryHeight = int.Parse(queryResultHeight);
			itemProperties[3] = queryHeight.ToString();

			return itemProperties;
		}

		private string[] GetItemProperties(string pathUrl)
		{
			RestClient client = new RestClient(connectionBox.Text);
			string[] itemProperties = new string[10];

			RestRequest requestLeft = new RestRequest(pathUrl + "/Left/", Method.GET);
			requestLeft.AddUrlSegment("projectid", 1);

			var queryResultLeft = client.Execute(requestLeft).Content;
			int queryLeft = int.Parse(queryResultLeft);
			itemProperties[0] = queryLeft.ToString();

			RestRequest requestTop = new RestRequest(pathUrl + "/Top/", Method.GET);
			requestTop.AddUrlSegment("projectid", 1);

			var queryResultTop = client.Execute(requestTop).Content;
			int queryTop = int.Parse(queryResultTop);
			itemProperties[1] = queryTop.ToString();


			RestRequest requestWidth = new RestRequest(pathUrl + "/Width/", Method.GET);
			requestWidth.AddUrlSegment("projectid", 1);

			var queryResultWidth = client.Execute(requestWidth).Content;
			int queryWidth = int.Parse(queryResultWidth);
			itemProperties[2] = queryWidth.ToString();

			RestRequest requestHeight = new RestRequest(pathUrl + "/Height/", Method.GET);
			requestHeight.AddUrlSegment("projectid", 1);

			var queryResultHeight = client.Execute(requestHeight).Content;
			int queryHeight = int.Parse(queryResultHeight);
			itemProperties[3] = queryHeight.ToString();

			return itemProperties;
		}

		private string CheckPropertyText(string pathUrl)
		{
			string queryText = String.Empty;
			try
			{
				RestClient client = new RestClient(connectionBox.Text);

				RestRequest requestText = new RestRequest(pathUrl + "/Text/", Method.GET);
				requestText.AddUrlSegment("projectid", 1);

				var queryResultText = client.Execute(requestText).Content;
				queryText = queryResultText.ToString();
			}
			catch (Exception)
			{
				return "";
			}
			return queryText;
		}

		private string CheckPropertyColor(string pathUrl)
		{
			string queryColor = String.Empty;

			try
			{
				RestClient client = new RestClient(connectionBox.Text);

				RestRequest requestText = new RestRequest(pathUrl + "/Color/", Method.GET);
				requestText.AddUrlSegment("projectid", 1);

				var queryResultText = client.Execute(requestText).Content;
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

		private string[] CheckFontDetails(string pathUrl)
		{
			string[] queryFont = new string[10];
			string currFont = string.Empty;

			try
			{
				RestClient client = new RestClient(connectionBox.Text);

				RestRequest requestFont = new RestRequest(pathUrl + "/Font/", Method.GET);
				requestFont.AddUrlSegment("projectid", 1);

				var queryResultFont = client.Execute(requestFont).Content;
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
	}



	//public static void GetQuery(RestClient client)
	//{
	//	Console.WriteLine("Enter the property's path, along with its name: ");
	//	string path = Console.ReadLine();
	//	//string requestAddress = "project/Project1/items/";
	//	string[] wordAddress = path.Split('/').ToArray();


	//	var request = new RestRequest(path, Method.GET);
	//	request.AddUrlSegment("projectid", 1);

	//	var queryResult = client.Execute(request).Content;
	//	string strQuery = queryResult.ToString();
	//	string[] wordQuery = strQuery.Split('[', ']', '{', '}', ',', ' ').ToArray();

	//	//Console.WriteLine(String.Join("\n", wordQuery));

	//	for (int i = 2; i < wordQuery.Length; i++)
	//	{
	//		Console.WriteLine(wordQuery[i]);
	//	}
	//}
}
