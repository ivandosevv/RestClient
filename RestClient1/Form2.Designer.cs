﻿namespace RestClient1
{
	partial class Form2
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
			this.canvas = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// canvas
			// 
			this.canvas.Location = new System.Drawing.Point(4, 2);
			this.canvas.Name = "canvas";
			this.canvas.Size = new System.Drawing.Size(1594, 939);
			this.canvas.TabIndex = 0;
			this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1156, 652);
			this.Controls.Add(this.canvas);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel canvas;
	}
}