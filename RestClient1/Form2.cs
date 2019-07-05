using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestClient1
{
	public partial class Form2 : Form
	{
		Dictionary<string, string[]> dataInfo;

		public Form2(Dictionary<string, string[]> dataInfo)
		{
			InitializeComponent();
			this.dataInfo = dataInfo;
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			
		}

		private void Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void canvas_Paint(object sender, PaintEventArgs e)
		{
			Graphics gObject = canvas.CreateGraphics();
			Brush blackBrush = new SolidBrush(Color.Black);
			Pen blackPen = new Pen(Color.Black, 3);

			Form1 frm1 = new Form1();
			int count = 0;

			foreach (var figure in dataInfo)
			{
				string currColor = String.Empty;
				if (figure.Value[5].Length < 2)
				{
					currColor = "FFFFFF";
				}
				else
				{
					currColor = figure.Value[5].Remove(figure.Value[5].Length - 2);
				}

				string currTextColor = String.Empty;
				if (String.IsNullOrEmpty(figure.Value[8]))
				{
					currTextColor = "FFFFFF";
				}
				else
				{
					currTextColor = figure.Value[8].Remove(figure.Value[8].Length - 2);
				}

				Brush currBrush = new SolidBrush(Color.White);

				Font currFont = new Font("", 1);
				Brush currTextBrush = new SolidBrush(Color.White);

				if (!String.IsNullOrEmpty(figure.Value[5]))
				{
					currBrush = new SolidBrush(ColorTranslator.FromHtml("#" + currColor));
				}

				if (!String.IsNullOrEmpty(figure.Value[6]) && !String.IsNullOrEmpty(figure.Value[7]))
				{
					currFont = new Font(figure.Value[6], int.Parse(figure.Value[7]));
					currTextBrush = new SolidBrush(ColorTranslator.FromHtml("#" + currTextColor));
				}

				if (String.IsNullOrEmpty(figure.Value[0]) && String.IsNullOrEmpty(figure.Value[1])
					|| int.Parse(figure.Value[0]) == 0 && int.Parse(figure.Value[1]) == 0)
				{
					this.Width = int.Parse(figure.Value[2]);
					this.Height = int.Parse(figure.Value[3]);

					canvas.Width = int.Parse(figure.Value[2]);
					canvas.Height = int.Parse(figure.Value[3]);
				}
				else
				{
					int left = int.Parse(figure.Value[0]);
					int top = int.Parse(figure.Value[1]);
					int width = int.Parse(figure.Value[2]);
					int height = int.Parse(figure.Value[3]);

					Rectangle rect = new Rectangle(left, top, width, height);
					gObject.FillRectangle(currBrush, rect);
					gObject.DrawString(figure.Value[4], currFont, currTextBrush, rect);
				}

				count++;
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			//button1.Font = new Font("Segoe UI", 20);
		}
	}
}
