namespace RestClient1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtRestURL = new System.Windows.Forms.TextBox();
			this.txtResponse = new System.Windows.Forms.TextBox();
			this.cmdGO = new System.Windows.Forms.Button();
			this.requestLabel = new System.Windows.Forms.Label();
			this.responseLabel = new System.Windows.Forms.Label();
			this.buttonGet = new System.Windows.Forms.Button();
			this.buttonPut = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.jsonBox = new System.Windows.Forms.TextBox();
			this.jsonLabel = new System.Windows.Forms.Label();
			this.connectionBox = new System.Windows.Forms.TextBox();
			this.labelConnection = new System.Windows.Forms.Label();
			this.buttonCheck = new System.Windows.Forms.Button();
			this.colorButton = new System.Windows.Forms.Button();
			this.comboBoxStuff = new System.Windows.Forms.ComboBox();
			this.labelGet = new System.Windows.Forms.Label();
			this.urlCmd = new System.Windows.Forms.TextBox();
			this.showButton = new System.Windows.Forms.Button();
			this.comboBoxItems = new System.Windows.Forms.ComboBox();
			this.itemButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.buttonHide = new System.Windows.Forms.Button();
			this.buttonShow = new System.Windows.Forms.Button();
			this.buttonWidth = new System.Windows.Forms.Button();
			this.buttonHeight = new System.Windows.Forms.Button();
			this.buttonTop = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.putLabel = new System.Windows.Forms.Label();
			this.putTextBox = new System.Windows.Forms.TextBox();
			this.buttonChange = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.buttonDraw = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtRestURL
			// 
			this.txtRestURL.Location = new System.Drawing.Point(626, 114);
			this.txtRestURL.Name = "txtRestURL";
			this.txtRestURL.Size = new System.Drawing.Size(314, 20);
			this.txtRestURL.TabIndex = 0;
			this.txtRestURL.Visible = false;
			// 
			// txtResponse
			// 
			this.txtResponse.Location = new System.Drawing.Point(626, 244);
			this.txtResponse.Multiline = true;
			this.txtResponse.Name = "txtResponse";
			this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtResponse.Size = new System.Drawing.Size(314, 217);
			this.txtResponse.TabIndex = 1;
			this.txtResponse.Visible = false;
			this.txtResponse.TextChanged += new System.EventHandler(this.TxtResponse_TextChanged);
			// 
			// cmdGO
			// 
			this.cmdGO.Location = new System.Drawing.Point(889, 168);
			this.cmdGO.Name = "cmdGO";
			this.cmdGO.Size = new System.Drawing.Size(75, 23);
			this.cmdGO.TabIndex = 2;
			this.cmdGO.Text = "GO!";
			this.cmdGO.UseVisualStyleBackColor = true;
			this.cmdGO.Visible = false;
			this.cmdGO.Click += new System.EventHandler(this.cmdGO_Click);
			// 
			// requestLabel
			// 
			this.requestLabel.AutoSize = true;
			this.requestLabel.Location = new System.Drawing.Point(545, 117);
			this.requestLabel.Name = "requestLabel";
			this.requestLabel.Size = new System.Drawing.Size(75, 13);
			this.requestLabel.TabIndex = 3;
			this.requestLabel.Text = "Request URL:";
			this.requestLabel.Visible = false;
			// 
			// responseLabel
			// 
			this.responseLabel.AutoSize = true;
			this.responseLabel.Location = new System.Drawing.Point(562, 247);
			this.responseLabel.Name = "responseLabel";
			this.responseLabel.Size = new System.Drawing.Size(58, 13);
			this.responseLabel.TabIndex = 4;
			this.responseLabel.Text = "Response:";
			this.responseLabel.Visible = false;
			// 
			// buttonGet
			// 
			this.buttonGet.BackColor = System.Drawing.Color.LightGray;
			this.buttonGet.Location = new System.Drawing.Point(1001, 118);
			this.buttonGet.Name = "buttonGet";
			this.buttonGet.Size = new System.Drawing.Size(140, 49);
			this.buttonGet.TabIndex = 5;
			this.buttonGet.Text = "Get";
			this.buttonGet.UseVisualStyleBackColor = false;
			this.buttonGet.Visible = false;
			this.buttonGet.Click += new System.EventHandler(this.ButtonGet_Click);
			// 
			// buttonPut
			// 
			this.buttonPut.BackColor = System.Drawing.Color.LightGray;
			this.buttonPut.Location = new System.Drawing.Point(1001, 180);
			this.buttonPut.Name = "buttonPut";
			this.buttonPut.Size = new System.Drawing.Size(140, 49);
			this.buttonPut.TabIndex = 6;
			this.buttonPut.Text = "Put";
			this.buttonPut.UseVisualStyleBackColor = false;
			this.buttonPut.Visible = false;
			this.buttonPut.Click += new System.EventHandler(this.ButtonPut_Click_1);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.LightGray;
			this.buttonDelete.Location = new System.Drawing.Point(1001, 244);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(140, 49);
			this.buttonDelete.TabIndex = 7;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Visible = false;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click_1);
			// 
			// jsonBox
			// 
			this.jsonBox.Location = new System.Drawing.Point(626, 149);
			this.jsonBox.Multiline = true;
			this.jsonBox.Name = "jsonBox";
			this.jsonBox.Size = new System.Drawing.Size(185, 62);
			this.jsonBox.TabIndex = 8;
			this.jsonBox.Visible = false;
			// 
			// jsonLabel
			// 
			this.jsonLabel.AutoSize = true;
			this.jsonLabel.Location = new System.Drawing.Point(550, 154);
			this.jsonLabel.Name = "jsonLabel";
			this.jsonLabel.Size = new System.Drawing.Size(70, 13);
			this.jsonLabel.TabIndex = 9;
			this.jsonLabel.Text = "Format JSON";
			this.jsonLabel.Visible = false;
			this.jsonLabel.Click += new System.EventHandler(this.Label3_Click);
			// 
			// connectionBox
			// 
			this.connectionBox.Location = new System.Drawing.Point(371, 48);
			this.connectionBox.Name = "connectionBox";
			this.connectionBox.Size = new System.Drawing.Size(314, 20);
			this.connectionBox.TabIndex = 10;
			// 
			// labelConnection
			// 
			this.labelConnection.AutoSize = true;
			this.labelConnection.Location = new System.Drawing.Point(268, 51);
			this.labelConnection.Name = "labelConnection";
			this.labelConnection.Size = new System.Drawing.Size(97, 13);
			this.labelConnection.TabIndex = 11;
			this.labelConnection.Text = "Check connection:";
			// 
			// buttonCheck
			// 
			this.buttonCheck.Location = new System.Drawing.Point(691, 45);
			this.buttonCheck.Name = "buttonCheck";
			this.buttonCheck.Size = new System.Drawing.Size(75, 23);
			this.buttonCheck.TabIndex = 12;
			this.buttonCheck.Text = "Check";
			this.buttonCheck.UseVisualStyleBackColor = true;
			this.buttonCheck.Click += new System.EventHandler(this.Button1_Click);
			// 
			// colorButton
			// 
			this.colorButton.Location = new System.Drawing.Point(788, 44);
			this.colorButton.Name = "colorButton";
			this.colorButton.Size = new System.Drawing.Size(23, 24);
			this.colorButton.TabIndex = 13;
			this.colorButton.UseVisualStyleBackColor = true;
			// 
			// comboBoxStuff
			// 
			this.comboBoxStuff.FormattingEnabled = true;
			this.comboBoxStuff.Location = new System.Drawing.Point(67, 180);
			this.comboBoxStuff.Name = "comboBoxStuff";
			this.comboBoxStuff.Size = new System.Drawing.Size(168, 21);
			this.comboBoxStuff.TabIndex = 14;
			this.comboBoxStuff.Visible = false;
			// 
			// labelGet
			// 
			this.labelGet.AutoSize = true;
			this.labelGet.Location = new System.Drawing.Point(24, 121);
			this.labelGet.Name = "labelGet";
			this.labelGet.Size = new System.Drawing.Size(37, 13);
			this.labelGet.TabIndex = 15;
			this.labelGet.Text = "/GET:";
			this.labelGet.Visible = false;
			// 
			// urlCmd
			// 
			this.urlCmd.Location = new System.Drawing.Point(67, 118);
			this.urlCmd.Name = "urlCmd";
			this.urlCmd.Size = new System.Drawing.Size(212, 20);
			this.urlCmd.TabIndex = 16;
			this.urlCmd.Visible = false;
			this.urlCmd.TextChanged += new System.EventHandler(this.UrlCmd_TextChanged);
			// 
			// showButton
			// 
			this.showButton.Location = new System.Drawing.Point(107, 147);
			this.showButton.Name = "showButton";
			this.showButton.Size = new System.Drawing.Size(75, 23);
			this.showButton.TabIndex = 17;
			this.showButton.Text = "Show";
			this.showButton.UseVisualStyleBackColor = true;
			this.showButton.Visible = false;
			this.showButton.Click += new System.EventHandler(this.Button1_Click_1);
			// 
			// comboBoxItems
			// 
			this.comboBoxItems.FormattingEnabled = true;
			this.comboBoxItems.Location = new System.Drawing.Point(255, 180);
			this.comboBoxItems.Name = "comboBoxItems";
			this.comboBoxItems.Size = new System.Drawing.Size(150, 21);
			this.comboBoxItems.TabIndex = 18;
			this.comboBoxItems.Visible = false;
			// 
			// itemButton
			// 
			this.itemButton.Location = new System.Drawing.Point(290, 147);
			this.itemButton.Name = "itemButton";
			this.itemButton.Size = new System.Drawing.Size(75, 23);
			this.itemButton.TabIndex = 19;
			this.itemButton.Text = "Show";
			this.itemButton.UseVisualStyleBackColor = true;
			this.itemButton.Visible = false;
			this.itemButton.Click += new System.EventHandler(this.ItemButton_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(501, 94);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(10, 381);
			this.button1.TabIndex = 20;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			// 
			// buttonHide
			// 
			this.buttonHide.BackColor = System.Drawing.Color.LightGray;
			this.buttonHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHide.Location = new System.Drawing.Point(142, 232);
			this.buttonHide.Name = "buttonHide";
			this.buttonHide.Size = new System.Drawing.Size(75, 42);
			this.buttonHide.TabIndex = 21;
			this.buttonHide.Text = "Hide";
			this.buttonHide.UseVisualStyleBackColor = false;
			this.buttonHide.Visible = false;
			this.buttonHide.Click += new System.EventHandler(this.ButtonHide_Click);
			// 
			// buttonShow
			// 
			this.buttonShow.BackColor = System.Drawing.Color.LightGray;
			this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonShow.Location = new System.Drawing.Point(142, 280);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(75, 42);
			this.buttonShow.TabIndex = 22;
			this.buttonShow.Text = "Show";
			this.buttonShow.UseVisualStyleBackColor = false;
			this.buttonShow.Visible = false;
			this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
			// 
			// buttonWidth
			// 
			this.buttonWidth.BackColor = System.Drawing.Color.LightGray;
			this.buttonWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonWidth.Location = new System.Drawing.Point(223, 232);
			this.buttonWidth.Name = "buttonWidth";
			this.buttonWidth.Size = new System.Drawing.Size(75, 42);
			this.buttonWidth.TabIndex = 23;
			this.buttonWidth.Text = "Width";
			this.buttonWidth.UseVisualStyleBackColor = false;
			this.buttonWidth.Visible = false;
			this.buttonWidth.Click += new System.EventHandler(this.ButtonWidth_Click);
			// 
			// buttonHeight
			// 
			this.buttonHeight.BackColor = System.Drawing.Color.LightGray;
			this.buttonHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHeight.Location = new System.Drawing.Point(223, 280);
			this.buttonHeight.Name = "buttonHeight";
			this.buttonHeight.Size = new System.Drawing.Size(75, 42);
			this.buttonHeight.TabIndex = 24;
			this.buttonHeight.Text = "Height";
			this.buttonHeight.UseVisualStyleBackColor = false;
			this.buttonHeight.Visible = false;
			this.buttonHeight.Click += new System.EventHandler(this.ButtonHeight_Click);
			// 
			// buttonTop
			// 
			this.buttonTop.BackColor = System.Drawing.Color.LightGray;
			this.buttonTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonTop.Location = new System.Drawing.Point(304, 232);
			this.buttonTop.Name = "buttonTop";
			this.buttonTop.Size = new System.Drawing.Size(75, 42);
			this.buttonTop.TabIndex = 25;
			this.buttonTop.Text = "Top";
			this.buttonTop.UseVisualStyleBackColor = false;
			this.buttonTop.Visible = false;
			this.buttonTop.Click += new System.EventHandler(this.ButtonTop_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.BackColor = System.Drawing.Color.LightGray;
			this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonLeft.Location = new System.Drawing.Point(304, 280);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(75, 42);
			this.buttonLeft.TabIndex = 26;
			this.buttonLeft.Text = "Left";
			this.buttonLeft.UseVisualStyleBackColor = false;
			this.buttonLeft.Visible = false;
			this.buttonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
			// 
			// putLabel
			// 
			this.putLabel.AutoSize = true;
			this.putLabel.Location = new System.Drawing.Point(27, 338);
			this.putLabel.Name = "putLabel";
			this.putLabel.Size = new System.Drawing.Size(37, 13);
			this.putLabel.TabIndex = 27;
			this.putLabel.Text = "/PUT:";
			this.putLabel.Visible = false;
			// 
			// putTextBox
			// 
			this.putTextBox.Location = new System.Drawing.Point(70, 338);
			this.putTextBox.Name = "putTextBox";
			this.putTextBox.Size = new System.Drawing.Size(235, 20);
			this.putTextBox.TabIndex = 28;
			this.putTextBox.Visible = false;
			// 
			// buttonChange
			// 
			this.buttonChange.Location = new System.Drawing.Point(311, 333);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(75, 23);
			this.buttonChange.TabIndex = 29;
			this.buttonChange.Text = "Change";
			this.buttonChange.UseVisualStyleBackColor = true;
			this.buttonChange.Visible = false;
			this.buttonChange.Click += new System.EventHandler(this.ButtonChange_Click);
			// 
			// buttonDraw
			// 
			this.buttonDraw.Location = new System.Drawing.Point(344, 388);
			this.buttonDraw.Name = "buttonDraw";
			this.buttonDraw.Size = new System.Drawing.Size(76, 72);
			this.buttonDraw.TabIndex = 30;
			this.buttonDraw.Text = "Draw";
			this.buttonDraw.UseVisualStyleBackColor = true;
			this.buttonDraw.Visible = false;
			this.buttonDraw.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1162, 476);
			this.Controls.Add(this.buttonDraw);
			this.Controls.Add(this.buttonChange);
			this.Controls.Add(this.putTextBox);
			this.Controls.Add(this.putLabel);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.buttonTop);
			this.Controls.Add(this.buttonHeight);
			this.Controls.Add(this.buttonWidth);
			this.Controls.Add(this.buttonShow);
			this.Controls.Add(this.buttonHide);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.itemButton);
			this.Controls.Add(this.comboBoxItems);
			this.Controls.Add(this.showButton);
			this.Controls.Add(this.urlCmd);
			this.Controls.Add(this.labelGet);
			this.Controls.Add(this.comboBoxStuff);
			this.Controls.Add(this.colorButton);
			this.Controls.Add(this.buttonCheck);
			this.Controls.Add(this.labelConnection);
			this.Controls.Add(this.connectionBox);
			this.Controls.Add(this.jsonLabel);
			this.Controls.Add(this.jsonBox);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonPut);
			this.Controls.Add(this.buttonGet);
			this.Controls.Add(this.responseLabel);
			this.Controls.Add(this.requestLabel);
			this.Controls.Add(this.cmdGO);
			this.Controls.Add(this.txtResponse);
			this.Controls.Add(this.txtRestURL);
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtRestURL;
		private System.Windows.Forms.Button cmdGO;
		private System.Windows.Forms.Label requestLabel;
		private System.Windows.Forms.Label responseLabel;
		private System.Windows.Forms.Button buttonGet;
		private System.Windows.Forms.Button buttonPut;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.TextBox jsonBox;
		private System.Windows.Forms.Label jsonLabel;
		private System.Windows.Forms.TextBox connectionBox;
		private System.Windows.Forms.Label labelConnection;
		private System.Windows.Forms.Button buttonCheck;
		private System.Windows.Forms.Button colorButton;
		private System.Windows.Forms.TextBox txtResponse;
		private System.Windows.Forms.ComboBox comboBoxStuff;
		private System.Windows.Forms.Label labelGet;
		private System.Windows.Forms.TextBox urlCmd;
		private System.Windows.Forms.Button showButton;
		private System.Windows.Forms.ComboBox comboBoxItems;
		private System.Windows.Forms.Button itemButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonHide;
		private System.Windows.Forms.Button buttonShow;
		private System.Windows.Forms.Button buttonWidth;
		private System.Windows.Forms.Button buttonHeight;
		private System.Windows.Forms.Button buttonTop;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Label putLabel;
		private System.Windows.Forms.TextBox putTextBox;
		private System.Windows.Forms.Button buttonChange;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button buttonDraw;
	}
}

