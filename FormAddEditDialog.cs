using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bauteildatenbank
{
	public partial class FormAddEditDialog : Form
	{
		// Eigenschaften (hier probiere ich noch rum ...)
		public string BauteilName {
			get => textBox_name.Text;
			set => textBox_name.Text = value;
		}
		public string Beschreibung { 
			get => textBox_beschreibung.Text;
			set => textBox_beschreibung.Text = value;
		}
		public string Stückzahl {
			get => textBox_stückzahl.Text;
			set => textBox_stückzahl.Text = value;
		}
		public object BauformDs { 
			get => comboBox_bauform.DataSource;
			set => comboBox_bauform.DataSource = value;
		}
		public object HerstellerDs { 
			get => comboBox_hersteller.DataSource;
			set => comboBox_hersteller.DataSource = value;
		}
		public string Datenblatt { 
			get => textBox_datenblatt.Text;
			set => textBox_datenblatt.Text = value;
		}
		public object LieferantDs { 
			get => comboBox_lieferant.DataSource;
			set => comboBox_lieferant.DataSource = value;
		}
		public string Preis {
			get => textBox_preis.Text;
			set => textBox_preis.Text = value;
		}
		public string Bestellnummer { 
			get => textBox_bestellnummer.Text;
			set => textBox_bestellnummer.Text = value;
		}
		public string Pinbelegung { 
			get => textBox_pinbelegung.Text;
			set => textBox_pinbelegung.Text = value;
		}

		public FormAddEditDialog()
		{
			InitializeComponent();
			//application_style_Init(); // daran wird auch noch gearbeitet.

			this.button_OK.DialogResult = DialogResult.OK;
			this.button_Abbrechen.DialogResult = DialogResult.Cancel;
		}

		private void application_style_Init()
		{
			// Form
			// ----------------------------------------
			this.AutoScaleMode = 0; // None
			this.BackColor = Color.FromArgb(41, 44, 51); // RGB Color
			this.DoubleBuffered = true; // flickerfree Refresh
			this.Font = new Font("Century Gothic", 12, GraphicsUnit.Point);
			this.ForeColor = Color.FromArgb(0, 122, 225); // RGB Color
			this.FormBorderStyle = 0; // None
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Add/Edit Bauteil";
		}

	}
}
