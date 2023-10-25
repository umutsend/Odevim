namespace Odevim
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			listBoxHarfler = new System.Windows.Forms.ListBox();
			buttonYeniOyun = new System.Windows.Forms.Button();
			textBoxTahmin = new System.Windows.Forms.TextBox();
			buttonTahmin = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// listBoxHarfler
			// 
			listBoxHarfler.FormattingEnabled = true;
			listBoxHarfler.ItemHeight = 20;
			listBoxHarfler.Location = new System.Drawing.Point(26, 12);
			listBoxHarfler.Name = "listBoxHarfler";
			listBoxHarfler.Size = new System.Drawing.Size(150, 384);
			listBoxHarfler.TabIndex = 0;
			// 
			// buttonYeniOyun
			// 
			buttonYeniOyun.BackColor = System.Drawing.Color.Lime;
			buttonYeniOyun.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			buttonYeniOyun.ForeColor = System.Drawing.Color.Black;
			buttonYeniOyun.Location = new System.Drawing.Point(199, 12);
			buttonYeniOyun.Name = "buttonYeniOyun";
			buttonYeniOyun.Size = new System.Drawing.Size(182, 92);
			buttonYeniOyun.TabIndex = 1;
			buttonYeniOyun.Text = "Yeni Oyun";
			buttonYeniOyun.UseVisualStyleBackColor = false;
			buttonYeniOyun.Click += buttonYeniOyun_Click;
			// 
			// textBoxTahmin
			// 
			textBoxTahmin.BackColor = System.Drawing.SystemColors.Highlight;
			textBoxTahmin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			textBoxTahmin.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			textBoxTahmin.Location = new System.Drawing.Point(199, 125);
			textBoxTahmin.Name = "textBoxTahmin";
			textBoxTahmin.Size = new System.Drawing.Size(182, 38);
			textBoxTahmin.TabIndex = 2;
			// 
			// buttonTahmin
			// 
			buttonTahmin.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
			buttonTahmin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			buttonTahmin.ForeColor = System.Drawing.Color.Black;
			buttonTahmin.Location = new System.Drawing.Point(199, 181);
			buttonTahmin.Name = "buttonTahmin";
			buttonTahmin.Size = new System.Drawing.Size(182, 92);
			buttonTahmin.TabIndex = 1;
			buttonTahmin.Text = "Tahmin Et";
			buttonTahmin.UseVisualStyleBackColor = false;
			buttonTahmin.Click += buttonTahmin_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(textBoxTahmin);
			Controls.Add(buttonTahmin);
			Controls.Add(buttonYeniOyun);
			Controls.Add(listBoxHarfler);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ListBox listBoxHarfler;
		private System.Windows.Forms.Button buttonYeniOyun;
		private System.Windows.Forms.TextBox textBoxTahmin;
		private System.Windows.Forms.Button buttonTahmin;
	}
}
