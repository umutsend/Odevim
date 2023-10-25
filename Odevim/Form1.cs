using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Odevim
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Random random = new Random();
		string secilenArac;


		private void buttonYeniOyun_Click(object sender, EventArgs e)
		{
			string[] kelimeler = { "volkswagen", "audi", "bmw", "renault", "dacia", "skodia", "fiat", "maserati", "lamborghini", "ferrari", "ford", "citroen", "honda", "hyundai", "peugeot", "opel", "nissan", "mercedes", "toyota", "volvo", "mazda", "alfa romeo", "aston martin", "bentley" };
			secilenArac = kelimeler[random.Next(0, 24)];
			buttonTahmin.Enabled = true;
			textBoxTahmin.Enabled = true;
			textBoxTahmin.Text = "";
			listBoxHarfler.Items.Clear();

		}

		private void buttonTahmin_Click(object sender, EventArgs e)
		{
			string yazilan = textBoxTahmin.Text;
			char[] yazilanharfler = yazilan.ToCharArray();
			string secilenharfler;
			if (yazilan == secilenArac)
			{
				MessageBox.Show("Tebrikler buldunuz.");
			}
			else
			{
				foreach (char item in yazilan)
				{
					string mesaj = "Harf bulunamadı";
					if (secilenArac.Contains(item) && !secilenharfler.Contains(item))
					{
						secilenharfler += $"{item},";
					}
					else if (!secilenArac.Contains(item))
					{

						listBoxHarfler.Items.Add(mesaj);
					}
					textBoxTahmin.Text = "";
				}
				if (secilenharfler != "")
				{
					secilenharfler = secilenharfler.TrimEnd(',');
				}
				listBoxHarfler.Items.Add(secilenharfler);


			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			textBoxTahmin.Enabled=false;
			buttonTahmin.Enabled = false;
		}
	}
}
