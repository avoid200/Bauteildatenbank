using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;            // wegen stream reader und file exsist
using System.Threading;			// wegen Timer in eigenem Thread
using System.Collections;   // wegen arraylist
using System.Diagnostics;   // wegen Process
using Microsoft.Win32;      // wegen .Net Version abfrage der Registry

namespace Bauteildatenbank
{
	public partial class mainForm : System.Windows.Forms.Form
	{
		private bool debugging = false;                                                 // ist die DebugAnzeige an oder aus?
		private bool moving = false;                                                   // ob Form bewegt werden darf.
		private Point startLocation;                                                   // startpunkt der form bewegung.
		private Control startpb;                                                       // controll für form postition bei bewegung.
		private DataGridView mainsender;																							 // zur MenuItem main control bestimmung.
		private bool complete = true;                                                  // ist der Hintergrundprozess abgeschlossen?
		private string filePath = Application.StartupPath + "\\Datenbank.xml";         // fester Pfad der Datenbank.
		private string statusalt = "", statusneu = "";
		private int[] dataGridEdit = new int[3];                                       // editState=(0/1), editRow=(0-n), editColmun=(0-n)

		public mainForm()
		{
			InitializeComponent();
			windows_net_version_Get();
			application_style_Init();
		}                                                           //+ initialisiert die Anwendung.


		private void windows_net_version_Get()
		{
			const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";
			using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
			{
				if (ndpKey != null && ndpKey.GetValue("Release") != null)
				{
					debuging_message_Show(".NET Framework Version: " + CheckFor45PlusVersion((int)ndpKey.GetValue("Release")) + "\n");
				}
				else
				{
					Exception ex = new Exception(".NET Framework Version 4.5 or later is not detected.\n");
					error_message_Show(ex);
				}
			}
		}                                      //+ fragt die installierte .Net framework Version ab.

		private static string CheckFor45PlusVersion(int releaseKey)
		{
			if (releaseKey >= 461808)
				return "4.7.2 or later";
			if (releaseKey >= 461308)
				return "4.7.1";
			if (releaseKey >= 460798)
				return "4.7";
			if (releaseKey >= 394802)
				return "4.6.2";
			if (releaseKey >= 394254)
				return "4.6.1";
			if (releaseKey >= 393295)
				return "4.6";
			if (releaseKey >= 379893)
				return "4.5.2";
			if (releaseKey >= 378675)
				return "4.5.1";
			if (releaseKey >= 378389)
				return "4.5";
			// This code should never execute. A non-null release key should mean
			// that 4.5 or later is installed.
			return "No 4.5 or later version detected";
		}                 //+ prüft ob die installierte .Net framework Version kompatiebel ist.

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
			this.Text = "Bauteildatenbank";

			// Label for Logo
			// ----------------------------------------
			// AutoSize = True;
			// BackColor = Color.FromArgb(38, 40, 47);
			// Font = new Font("Magneto", 46, FontStyle.Bold, FontStyle.Italic, GraphicsUnit.Point);
			// ForeColor = Color.FromArgb(0, 122, 225);
			// Text = "";

			// Button / ImageButton
			// ----------------------------------------
			// BackColor = Color.FromArgb(41, 44, 51);
			// Dock = Top;
			// FlatStyle = Flat;
			// Font = new Font("Century Gothic", 11, FontStyle.Bold, GraphicsUnit.Point);
			// ForeColor = Color.White;
			// Text = "";
			// TextAlign = BottomCenter;
			// TextImageRelation = ImageAboveText;
			// UseVisualStyleBakcColor = True;

			// Textbox
			// ----------------------------------------
			// BackColor = Color.FromArgb(60, 64, 74);
			// BorderStyle = BorderStyle.FixedSingle;
			// Font = new Font("Century Gothic", 11, GraphicsUnit.Point);
			// ForeColor = Color.White;
			// Text = " ...";

