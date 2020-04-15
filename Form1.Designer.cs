namespace Bauteildatenbank
{
	partial class mainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
			this.button_minimize = new System.Windows.Forms.Button();
			this.button_exit = new System.Windows.Forms.Button();
			this.dataSet1 = new System.Data.DataSet();
			this.dataTable_bauteile = new System.Data.DataTable();
			this.dataColumn_Bauteilname = new System.Data.DataColumn();
			this.dataColumn_Bauteilbeschreibung = new System.Data.DataColumn();
			this.dataColumn_Bauteilstückzahl = new System.Data.DataColumn();
			this.dataColumn_Bauteilbauform = new System.Data.DataColumn();
			this.dataColumn_Bauteilhersteller = new System.Data.DataColumn();
			this.dataColumn_Id = new System.Data.DataColumn();
			this.dataColumn_Bauteildatenblatt = new System.Data.DataColumn();
			this.dataColumn_BauteilLieferant = new System.Data.DataColumn();
			this.dataColumn_Bauteilpreis = new System.Data.DataColumn();
			this.dataColumn_Bestellnummer = new System.Data.DataColumn();
			this.dataColumn_Pinbelegung = new System.Data.DataColumn();
			this.dataTable_hersteller = new System.Data.DataTable();
			this.dataColumn_Herstellername = new System.Data.DataColumn();
			this.dataColumn_Herstellerlogo = new System.Data.DataColumn();
			this.dataColumn_Herstellerid = new System.Data.DataColumn();
			this.dataTable_bauform = new System.Data.DataTable();
			this.dataColumn_Bauform = new System.Data.DataColumn();
			this.dataColumn_Bauformid = new System.Data.DataColumn();
			this.dataTable_lieferant = new System.Data.DataTable();
			this.dataColumn_Lieferantname = new System.Data.DataColumn();
			this.dataColumn_Lieferantlogo = new System.Data.DataColumn();
			this.dataColumn_Lieferantid = new System.Data.DataColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.bauteileBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.herstellerbindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lieferantbindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bauformbindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.columnBauformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnBauformidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.columnLieferantnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnLieferantlogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnLieferantidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.columnHerstellernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnHerstellerlogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnHerstelleridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label_titel = new System.Windows.Forms.Label();
			this.button_add = new System.Windows.Forms.Button();
			this.button_search = new System.Windows.Forms.Button();
			this.columnBauteilnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnBauteilbeschreibungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnBauteilbauformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.columnPinbelegungDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnBauteilherstellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.columnBauteildatenblattDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnBauteilLieferantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.columnBestellnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnBauteilstückzahlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnBauteilpreisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable_bauteile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable_hersteller)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable_bauform)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable_lieferant)).BeginInit();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bauteileBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.herstellerbindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lieferantbindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bauformbindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// button_minimize
			// 
			this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_minimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_minimize.Location = new System.Drawing.Point(1444, 12);
			this.button_minimize.Name = "button_minimize";
			this.button_minimize.Size = new System.Drawing.Size(32, 31);
			this.button_minimize.TabIndex = 11;
			this.button_minimize.Text = "-";
			this.button_minimize.UseVisualStyleBackColor = true;
			this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
			// 
			// button_exit
			// 
			this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_exit.Location = new System.Drawing.Point(1482, 12);
			this.button_exit.Name = "button_exit";
			this.button_exit.Size = new System.Drawing.Size(32, 31);
			this.button_exit.TabIndex = 12;
			this.button_exit.Text = "X";
			this.button_exit.UseVisualStyleBackColor = true;
			this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable_bauteile,
            this.dataTable_hersteller,
            this.dataTable_bauform,
            this.dataTable_lieferant});
			// 
			// dataTable_bauteile
			// 
			this.dataTable_bauteile.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_Bauteilname,
            this.dataColumn_Bauteilbeschreibung,
            this.dataColumn_Bauteilstückzahl,
            this.dataColumn_Bauteilbauform,
            this.dataColumn_Bauteilhersteller,
            this.dataColumn_Id,
            this.dataColumn_Bauteildatenblatt,
            this.dataColumn_BauteilLieferant,
            this.dataColumn_Bauteilpreis,
            this.dataColumn_Bestellnummer,
            this.dataColumn_Pinbelegung});
			this.dataTable_bauteile.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Column_Id"}, true)});
			this.dataTable_bauteile.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn_Id};
			this.dataTable_bauteile.TableName = "Bauteile";
			// 
			// dataColumn_Bauteilname
			// 
			this.dataColumn_Bauteilname.Caption = "Name";
			this.dataColumn_Bauteilname.ColumnName = "Column_Bauteilname";
			// 
			// dataColumn_Bauteilbeschreibung
			// 
			this.dataColumn_Bauteilbeschreibung.Caption = "Beschreibung";
			this.dataColumn_Bauteilbeschreibung.ColumnName = "Column_Bauteilbeschreibung";
			// 
			// dataColumn_Bauteilstückzahl
			// 
			this.dataColumn_Bauteilstückzahl.Caption = "Stückzahl";
			this.dataColumn_Bauteilstückzahl.ColumnName = "Column_Bauteilstückzahl";
			this.dataColumn_Bauteilstückzahl.DataType = typeof(int);
			// 
			// dataColumn_Bauteilbauform
			// 
			this.dataColumn_Bauteilbauform.Caption = "Bauform";
			this.dataColumn_Bauteilbauform.ColumnName = "Column_Bauteilbauform";
			this.dataColumn_Bauteilbauform.DataType = typeof(int);
			// 
			// dataColumn_Bauteilhersteller
			// 
			this.dataColumn_Bauteilhersteller.Caption = "Hersteller";
			this.dataColumn_Bauteilhersteller.ColumnName = "Column_Bauteilhersteller";
			this.dataColumn_Bauteilhersteller.DataType = typeof(int);
			// 
			// dataColumn_Id
			// 
			this.dataColumn_Id.AllowDBNull = false;
			this.dataColumn_Id.AutoIncrement = true;
			this.dataColumn_Id.Caption = "ID";
			this.dataColumn_Id.ColumnName = "Column_Id";
			this.dataColumn_Id.DataType = typeof(int);
			// 
			// dataColumn_Bauteildatenblatt
			// 
			this.dataColumn_Bauteildatenblatt.Caption = "Datenblatt";
			this.dataColumn_Bauteildatenblatt.ColumnName = "Column_Bauteildatenblatt";
			// 
			// dataColumn_BauteilLieferant
			// 
			this.dataColumn_BauteilLieferant.Caption = "Lieferant";
			this.dataColumn_BauteilLieferant.ColumnName = "Column_BauteilLieferant";
			this.dataColumn_BauteilLieferant.DataType = typeof(int);
			// 
			// dataColumn_Bauteilpreis
			// 
			this.dataColumn_Bauteilpreis.Caption = "Preis";
			this.dataColumn_Bauteilpreis.ColumnName = "Column_Bauteilpreis";
			// 
			// dataColumn_Bestellnummer
			// 
			this.dataColumn_Bestellnummer.Caption = "Bestellnummer";
			this.dataColumn_Bestellnummer.ColumnName = "Column_Bestellnummer";
			// 
			// dataColumn_Pinbelegung
			// 
			this.dataColumn_Pinbelegung.Caption = "Pinbelegung";
			this.dataColumn_Pinbelegung.ColumnName = "Column_Pinbelegung";
			// 
			// dataTable_hersteller
			// 
			this.dataTable_hersteller.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_Herstellername,
            this.dataColumn_Herstellerlogo,
            this.dataColumn_Herstellerid});
			this.dataTable_hersteller.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Column_Herstellerid"}, true)});
			this.dataTable_hersteller.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn_Herstellerid};
			this.dataTable_hersteller.TableName = "Hersteller";
			// 
			// dataColumn_Herstellername
			// 
			this.dataColumn_Herstellername.Caption = "Name";
			this.dataColumn_Herstellername.ColumnName = "Column_Herstellername";
			// 
			// dataColumn_Herstellerlogo
			// 
			this.dataColumn_Herstellerlogo.Caption = "Logo";
			this.dataColumn_Herstellerlogo.ColumnName = "Column_Herstellerlogo";
			// 
			// dataColumn_Herstellerid
			// 
			this.dataColumn_Herstellerid.AllowDBNull = false;
			this.dataColumn_Herstellerid.AutoIncrement = true;
			this.dataColumn_Herstellerid.Caption = "ID";
			this.dataColumn_Herstellerid.ColumnName = "Column_Herstellerid";
			this.dataColumn_Herstellerid.DataType = typeof(int);
			// 
			// dataTable_bauform
			// 
			this.dataTable_bauform.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_Bauform,
            this.dataColumn_Bauformid});
			this.dataTable_bauform.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Column_Bauformid"}, true)});
			this.dataTable_bauform.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn_Bauformid};
			this.dataTable_bauform.TableName = "Bauform";
			// 
			// dataColumn_Bauform
			// 
			this.dataColumn_Bauform.Caption = "Bauform";
			this.dataColumn_Bauform.ColumnName = "Column_Bauform";
			// 
			// dataColumn_Bauformid
			// 
			this.dataColumn_Bauformid.AllowDBNull = false;
			this.dataColumn_Bauformid.AutoIncrement = true;
			this.dataColumn_Bauformid.Caption = "ID";
			this.dataColumn_Bauformid.ColumnName = "Column_Bauformid";
			this.dataColumn_Bauformid.DataType = typeof(int);
			// 
			// dataTable_lieferant
			// 
			this.dataTable_lieferant.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_Lieferantname,
            this.dataColumn_Lieferantlogo,
            this.dataColumn_Lieferantid});
			this.dataTable_lieferant.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Column_Lieferantid"}, true)});
			this.dataTable_lieferant.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn_Lieferantid};
			this.dataTable_lieferant.TableName = "Lieferant";
			// 
			// dataColumn_Lieferantname
			// 
			this.dataColumn_Lieferantname.Caption = "Name";
			this.dataColumn_Lieferantname.ColumnName = "Column_Lieferantname";
			// 
			// dataColumn_Lieferantlogo
			// 
			this.dataColumn_Lieferantlogo.Caption = "Logo";
			this.dataColumn_Lieferantlogo.ColumnName = "Column_Lieferantlogo";
			// 
			// dataColumn_Lieferantid
			// 
			this.dataColumn_Lieferantid.AllowDBNull = false;
			this.dataColumn_Lieferantid.AutoIncrement = true;
			this.dataColumn_Lieferantid.Caption = "ID";
			this.dataColumn_Lieferantid.ColumnName = "Column_Lieferantid";
			this.dataColumn_Lieferantid.DataType = typeof(int);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 782);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new System.Drawing.Size(1526, 26);
			this.statusStrip1.TabIndex = 17;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 20);
			this.toolStripStatusLabel1.Text = "Status: ";
			// 
			// bauteileBindingSource
			// 
			this.bauteileBindingSource.DataMember = "Bauteile";
			this.bauteileBindingSource.DataSource = this.dataSet1;
			// 
			// herstellerbindingSource
			// 
			this.herstellerbindingSource.DataMember = "Hersteller";
			this.herstellerbindingSource.DataSource = this.dataSet1;
			// 
			// lieferantbindingSource
			// 
			this.lieferantbindingSource.DataMember = "Lieferant";
			this.lieferantbindingSource.DataSource = this.dataSet1;
			// 
			// bauformbindingSource
			// 
			this.bauformbindingSource.DataMember = "Bauform";
			this.bauformbindingSource.DataSource = this.dataSet1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnBauteilnameDataGridViewTextBoxColumn,
            this.columnBauteilbeschreibungDataGridViewTextBoxColumn,
            this.columnBauteilbauformDataGridViewTextBoxColumn,
            this.columnPinbelegungDataGridViewTextBoxColumn1,
            this.columnBauteilherstellerDataGridViewTextBoxColumn,
            this.columnBauteildatenblattDataGridViewTextBoxColumn,
            this.columnBauteilLieferantDataGridViewTextBoxColumn,
            this.columnBestellnummerDataGridViewTextBoxColumn,
            this.columnBauteilstückzahlDataGridViewTextBoxColumn,
            this.columnBauteilpreisDataGridViewTextBoxColumn,
            this.columnIdDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.bauteileBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 63);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(1500, 409);
			this.dataGridView1.TabIndex = 18;
			this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.datagridview_MouseClick);
			// 
			// dataGridView4
			// 
			this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView4.AutoGenerateColumns = false;
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnBauformDataGridViewTextBoxColumn,
            this.columnBauformidDataGridViewTextBoxColumn});
			this.dataGridView4.DataSource = this.bauformbindingSource;
			this.dataGridView4.Location = new System.Drawing.Point(1092, 495);
			this.dataGridView4.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.RowHeadersWidth = 51;
			this.dataGridView4.Size = new System.Drawing.Size(421, 272);
			this.dataGridView4.TabIndex = 21;
			this.dataGridView4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.datagridview_MouseClick);
			// 
			// columnBauformDataGridViewTextBoxColumn
			// 
			this.columnBauformDataGridViewTextBoxColumn.DataPropertyName = "Column_Bauform";
			this.columnBauformDataGridViewTextBoxColumn.HeaderText = "Bauform";
			this.columnBauformDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnBauformDataGridViewTextBoxColumn.Name = "columnBauformDataGridViewTextBoxColumn";
			this.columnBauformDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnBauformidDataGridViewTextBoxColumn
			// 
			this.columnBauformidDataGridViewTextBoxColumn.DataPropertyName = "Column_Bauformid";
			this.columnBauformidDataGridViewTextBoxColumn.HeaderText = "Bauformid";
			this.columnBauformidDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnBauformidDataGridViewTextBoxColumn.Name = "columnBauformidDataGridViewTextBoxColumn";
			this.columnBauformidDataGridViewTextBoxColumn.Width = 125;
			// 
			// dataGridView3
			// 
			this.dataGridView3.AutoGenerateColumns = false;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnLieferantnameDataGridViewTextBoxColumn,
            this.columnLieferantlogoDataGridViewTextBoxColumn,
            this.columnLieferantidDataGridViewTextBoxColumn});
			this.dataGridView3.DataSource = this.lieferantbindingSource;
			this.dataGridView3.Location = new System.Drawing.Point(582, 495);
			this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.RowHeadersWidth = 51;
			this.dataGridView3.Size = new System.Drawing.Size(502, 272);
			this.dataGridView3.TabIndex = 20;
			this.dataGridView3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.datagridview_MouseClick);
			// 
			// columnLieferantnameDataGridViewTextBoxColumn
			// 
			this.columnLieferantnameDataGridViewTextBoxColumn.DataPropertyName = "Column_Lieferantname";
			this.columnLieferantnameDataGridViewTextBoxColumn.HeaderText = "Lieferantname";
			this.columnLieferantnameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnLieferantnameDataGridViewTextBoxColumn.Name = "columnLieferantnameDataGridViewTextBoxColumn";
			this.columnLieferantnameDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnLieferantlogoDataGridViewTextBoxColumn
			// 
			this.columnLieferantlogoDataGridViewTextBoxColumn.DataPropertyName = "Column_Lieferantlogo";
			this.columnLieferantlogoDataGridViewTextBoxColumn.HeaderText = "Lieferantlogo";
			this.columnLieferantlogoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnLieferantlogoDataGridViewTextBoxColumn.Name = "columnLieferantlogoDataGridViewTextBoxColumn";
			this.columnLieferantlogoDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnLieferantidDataGridViewTextBoxColumn
			// 
			this.columnLieferantidDataGridViewTextBoxColumn.DataPropertyName = "Column_Lieferantid";
			this.columnLieferantidDataGridViewTextBoxColumn.HeaderText = "Lieferantid";
			this.columnLieferantidDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnLieferantidDataGridViewTextBoxColumn.Name = "columnLieferantidDataGridViewTextBoxColumn";
			this.columnLieferantidDataGridViewTextBoxColumn.Width = 125;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnHerstellernameDataGridViewTextBoxColumn,
            this.columnHerstellerlogoDataGridViewTextBoxColumn,
            this.columnHerstelleridDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.herstellerbindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(13, 495);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.Size = new System.Drawing.Size(561, 272);
			this.dataGridView2.TabIndex = 19;
			this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.datagridview_MouseClick);
			// 
			// columnHerstellernameDataGridViewTextBoxColumn
			// 
			this.columnHerstellernameDataGridViewTextBoxColumn.DataPropertyName = "Column_Herstellername";
			this.columnHerstellernameDataGridViewTextBoxColumn.HeaderText = "Herstellername";
			this.columnHerstellernameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnHerstellernameDataGridViewTextBoxColumn.Name = "columnHerstellernameDataGridViewTextBoxColumn";
			this.columnHerstellernameDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnHerstellerlogoDataGridViewTextBoxColumn
			// 
			this.columnHerstellerlogoDataGridViewTextBoxColumn.DataPropertyName = "Column_Herstellerlogo";
			this.columnHerstellerlogoDataGridViewTextBoxColumn.HeaderText = "Herstellerlogo";
			this.columnHerstellerlogoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnHerstellerlogoDataGridViewTextBoxColumn.Name = "columnHerstellerlogoDataGridViewTextBoxColumn";
			this.columnHerstellerlogoDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnHerstelleridDataGridViewTextBoxColumn
			// 
			this.columnHerstelleridDataGridViewTextBoxColumn.DataPropertyName = "Column_Herstellerid";
			this.columnHerstelleridDataGridViewTextBoxColumn.HeaderText = "Herstellerid";
			this.columnHerstelleridDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnHerstelleridDataGridViewTextBoxColumn.Name = "columnHerstelleridDataGridViewTextBoxColumn";
			this.columnHerstelleridDataGridViewTextBoxColumn.Width = 125;
			// 
			// label_titel
			// 
			this.label_titel.AutoSize = true;
			this.label_titel.Location = new System.Drawing.Point(13, 12);
			this.label_titel.Name = "label_titel";
			this.label_titel.Size = new System.Drawing.Size(46, 17);
			this.label_titel.TabIndex = 22;
			this.label_titel.Text = "label1";
			// 
			// button_add
			// 
			this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_add.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_add.Location = new System.Drawing.Point(1137, 13);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(123, 31);
			this.button_add.TabIndex = 23;
			this.button_add.Text = "Add";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.dataset_entry_example_Add);
			// 
			// button_search
			// 
			this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_search.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_search.Location = new System.Drawing.Point(1266, 13);
			this.button_search.Name = "button_search";
			this.button_search.Size = new System.Drawing.Size(123, 31);
			this.button_search.TabIndex = 24;
			this.button_search.Text = "Search";
			this.button_search.UseVisualStyleBackColor = true;
			// 
			// columnBauteilnameDataGridViewTextBoxColumn
			// 
			this.columnBauteilnameDataGridViewTextBoxColumn.DataPropertyName = "Column_Bauteilname";
			this.columnBauteilnameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.columnBauteilnameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnBauteilnameDataGridViewTextBoxColumn.Name = "columnBauteilnameDataGridViewTextBoxColumn";
			this.columnBauteilnameDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnBauteilbeschreibungDataGridViewTextBoxColumn
			// 
			this.columnBauteilbeschreibungDataGridViewTextBoxColumn.DataPropertyName = "Column_Bauteilbeschreibung";
			this.columnBauteilbeschreibungDataGridViewTextBoxColumn.HeaderText = "Beschreibung";
			this.columnBauteilbeschreibungDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnBauteilbeschreibungDataGridViewTextBoxColumn.Name = "columnBauteilbeschreibungDataGridViewTextBoxColumn";
			this.columnBauteilbeschreibungDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnBauteilbauformDataGridViewTextBoxColumn
			// 
			this.columnBauteilbauformDataGridViewTextBoxColumn.DataPropertyName = "Column_Bauteilbauform";
			this.columnBauteilbauformDataGridViewTextBoxColumn.DataSource = this.bauformbindingSource;
			this.columnBauteilbauformDataGridViewTextBoxColumn.DisplayMember = "Column_Bauform";
			this.columnBauteilbauformDataGridViewTextBoxColumn.HeaderText = "Bauform";
			this.columnBauteilbauformDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnBauteilbauformDataGridViewTextBoxColumn.Name = "columnBauteilbauformDataGridViewTextBoxColumn";
			this.columnBauteilbauformDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.columnBauteilbauformDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.columnBauteilbauformDataGridViewTextBoxColumn.ValueMember = "Column_Bauformid";
			this.columnBauteilbauformDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnPinbelegungDataGridViewTextBoxColumn1
			// 
			this.columnPinbelegungDataGridViewTextBoxColumn1.DataPropertyName = "Column_Pinbelegung";
			this.columnPinbelegungDataGridViewTextBoxColumn1.HeaderText = "Pinbelegung";
			this.columnPinbelegungDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.columnPinbelegungDataGridViewTextBoxColumn1.Name = "columnPinbelegungDataGridViewTextBoxColumn1";
			this.columnPinbelegungDataGridViewTextBoxColumn1.Width = 125;
			// 
			// columnBauteilherstellerDataGridViewTextBoxColumn
			// 
			this.columnBauteilherstellerDataGridViewTextBoxColumn.DataPropertyName = "Column_Bauteilhersteller";
			this.columnBauteilherstellerDataGridViewTextBoxColumn.DataSource = this.herstellerbindingSource;
			this.columnBauteilherstellerDataGridViewTextBoxColumn.DisplayMember = "Column_Herstellername";
			this.columnBauteilherstellerDataGridViewTextBoxColumn.HeaderText = "Hersteller";
			this.columnBauteilherstellerDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnBauteilherstellerDataGridViewTextBoxColumn.Name = "columnBauteilherstellerDataGridViewTextBoxColumn";
			this.columnBauteilherstellerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.columnBauteilherstellerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.columnBauteilherstellerDataGridViewTextBoxColumn.ValueMember = "Column_Herstellerid";
			this.columnBauteilherstellerDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnBauteildatenblattDataGridViewTextBoxColumn
			// 
			this.columnBauteildatenblattDataGridViewTextBoxColumn.DataPropertyName = "Column_Bauteildatenblatt";
			this.columnBauteildatenblattDataGridViewTextBoxColumn.HeaderText = "Datenblatt";
			this.columnBauteildatenblattDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnBauteildatenblattDataGridViewTextBoxColumn.Name = "columnBauteildatenblattDataGridViewTextBoxColumn";
			this.columnBauteildatenblattDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnBauteilLieferantDataGridViewTextBoxColumn
			// 
			this.columnBauteilLieferantDataGridViewTextBoxColumn.DataPropertyName = "Column_BauteilLieferant";
			this.columnBauteilLieferantDataGridViewTextBoxColumn.DataSource = this.lieferantbindingSource;
			this.columnBauteilLieferantDataGridViewTextBoxColumn.DisplayMember = "Column_Lieferantname";
			this.columnBauteilLieferantDataGridViewTextBoxColumn.HeaderText = "Lieferant";
			this.columnBauteilLieferantDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnBauteilLieferantDataGridViewTextBoxColumn.Name = "columnBauteilLieferantDataGridViewTextBoxColumn";
			this.columnBauteilLieferantDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.columnBauteilLieferantDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.columnBauteilLieferantDataGridViewTextBoxColumn.ValueMember = "Column_Lieferantid";
			this.columnBauteilLieferantDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnBestellnummerDataGridViewTextBoxColumn
			// 
			this.columnBestellnummerDataGridViewTextBoxColumn.DataPropertyName = "Column_Bestellnummer";
			this.columnBestellnummerDataGridViewTextBoxColumn.HeaderText = "Bestellnummer";
			this.columnBestellnummerDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnBestellnummerDataGridViewTextBoxColumn.Name = "columnBestellnummerDataGridViewTextBoxColumn";
			this.columnBestellnummerDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnBauteilstückzahlDataGridViewTextBoxColumn
			// 
			this.columnBauteilstückzahlDataGridViewTextBoxColumn.DataPropertyName = "Column_Bauteilstückzahl";
			this.columnBauteilstückzahlDataGridViewTextBoxColumn.HeaderText = "Stückzahl";
			this.columnBauteilstückzahlDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnBauteilstückzahlDataGridViewTextBoxColumn.Name = "columnBauteilstückzahlDataGridViewTextBoxColumn";
			this.columnBauteilstückzahlDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnBauteilpreisDataGridViewTextBoxColumn
			// 
			this.columnBauteilpreisDataGridViewTextBoxColumn.DataPropertyName = "Column_Bauteilpreis";
			this.columnBauteilpreisDataGridViewTextBoxColumn.HeaderText = "Preis";
			this.columnBauteilpreisDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnBauteilpreisDataGridViewTextBoxColumn.Name = "columnBauteilpreisDataGridViewTextBoxColumn";
			this.columnBauteilpreisDataGridViewTextBoxColumn.Width = 125;
			// 
			// columnIdDataGridViewTextBoxColumn
			// 
			this.columnIdDataGridViewTextBoxColumn.DataPropertyName = "Column_Id";
			this.columnIdDataGridViewTextBoxColumn.HeaderText = "Id";
			this.columnIdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.columnIdDataGridViewTextBoxColumn.Name = "columnIdDataGridViewTextBoxColumn";
			this.columnIdDataGridViewTextBoxColumn.Width = 125;
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1526, 808);
			this.Controls.Add(this.button_search);
			this.Controls.Add(this.button_add);
			this.Controls.Add(this.label_titel);
			this.Controls.Add(this.dataGridView4);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.button_minimize);
			this.Controls.Add(this.button_exit);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "mainForm";
			this.Text = "Form1";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.application_mouse_drag_Form);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.application_mouse_move_form);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.application_mouse_drop_Form);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable_bauteile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable_hersteller)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable_bauform)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable_lieferant)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bauteileBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.herstellerbindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lieferantbindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bauformbindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_minimize;
		private System.Windows.Forms.Button button_exit;
		private System.Data.DataTable dataTable_bauteile;
		private System.Data.DataColumn dataColumn_Bauteilname;
		private System.Data.DataColumn dataColumn_Bauteilbeschreibung;
		private System.Data.DataColumn dataColumn_Bauteilstückzahl;
		private System.Data.DataColumn dataColumn_Bauteilbauform;
		private System.Data.DataColumn dataColumn_Bauteilhersteller;
		private System.Data.DataColumn dataColumn_Id;
		private System.Data.DataColumn dataColumn_Bauteildatenblatt;
		private System.Data.DataColumn dataColumn_BauteilLieferant;
		private System.Data.DataColumn dataColumn_Bauteilpreis;
		private System.Data.DataColumn dataColumn_Bestellnummer;
		private System.Data.DataTable dataTable_hersteller;
		private System.Data.DataColumn dataColumn_Herstellername;
		private System.Data.DataColumn dataColumn_Herstellerlogo;
		private System.Data.DataColumn dataColumn_Herstellerid;
		private System.Data.DataTable dataTable_bauform;
		private System.Data.DataColumn dataColumn_Bauform;
		private System.Data.DataColumn dataColumn_Bauformid;
		private System.Data.DataTable dataTable_lieferant;
		private System.Data.DataColumn dataColumn_Lieferantname;
		private System.Data.DataColumn dataColumn_Lieferantlogo;
		private System.Data.DataColumn dataColumn_Lieferantid;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView4;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnBauformDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnBauformidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnLieferantnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnLieferantlogoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnLieferantidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnHerstellernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnHerstellerlogoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnHerstelleridDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label_titel;
		private System.Data.DataColumn dataColumn_Pinbelegung;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Button button_search;
		private System.Windows.Forms.BindingSource bauteileBindingSource;
		private System.Data.DataSet dataSet1;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnBauteilnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnBauteilbeschreibungDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn columnBauteilbauformDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnPinbelegungDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewComboBoxColumn columnBauteilherstellerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnBauteildatenblattDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn columnBauteilLieferantDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnBestellnummerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnBauteilstückzahlDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnBauteilpreisDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource herstellerbindingSource;
		private System.Windows.Forms.BindingSource lieferantbindingSource;
		private System.Windows.Forms.BindingSource bauformbindingSource;
	}
}

