namespace Bauteildatenbank
{
	partial class FormAddEditDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditDialog));
			this.label_debug = new System.Windows.Forms.Label();
			this.button_Abbrechen = new System.Windows.Forms.Button();
			this.button_OK = new System.Windows.Forms.Button();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.textBox_beschreibung = new System.Windows.Forms.TextBox();
			this.textBox_stückzahl = new System.Windows.Forms.TextBox();
			this.comboBox_bauform = new System.Windows.Forms.ComboBox();
			this.comboBox_hersteller = new System.Windows.Forms.ComboBox();
			this.textBox_datenblatt = new System.Windows.Forms.TextBox();
			this.comboBox_lieferant = new System.Windows.Forms.ComboBox();
			this.textBox_preis = new System.Windows.Forms.TextBox();
			this.textBox_bestellnummer = new System.Windows.Forms.TextBox();
			this.textBox_pinbelegung = new System.Windows.Forms.TextBox();
			this.button_bauformadd = new System.Windows.Forms.Button();
			this.button_herstelleradd = new System.Windows.Forms.Button();
			this.button_lieferantadd = new System.Windows.Forms.Button();
			this.button_datenblattdurchsuchen = new System.Windows.Forms.Button();
			this.button_pinbelegungdurchsuchen = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label_debug
			// 
			this.label_debug.AutoSize = true;
			this.label_debug.Location = new System.Drawing.Point(89, 285);
			this.label_debug.Name = "label_debug";
			this.label_debug.Size = new System.Drawing.Size(285, 102);
			this.label_debug.TabIndex = 0;
			this.label_debug.Text = resources.GetString("label_debug.Text");
			// 
			// button_Abbrechen
			// 
			this.button_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_Abbrechen.Location = new System.Drawing.Point(808, 270);
			this.button_Abbrechen.Margin = new System.Windows.Forms.Padding(4);
			this.button_Abbrechen.Name = "button_Abbrechen";
			this.button_Abbrechen.Size = new System.Drawing.Size(100, 28);
			this.button_Abbrechen.TabIndex = 3;
			this.button_Abbrechen.Text = "Abbrechen";
			this.button_Abbrechen.UseVisualStyleBackColor = true;
			// 
			// button_OK
			// 
			this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_OK.Location = new System.Drawing.Point(597, 270);
			this.button_OK.Margin = new System.Windows.Forms.Padding(4);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(100, 28);
			this.button_OK.TabIndex = 2;
			this.button_OK.Text = "OK";
			this.button_OK.UseVisualStyleBackColor = true;
			// 
			// textBox_name
			// 
			this.textBox_name.Location = new System.Drawing.Point(92, 12);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(311, 22);
			this.textBox_name.TabIndex = 4;
			// 
			// textBox_beschreibung
			// 
			this.textBox_beschreibung.Location = new System.Drawing.Point(92, 40);
			this.textBox_beschreibung.Multiline = true;
			this.textBox_beschreibung.Name = "textBox_beschreibung";
			this.textBox_beschreibung.Size = new System.Drawing.Size(311, 83);
			this.textBox_beschreibung.TabIndex = 5;
			// 
			// textBox_stückzahl
			// 
			this.textBox_stückzahl.Location = new System.Drawing.Point(92, 129);
			this.textBox_stückzahl.Name = "textBox_stückzahl";
			this.textBox_stückzahl.Size = new System.Drawing.Size(311, 22);
			this.textBox_stückzahl.TabIndex = 6;
			// 
			// comboBox_bauform
			// 
			this.comboBox_bauform.FormattingEnabled = true;
			this.comboBox_bauform.Location = new System.Drawing.Point(92, 157);
			this.comboBox_bauform.Name = "comboBox_bauform";
			this.comboBox_bauform.Size = new System.Drawing.Size(311, 24);
			this.comboBox_bauform.TabIndex = 7;
			// 
			// comboBox_hersteller
			// 
			this.comboBox_hersteller.FormattingEnabled = true;
			this.comboBox_hersteller.Location = new System.Drawing.Point(92, 187);
			this.comboBox_hersteller.Name = "comboBox_hersteller";
			this.comboBox_hersteller.Size = new System.Drawing.Size(311, 24);
			this.comboBox_hersteller.TabIndex = 8;
			// 
			// textBox_datenblatt
			// 
			this.textBox_datenblatt.Location = new System.Drawing.Point(92, 217);
			this.textBox_datenblatt.Name = "textBox_datenblatt";
			this.textBox_datenblatt.Size = new System.Drawing.Size(311, 22);
			this.textBox_datenblatt.TabIndex = 9;
			// 
			// comboBox_lieferant
			// 
			this.comboBox_lieferant.FormattingEnabled = true;
			this.comboBox_lieferant.Location = new System.Drawing.Point(597, 12);
			this.comboBox_lieferant.Name = "comboBox_lieferant";
			this.comboBox_lieferant.Size = new System.Drawing.Size(311, 24);
			this.comboBox_lieferant.TabIndex = 10;
			// 
			// textBox_preis
			// 
			this.textBox_preis.Location = new System.Drawing.Point(597, 42);
			this.textBox_preis.Name = "textBox_preis";
			this.textBox_preis.Size = new System.Drawing.Size(311, 22);
			this.textBox_preis.TabIndex = 11;
			// 
			// textBox_bestellnummer
			// 
			this.textBox_bestellnummer.Location = new System.Drawing.Point(597, 70);
			this.textBox_bestellnummer.Name = "textBox_bestellnummer";
			this.textBox_bestellnummer.Size = new System.Drawing.Size(311, 22);
			this.textBox_bestellnummer.TabIndex = 12;
			// 
			// textBox_pinbelegung
			// 
			this.textBox_pinbelegung.Location = new System.Drawing.Point(597, 98);
			this.textBox_pinbelegung.Name = "textBox_pinbelegung";
			this.textBox_pinbelegung.Size = new System.Drawing.Size(311, 22);
			this.textBox_pinbelegung.TabIndex = 13;
			// 
			// button_bauformadd
			// 
			this.button_bauformadd.Location = new System.Drawing.Point(409, 157);
			this.button_bauformadd.Name = "button_bauformadd";
			this.button_bauformadd.Size = new System.Drawing.Size(54, 23);
			this.button_bauformadd.TabIndex = 14;
			this.button_bauformadd.Text = "Add";
			this.button_bauformadd.UseVisualStyleBackColor = true;
			// 
			// button_herstelleradd
			// 
			this.button_herstelleradd.Location = new System.Drawing.Point(409, 187);
			this.button_herstelleradd.Name = "button_herstelleradd";
			this.button_herstelleradd.Size = new System.Drawing.Size(54, 23);
			this.button_herstelleradd.TabIndex = 15;
			this.button_herstelleradd.Text = "Add";
			this.button_herstelleradd.UseVisualStyleBackColor = true;
			// 
			// button_lieferantadd
			// 
			this.button_lieferantadd.Location = new System.Drawing.Point(914, 12);
			this.button_lieferantadd.Name = "button_lieferantadd";
			this.button_lieferantadd.Size = new System.Drawing.Size(54, 23);
			this.button_lieferantadd.TabIndex = 16;
			this.button_lieferantadd.Text = "Add";
			this.button_lieferantadd.UseVisualStyleBackColor = true;
			// 
			// button_datenblattdurchsuchen
			// 
			this.button_datenblattdurchsuchen.Location = new System.Drawing.Point(409, 217);
			this.button_datenblattdurchsuchen.Name = "button_datenblattdurchsuchen";
			this.button_datenblattdurchsuchen.Size = new System.Drawing.Size(108, 23);
			this.button_datenblattdurchsuchen.TabIndex = 17;
			this.button_datenblattdurchsuchen.Text = "Durchsuchen";
			this.button_datenblattdurchsuchen.UseVisualStyleBackColor = true;
			// 
			// button_pinbelegungdurchsuchen
			// 
			this.button_pinbelegungdurchsuchen.Location = new System.Drawing.Point(914, 98);
			this.button_pinbelegungdurchsuchen.Name = "button_pinbelegungdurchsuchen";
			this.button_pinbelegungdurchsuchen.Size = new System.Drawing.Size(108, 23);
			this.button_pinbelegungdurchsuchen.TabIndex = 18;
			this.button_pinbelegungdurchsuchen.Text = "Durchsuchen";
			this.button_pinbelegungdurchsuchen.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(597, 133);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(311, 108);
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(594, 319);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(253, 85);
			this.label1.TabIndex = 20;
			this.label1.Text = "myRow[\"Column_BauteilLieferant\"] = 0;\r\nmyRow[\"Column_Bauteilpreis\"] = \"\";\r\nmyRow[" +
    "\"Column_Bestellnummer\"] = \"\";\r\nmyRow[\"Column_Pinbelegung\"] = \"\";\r\nGrafik der Pin" +
    "belegung\r\n";
			// 
			// FormAddEditDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1073, 472);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button_pinbelegungdurchsuchen);
			this.Controls.Add(this.button_datenblattdurchsuchen);
			this.Controls.Add(this.button_lieferantadd);
			this.Controls.Add(this.button_herstelleradd);
			this.Controls.Add(this.button_bauformadd);
			this.Controls.Add(this.textBox_pinbelegung);
			this.Controls.Add(this.textBox_bestellnummer);
			this.Controls.Add(this.textBox_preis);
			this.Controls.Add(this.comboBox_lieferant);
			this.Controls.Add(this.textBox_datenblatt);
			this.Controls.Add(this.comboBox_hersteller);
			this.Controls.Add(this.comboBox_bauform);
			this.Controls.Add(this.textBox_stückzahl);
			this.Controls.Add(this.textBox_beschreibung);
			this.Controls.Add(this.textBox_name);
			this.Controls.Add(this.button_Abbrechen);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.label_debug);
			this.Name = "FormAddEditDialog";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_debug;
		private System.Windows.Forms.Button button_Abbrechen;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.TextBox textBox_name;
		private System.Windows.Forms.TextBox textBox_beschreibung;
		private System.Windows.Forms.TextBox textBox_stückzahl;
		private System.Windows.Forms.ComboBox comboBox_bauform;
		private System.Windows.Forms.ComboBox comboBox_hersteller;
		private System.Windows.Forms.TextBox textBox_datenblatt;
		private System.Windows.Forms.ComboBox comboBox_lieferant;
		private System.Windows.Forms.TextBox textBox_preis;
		private System.Windows.Forms.TextBox textBox_bestellnummer;
		private System.Windows.Forms.TextBox textBox_pinbelegung;
		private System.Windows.Forms.Button button_bauformadd;
		private System.Windows.Forms.Button button_herstelleradd;
		private System.Windows.Forms.Button button_lieferantadd;
		private System.Windows.Forms.Button button_datenblattdurchsuchen;
		private System.Windows.Forms.Button button_pinbelegungdurchsuchen;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}