			// TextboxTopLabel Überschrift
			// ----------------------------------------
			label_titel.AutoSize = true;
			label_titel.BackColor = Color.FromArgb(41, 44, 51);
			label_titel.Font = new Font("Century Gothic", 14, FontStyle.Bold, GraphicsUnit.Point);
			label_titel.ForeColor = Color.FromArgb(0, 122, 225);
			label_titel.Text = "Bauteildatenbank";
			// StatusStrip
			// ----------------------------------------
			statusStrip1.BackColor = this.BackColor;
			statusStrip1.Font = new Font("Century Gothic", 9, GraphicsUnit.Point);
			statusStrip1.ForeColor = Color.White;
			// DataGridView1
			// ----------------------------------------
			dataGridView1.ReadOnly = true;																	// bearbeiten nur per rechtsklick mit der maus.
			dataGridView1.AllowUserToAddRows = false;												// entfernt die leere zeile am ende der einträge.
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.BackgroundColor = Color.FromArgb(60, 64, 74);
			dataGridView1.GridColor = this.BackColor;
			dataGridView1.EnableHeadersVisualStyles = false;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridView1.ColumnHeadersHeight = 30;
			dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold, GraphicsUnit.Point);
			dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = this.ForeColor;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
			dataGridView1.RowTemplate.ReadOnly = false;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 8, GraphicsUnit.Point);
			dataGridView1.DefaultCellStyle.ForeColor = Color.White;
			dataGridView1.DefaultCellStyle.BackColor = dataGridView1.BackgroundColor;
			dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
			dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 54, 64);
			dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 40, 47);
			dataGridView1.DefaultCellStyle.SelectionBackColor = this.ForeColor;
			dataGridView1.DefaultCellStyle.Padding = new Padding(0, 4, 0, 4);
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			// DataGridView2 wie 1
			// ----------------------------------------
			dataGridView2.ReadOnly = dataGridView1.ReadOnly;
			dataGridView2.AllowUserToAddRows = dataGridView1.AllowUserToAddRows;
			dataGridView2.BorderStyle = dataGridView1.BorderStyle;
			dataGridView2.BackgroundColor = dataGridView1.BackgroundColor;
			dataGridView2.GridColor = dataGridView1.GridColor;
			dataGridView2.EnableHeadersVisualStyles = dataGridView1.EnableHeadersVisualStyles;
			dataGridView2.ColumnHeadersBorderStyle = dataGridView1.ColumnHeadersBorderStyle;
			dataGridView2.ColumnHeadersHeight = dataGridView1.ColumnHeadersHeight;
			dataGridView2.ColumnHeadersDefaultCellStyle = dataGridView1.ColumnHeadersDefaultCellStyle;
			dataGridView2.RowTemplate = dataGridView1.RowTemplate;
			dataGridView2.RowTemplate.ReadOnly = dataGridView1.RowTemplate.ReadOnly;
			dataGridView2.RowHeadersVisible = dataGridView1.RowHeadersVisible;
			dataGridView2.CellBorderStyle = dataGridView1.CellBorderStyle;
			dataGridView2.DefaultCellStyle = dataGridView1.DefaultCellStyle;
			dataGridView2.AlternatingRowsDefaultCellStyle = dataGridView1.AlternatingRowsDefaultCellStyle;
			dataGridView2.SelectionMode = dataGridView1.SelectionMode;
			dataGridView2.AutoSizeColumnsMode = dataGridView1.AutoSizeColumnsMode;
			// DataGridView3 wie 1
			// ----------------------------------------
			dataGridView3.ReadOnly = dataGridView1.ReadOnly;
			dataGridView3.AllowUserToAddRows = dataGridView1.AllowUserToAddRows;
			dataGridView3.BorderStyle = dataGridView1.BorderStyle;
			dataGridView3.BackgroundColor = dataGridView1.BackgroundColor;
			dataGridView3.GridColor = dataGridView1.GridColor;
			dataGridView3.EnableHeadersVisualStyles = dataGridView1.EnableHeadersVisualStyles;
			dataGridView3.ColumnHeadersBorderStyle = dataGridView1.ColumnHeadersBorderStyle;
			dataGridView3.ColumnHeadersHeight = dataGridView1.ColumnHeadersHeight;
			dataGridView3.ColumnHeadersDefaultCellStyle = dataGridView1.ColumnHeadersDefaultCellStyle;
			dataGridView3.RowTemplate = dataGridView1.RowTemplate;
			dataGridView3.RowTemplate.ReadOnly = dataGridView1.RowTemplate.ReadOnly;
			dataGridView3.RowHeadersVisible = dataGridView1.RowHeadersVisible;
			dataGridView3.CellBorderStyle = dataGridView1.CellBorderStyle;
			dataGridView3.DefaultCellStyle = dataGridView1.DefaultCellStyle;
			dataGridView3.AlternatingRowsDefaultCellStyle = dataGridView1.AlternatingRowsDefaultCellStyle;
			dataGridView3.SelectionMode = dataGridView1.SelectionMode;
			dataGridView3.AutoSizeColumnsMode = dataGridView1.AutoSizeColumnsMode;
			// DataGridView4 wie 1
			// ----------------------------------------
			dataGridView4.ReadOnly = dataGridView1.ReadOnly;
			dataGridView4.AllowUserToAddRows = dataGridView1.AllowUserToAddRows;
			dataGridView4.BorderStyle = dataGridView1.BorderStyle;
			dataGridView4.BackgroundColor = dataGridView1.BackgroundColor;
			dataGridView4.GridColor = dataGridView1.GridColor;
			dataGridView4.EnableHeadersVisualStyles = dataGridView1.EnableHeadersVisualStyles;
			dataGridView4.ColumnHeadersBorderStyle = dataGridView1.ColumnHeadersBorderStyle;
			dataGridView4.ColumnHeadersHeight = dataGridView1.ColumnHeadersHeight;
			dataGridView4.ColumnHeadersDefaultCellStyle = dataGridView1.ColumnHeadersDefaultCellStyle;
			dataGridView4.RowTemplate = dataGridView1.RowTemplate;
			dataGridView4.RowTemplate.ReadOnly = dataGridView1.RowTemplate.ReadOnly;
			dataGridView4.RowHeadersVisible = dataGridView1.RowHeadersVisible;
			dataGridView4.CellBorderStyle = dataGridView1.CellBorderStyle;
			dataGridView4.DefaultCellStyle = dataGridView1.DefaultCellStyle;
			dataGridView4.AlternatingRowsDefaultCellStyle = dataGridView1.AlternatingRowsDefaultCellStyle;
			dataGridView4.SelectionMode = dataGridView1.SelectionMode;
			dataGridView4.AutoSizeColumnsMode = dataGridView1.AutoSizeColumnsMode;

			debuging_message_Show("Style initialisiert ...");
		}                                       //+ initialisiert den Style der Anwendung.

		private void application_mouse_drag_Form(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				// Form mit Maus verschieben
				moving = true;
				startpb = (Control)sender;
				startLocation = e.Location;
				debuging_message_Show("Start Form Moveing ...");
			}
		}   //+ verschiebt die Anwendung per MausDrag.

		private void application_mouse_move_form(object sender, MouseEventArgs e)
		{
			if (moving)
			{
				debuging_message_Show("Move ...");
				startpb.Left += e.Location.X - startLocation.X;
				startpb.Top += e.Location.Y - startLocation.Y;
			}
		}   //+ verschiebt das Formular mit der Maus.

		private void application_mouse_drop_Form(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				moving = false;
				debuging_message_Show("Stop Form Moveing ...");
			}
		}   //+ verschiebt die Anwendung per MausDrag.

		private void button_exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}                  //+ beendet die Anwendung.

		private void button_minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}              //+ minimiert das Fenster der Anwendung.

		private void statusstrip_update_Status(string sn)
		{
			// evtl. noch automatisches zurücksetzen mittels timer?
			statusneu = sn;
			if (sn != statusalt || sn != "")
			{
				toolStripStatusLabel1.Text = "Status: " + statusneu;
				statusalt = sn;
			}
		}                           //+ aktualisiert den Status im Statusstrip.

		private void datagridview_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				// setze Focus bzw. selection auf die angeklickte zelle.
				// öffne KontextMenü auf der Position der Maus.
				string editcontrol;
				mainsender = sender as DataGridView;

				if (mainsender.Name.Contains("dataGridView")) {
					editcontrol = mainsender.Name;
				}
				else
				{
					editcontrol = "";
				}
				ContextMenu m = new ContextMenu();
				m.MenuItems.Add(new MenuItem("Hinzufügen", new EventHandler(dataset_entry_Add)));
				mainsender.ClearSelection();
				try {
					mainsender.CurrentCell = mainsender.Rows[mainsender.HitTest(e.X, e.Y).RowIndex].Cells[mainsender.HitTest(e.X, e.Y).ColumnIndex];
					mainsender.Rows[mainsender.HitTest(e.X, e.Y).RowIndex].Selected = true;
					int editrow = mainsender.CurrentCell.RowIndex;
					int editcolumn = mainsender.CurrentCell.ColumnIndex;
					debuging_message_Show("Control: " + editcontrol + " Zeile: " + editrow + " Spalte: " + editcolumn);
					m.MenuItems.Add(new MenuItem("Bearbeiten", new EventHandler(dataset_entry_Edit)));
					m.MenuItems.Add(new MenuItem("Löschen", new EventHandler(dataset_entry_Delete)));
				}
				catch {
					debuging_message_Show("Control: " + editcontrol + " null");
				}
				m.MenuItems.Add(new MenuItem("Abbrechen", new EventHandler(dataset_entry_Cancle)));
				m.Show(mainsender, new Point(e.X, e.Y));
			}
			if (e.Button == MouseButtons.Left)
			{
				//
			}
		}       //+ regelt mausclick auf die DataGridView Zelle.

		private void datagridview_bauteile_Searchfilter()
		{
			// ein Beispielcode aus anderem Projekt der überarbeitet werden muss.

			//DataRow row = dataTableMesspunkte.Rows.Find(textBox_RFP.Text);
			//int rowIndex = dataTableMesspunkte.Rows.IndexOf(row);
			//MessageBox.Show("RFP in Zeile " + rowIndex + " gefunden.");

			//if (e.ColumnIndex >= 0 && e.ColumnIndex < dataTable_Tickets.Columns.Count && e.RowIndex >= 0 && e.RowIndex < dataTable_Tickets.Rows.Count)
			//{
			//	if (dataTable_Tickets.Rows[e.RowIndex].RowState != DataRowState.Deleted)
			//	{
			//		if (dataTable_Tickets.Columns[e.ColumnIndex].ToString() == "EditIcon")
			//		{
			//			// laden des edit Formular
			//		}
			//	}
			//}

			//DataRow[] liste;
			//liste = dataTable_Kunden.Select("Firma='" + comboBox_Kunde.SelectedValue + "'");
			//foreach (DataRow row in liste)
			//{
			//	textBox_Kundennummer.Text = row.ItemArray[0].ToString();
			//	textBox_Firma.Text = row.ItemArray[1].ToString();
			//	textBox_Name.Text = row.ItemArray[2].ToString();
			//	textBox_Adresse.Text = row.ItemArray[3].ToString();
			//	textBox_Telefonnummer.Text = row.ItemArray[4].ToString();
			//}
		}                           // filtert die Anzeige im DataGridView_Bauteile. (noch unerledigt)

		private void dataset_entry_example_Add(object sender, EventArgs e)
		{
			//Tabelle:Bauteile(dataTable_bauteile) // alles strings bis auf Stückzahl und ID
			//			0- Name(Column_Bauteilname)
			//			1- Beschreibung(Column_Bauteilbeschreibung)
			//			2- Stückzahl(Column_Bauteilstückzahl)
			//			3- Bauform(Column_Bauteilbauform)
			//		  4- Hersteller(Column_Bauteilhersteller)
			//			5- ID(Column_Id)
			//			6- Datenblatt(Column_Bauteildatenblatt)
			//			7- Lieferant(Column_BauteilLieferant)
			//			8- Preis(Column_Bauteilpreis)
			//			9- Bestellnummer(Column_Bestellnummer)
			//		 10- Pinbelegung(Column_Pinbelegung)
			//Tabelle:Hersteller(dataTable_hersteller)
			//			0- Name(Column_Herstellername)
			//			1- Logo(Column_Herstellerlogo)
			//			2- ID(Column_Herstellerid)
			//Tabelle:Bauform(dataTable_bauform)
			//			0- Bauform(Column_Bauform)
			//			1- ID(Column_Bauformid)
			//Tabelle:Lieferant(dataTable_lieferant)
			//			0- Name(Column_Lieferantname)
			//			1- Logo(Column_Lieferantlogo)
			//			2- ID(Column_Lieferantid)

			DataRow myRow;
			myRow = dataTable_bauteile.NewRow();
			myRow["Column_Bauteilname"] = "IC";
			myRow["Column_Bauteilbeschreibung"] = "Ein IC";
			myRow["Column_Bauteilstückzahl"] = 0; // int32
			myRow["Column_Bauteilbauform"] = 0;
			myRow["Column_Bauteilhersteller"] = 0;
			myRow["Column_Bauteildatenblatt"] = "";
			myRow["Column_BauteilLieferant"] = 0;
			myRow["Column_Bauteilpreis"] = "";
			myRow["Column_Bestellnummer"] = "";
			myRow["Column_Pinbelegung"] = "";
			//myRow["Grafik"] = new ImageConverter().ConvertTo(Properties.Resources.pen, typeof(byte[]));
			//myRow["Letzte Änderung"] = DateTime.Now;
			dataTable_bauteile.Rows.Add(myRow);
			
			DataRow myRow2;
			myRow2 = dataTable_hersteller.NewRow();
			myRow2["Column_Herstellername"] = "Hersteller1";
			myRow2["Column_Herstellerlogo"] = "HLoGo";
			dataTable_hersteller.Rows.Add(myRow2);

			DataRow myRow3;
			myRow3 = dataTable_bauform.NewRow();
			myRow3["Column_Bauform"] = "DIP16";
			dataTable_bauform.Rows.Add(myRow3);

			DataRow myRow4;
			myRow4 = dataTable_lieferant.NewRow();
			myRow4["Column_Lieferantname"] = "Lieferant1";
			myRow4["Column_Lieferantlogo"] = "LLoGo";
			dataTable_lieferant.Rows.Add(myRow4);

			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			dataGridView2.ClearSelection();
			dataGridView2.CurrentCell = null;
			dataGridView3.ClearSelection();
			dataGridView3.CurrentCell = null;
			dataGridView4.ClearSelection();
			dataGridView4.CurrentCell = null;

			//xml_dataset_Save();
			debuging_message_Show("Datensatz der Datenbank hinzugefügt ...");
		}          //+ fügt dem Dataset einen neuen Beispieldatensatz hinzu. (zickt gerade wegen der Comboboxen)

		private void dataset_entry_Add(object sender, EventArgs e)
		{
			// Datensatz hinzufügen (übergabe der Listen an die Dialog Comboboxen und Rückgabe wenn gültig ausgefüllt)
			BindingSource bs = mainsender.DataSource as BindingSource;
			DataRow myRow;
			if (mainsender.Name == "dataGridView1")
			{
				FormAddEditDialog addEditdialog = new FormAddEditDialog();
				addEditdialog.DataSetBuffer = this.dataSet1;
				addEditdialog.fillFromDataSet();
				DialogResult dRresult = addEditdialog.ShowDialog();
				if (dRresult == DialogResult.OK)
				{
				//	myRow = dataSet1.Tables[bs.DataMember].NewRow();
				//	myRow["Column_Bauteilname"] = dialog.BauteilName;
				//	myRow["Column_Bauteilbeschreibung"] = dialog.Beschreibung;
				//	myRow["Column_Bauteilstückzahl"] = Convert.ToInt32(dialog.Stückzahl);
				//	myRow["Column_Bauteilbauform"] = Convert.ToInt32(dialog.BauformDs);
				//	myRow["Column_Bauteilhersteller"] = Convert.ToInt32(dialog.HerstellerDs);
				//	myRow["Column_Bauteildatenblatt"] = dialog.Datenblatt;
				//	myRow["Column_BauteilLieferant"] = Convert.ToInt32(dialog.LieferantDs);
				//	myRow["Column_Bauteilpreis"] = dialog.Preis;
				//	myRow["Column_Bestellnummer"] = dialog.Bestellnummer;
				//	myRow["Column_Pinbelegung"] = dialog.Pinbelegung;
				//	//myRow["Grafik"] = new ImageConverter().ConvertTo(Properties.Resources.pen, typeof(byte[])); (kommt noch)
				//	//myRow["Letzte Änderung"] = DateTime.Now; (kommt noch)
				//	dataSet1.Tables[bs.DataMember].Rows.Add(myRow);
				//	xml_dataset_Save();
					statusstrip_update_Status("Datensatz der Datenbank hinzugefügt ...");
				}
				else
				{
					debuging_message_Show("abgebrochen");
				}
			}
			if (mainsender.Name == "dataGridView2")
			{
				myRow = dataSet1.Tables[bs.DataMember].NewRow();
				myRow["Column_Herstellername"] = "Hersteller1";
				myRow["Column_Herstellerlogo"] = "HLoGo";
				dataSet1.Tables[bs.DataMember].Rows.Add(myRow);
				xml_dataset_Save();
				statusstrip_update_Status("Datensatz der Datenbank hinzugefügt ...");
			}
			if (mainsender.Name == "dataGridView3")
			{
				myRow = dataSet1.Tables[bs.DataMember].NewRow();
				myRow["Column_Lieferantname"] = "Lieferant1";
				myRow["Column_Lieferantlogo"] = "LLoGo";
				dataSet1.Tables[bs.DataMember].Rows.Add(myRow);
				xml_dataset_Save();
				statusstrip_update_Status("Datensatz der Datenbank hinzugefügt ...");
			}
			if (mainsender.Name == "dataGridView4")
			{
				myRow = dataSet1.Tables[bs.DataMember].NewRow();
				myRow["Column_Bauform"] = "DIP16";
				dataSet1.Tables[bs.DataMember].Rows.Add(myRow);
				xml_dataset_Save();
				statusstrip_update_Status("Datensatz der Datenbank hinzugefügt ...");
			}
			mainsender.ClearSelection();
			mainsender.CurrentCell = null;
		}                  // fürgt im Dataset einen Datensatz hinzu. (funktioniert noch nicht so prall)

		private void dataset_entry_Edit(object sender, EventArgs e)
		{
			// Datensatz bearbeiten
			//int editrow = mainsender.CurrentRow.Index;
			// öffnet edit Fomular mit entsprecheden Eingabefeldern.

			//string editentry = dataSet1.Tables["Bauteile"].Rows[editrow].Delete();
			//dataSet1.Tables["TableMesspunkte"].Rows[editrow]["RFP"] = textBox_RFP.Text;
			//dataSet1.Tables["TableMesspunkte"].Rows[editrow]["RSSI"] = textBox_RSSI.Text;
			//dataSet1.Tables["TableMesspunkte"].Rows[editrow]["BER"] = textBox_BER.Text;
			//dataSet1.Tables["TableMesspunkte"].Rows[editrow]["Beschreibung"] = textBox_Beschreibung.Text;
			//dataSet1.Tables["TableMesspunkte"].Rows[editrow]["KoordinateX"] = xCoordinate;
			//dataSet1.Tables["TableMesspunkte"].Rows[editrow]["KoordinateY"] = yCoordinate;
			//label_koordinate.Text = "X:" + xCoordinate + " / Y:" + yCoordinate;
			//dataGridView1.ClearSelection();
			//dataGridView1.CurrentCell = null;
			//textBox_RFP.Text = "";
			//textBox_RSSI.Text = "";
			//textBox_BER.Text = "";
			//textBox_Beschreibung.Text = "";
			xml_dataset_Save();
			statusstrip_update_Status("Datensatz der Datenbank bearbeitet ...");
		}                 // bearbeitet im Dataset einen Datensatz. (überarbeiten nach dataset_entry_Add)

		private void dataset_entry_Delete(object sender, EventArgs e)
		{
			// Datensatz löschen
			try
			{
				BindingSource bs = mainsender.DataSource as BindingSource;
				dataSet1.Tables[bs.DataMember].Rows[mainsender.CurrentRow.Index].Delete();
				xml_dataset_Save();
				statusstrip_update_Status("Datensatz der Datenbank gelöscht ...");
			}
			catch
			{
				MessageBox.Show("Kein Eintrag ausgewählt.");
			}
			mainsender.ClearSelection();
			mainsender.CurrentCell = null;
		}               //+ löscht im Dataset einen Datensatz.

		private void dataset_entry_Cancle(object sender, EventArgs e)
		{
			// cancle
			mainsender.ClearSelection();
			mainsender.CurrentCell = null;
		}               //+ bricht das ContextMenu ab.

		private void dataset_file_Add()
		{
			// ein Beispielcode aus anderem Projekt der überarbeitet werden muss.

			//OpenFileDialog dlg = new OpenFileDialog();
			//dlg.Filter = "Adobe PDF (*.pdf) |*.pdf|Bidmapdateien (*.bmp) |*.bmp|JPEG (*.jpg) |*.jpg";
			//dlg.FilterIndex = 1;
			//if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName != null)
			//{
			//	if (dlg.FilterIndex == 1)
			//	{
			//		try
			//		{
			//			Process process = new Process();
			//			process.StartInfo.FileName = dlg.FileName;
			//			process.Start();
			//			process.WaitForExit();
			//			if (Clipboard.ContainsImage())
			//			{
			//				panel1.AutoScroll = false;
			//				pictureBox_hintergrund.Image = Clipboard.GetImage();
			//				panel1.AutoScroll = true;
			//			}
			//		}
			//		catch
			//		{
			//			MessageBox.Show("Datei kann nicht geöffnet werden.\nEs konnte kein Programm zu öffnen von PDF gefunden werden.");
			//		}
			//	}
			//	if (dlg.FilterIndex == 2)
			//	{
			//		panel1.AutoScroll = false;
			//		pictureBox_hintergrund.Image = new Bitmap(dlg.FileName);
			//		panel1.AutoScroll = true;
			//	}
			//	if (dlg.FilterIndex == 3)
			//	{
			//		panel1.AutoScroll = false;
			//		pictureBox_hintergrund.Image = new Bitmap(dlg.FileName);
			//		panel1.AutoScroll = true;
			//	}
			//}
		}                                             // fügt dem Dataset eine Datei im Binärformat hinzu. (für grafiken geplant / noch unerledigt)

		private void xml_dataset_Save()
		{
			dataSet1.WriteXml(filePath);
			statusstrip_update_Status("Datenbank gespeichert ...");
		}                                             // speichert das Dataset als Default xmp Datei. (FileSaveDialog fehlt noch)

		private void xml_dataset_Load()
		{
			if (File.Exists(filePath))
			{
				// Laden der Datenbank oder bei nicht vorhanden sein das neu erstellen
				try
				{
					dataSet1.ReadXml(filePath);
					statusstrip_update_Status("Datenbank geladen ...");
				}
				catch (Exception ex)
				{
					error_message_Show(ex);
					statusstrip_update_Status("Datenbank laden fehlgeschlagen ...");
				}
			}
			else
			{
				try
				{
					dataSet1.WriteXml(filePath);
					statusstrip_update_Status("Datenbank erstellt ...");
				}
				catch (Exception ex)
				{
					error_message_Show(ex);
					statusstrip_update_Status("Datenbank erstellen fehlgeschlagen ...");
				}
			}
		}                                             // Lädt das Dataset als Default xmp Datei. (fileOpenDialog fehlt noch)

		private void error_message_Show(Exception e)
		{
			MessageBox.Show(e.ToString(), "Fehler festgestellt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			// Beispiel
			//try
			//{
			//	//Code ...
			//}
			//catch (Exception ex)
			//{
			//	debuging_message_Show("DebugError: " + ex.Message);
			//}
		}                                //+ gibt ExceptionFehler zur als MessageBox aus.

		private void debuging_message_Show(string message)
		{
			if (debugging)
			{
				statusstrip_update_Status("DebugError - " + message);
			}
		}                          //+ gibt DebugingFehler als MessageBox aus.


	}
}
