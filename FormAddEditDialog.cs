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
		public DataSet DataSetBuffer { get; set; }

		public FormAddEditDialog()
		{
			InitializeComponent();
			this.button_OK.DialogResult = DialogResult.OK;
			this.button_Abbrechen.DialogResult = DialogResult.Cancel;
			//application_style_Init(); // daran wird auch noch gearbeitet.
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

		public void fillFromDataSet()
		{
			bauformbindingSource.DataSource = DataSetBuffer;
			bauformbindingSource.DataMember = "Bauform";
			comboBox_bauform.DataSource = bauformbindingSource;
			comboBox_bauform.DisplayMember = "Column_Bauform";

			herstellerbindingSource.DataSource = DataSetBuffer;
			herstellerbindingSource.DataMember = "Hersteller";
			comboBox_hersteller.DataSource = herstellerbindingSource;
			comboBox_hersteller.DisplayMember = "Column_Herstellername";

			lieferantbindingSource.DataSource = DataSetBuffer;
			lieferantbindingSource.DataMember = "Lieferant";
			comboBox_lieferant.DataSource = lieferantbindingSource;
			comboBox_lieferant.DisplayMember = "Column_Lieferantname";

			bauteileBindingSource.DataSource = DataSetBuffer;
			bauteileBindingSource.DataMember = "Bauteile";
			// für den aktuellen Datensatz.
		}

	}
}
