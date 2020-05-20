namespace PrzychodniaLekarska3
{
    partial class KartaBadanControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataRejestracjiBadania = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DataBadania = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dodajKartaBadan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BadaniaLabel = new System.Windows.Forms.Label();
            this.datagridBadania = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.iDKARTABADANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPACJENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDBADANIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAREJESTRACJIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tERMINBADANIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kARTABADANTAPIWYSWIETLKARTEBADANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaSet1 = new PrzychodniaLekarska3.PrzychodniaSet();
            this.usunKartaBadan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.edytujKartaBadan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.idpacjentaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idPacjentaCB = new System.Windows.Forms.ComboBox();
            this.pACJENCIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idBadaniaCB = new System.Windows.Forms.ComboBox();
            this.lekarzeTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.LEKARZETableAdapter();
            this.pACJENCITableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.PACJENCITableAdapter();
            this.lEKARZEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kARTABADAN_TAPI_WYSWIETL_KARTEBADANTableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.KARTABADAN_TAPI_WYSWIETL_KARTEBADANTableAdapter();
            this.bADANIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bADANIATableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.BADANIATableAdapter();
            this.queriesTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBadania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kARTABADANTAPIWYSWIETLKARTEBADANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENCIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEKARZEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bADANIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataRejestracjiBadania
            // 
            this.DataRejestracjiBadania.BackColor = System.Drawing.Color.DodgerBlue;
            this.DataRejestracjiBadania.BorderRadius = 0;
            this.DataRejestracjiBadania.ForeColor = System.Drawing.Color.White;
            this.DataRejestracjiBadania.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DataRejestracjiBadania.FormatCustom = null;
            this.DataRejestracjiBadania.Location = new System.Drawing.Point(203, 212);
            this.DataRejestracjiBadania.Name = "DataRejestracjiBadania";
            this.DataRejestracjiBadania.Size = new System.Drawing.Size(153, 36);
            this.DataRejestracjiBadania.TabIndex = 1;
            this.DataRejestracjiBadania.Value = new System.DateTime(2019, 6, 2, 17, 42, 16, 111);
            // 
            // DataBadania
            // 
            this.DataBadania.BackColor = System.Drawing.Color.DodgerBlue;
            this.DataBadania.BorderRadius = 0;
            this.DataBadania.ForeColor = System.Drawing.Color.White;
            this.DataBadania.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DataBadania.FormatCustom = null;
            this.DataBadania.Location = new System.Drawing.Point(203, 270);
            this.DataBadania.Name = "DataBadania";
            this.DataBadania.Size = new System.Drawing.Size(153, 36);
            this.DataBadania.TabIndex = 2;
            this.DataBadania.Value = new System.DateTime(2019, 6, 2, 17, 42, 17, 700);
            // 
            // dodajKartaBadan
            // 
            this.dodajKartaBadan.Active = false;
            this.dodajKartaBadan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajKartaBadan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajKartaBadan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dodajKartaBadan.BorderRadius = 0;
            this.dodajKartaBadan.ButtonText = "Dodaj";
            this.dodajKartaBadan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajKartaBadan.DisabledColor = System.Drawing.Color.Gray;
            this.dodajKartaBadan.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.dodajKartaBadan.Iconcolor = System.Drawing.Color.Transparent;
            this.dodajKartaBadan.Iconimage = null;
            this.dodajKartaBadan.Iconimage_right = null;
            this.dodajKartaBadan.Iconimage_right_Selected = null;
            this.dodajKartaBadan.Iconimage_Selected = null;
            this.dodajKartaBadan.IconMarginLeft = 0;
            this.dodajKartaBadan.IconMarginRight = 0;
            this.dodajKartaBadan.IconRightVisible = true;
            this.dodajKartaBadan.IconRightZoom = 0D;
            this.dodajKartaBadan.IconVisible = true;
            this.dodajKartaBadan.IconZoom = 90D;
            this.dodajKartaBadan.IsTab = false;
            this.dodajKartaBadan.Location = new System.Drawing.Point(57, 389);
            this.dodajKartaBadan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dodajKartaBadan.Name = "dodajKartaBadan";
            this.dodajKartaBadan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajKartaBadan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dodajKartaBadan.OnHoverTextColor = System.Drawing.Color.White;
            this.dodajKartaBadan.selected = false;
            this.dodajKartaBadan.Size = new System.Drawing.Size(118, 50);
            this.dodajKartaBadan.TabIndex = 32;
            this.dodajKartaBadan.Text = "Dodaj";
            this.dodajKartaBadan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dodajKartaBadan.Textcolor = System.Drawing.Color.White;
            this.dodajKartaBadan.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajKartaBadan.Click += new System.EventHandler(this.dodajKartaBadan_Click);
            // 
            // BadaniaLabel
            // 
            this.BadaniaLabel.AutoSize = true;
            this.BadaniaLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BadaniaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BadaniaLabel.Location = new System.Drawing.Point(51, 62);
            this.BadaniaLabel.Name = "BadaniaLabel";
            this.BadaniaLabel.Size = new System.Drawing.Size(194, 36);
            this.BadaniaLabel.TabIndex = 33;
            this.BadaniaLabel.Text = "Karta Badań";
            // 
            // datagridBadania
            // 
            this.datagridBadania.AllowCustomTheming = true;
            this.datagridBadania.AllowUserToAddRows = false;
            this.datagridBadania.AllowUserToDeleteRows = false;
            this.datagridBadania.AllowUserToResizeColumns = false;
            this.datagridBadania.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.datagridBadania.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.datagridBadania.AutoGenerateColumns = false;
            this.datagridBadania.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridBadania.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagridBadania.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridBadania.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridBadania.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridBadania.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.datagridBadania.ColumnHeadersHeight = 40;
            this.datagridBadania.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKARTABADANDataGridViewTextBoxColumn,
            this.iDPACJENTADataGridViewTextBoxColumn,
            this.iDBADANIADataGridViewTextBoxColumn,
            this.dATAREJESTRACJIDataGridViewTextBoxColumn,
            this.tERMINBADANIADataGridViewTextBoxColumn});
            this.datagridBadania.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridBadania.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.datagridBadania.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridBadania.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridBadania.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridBadania.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.datagridBadania.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridBadania.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.datagridBadania.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.datagridBadania.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridBadania.CurrentTheme.Name = null;
            this.datagridBadania.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridBadania.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.datagridBadania.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridBadania.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridBadania.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridBadania.DataSource = this.kARTABADANTAPIWYSWIETLKARTEBADANBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridBadania.DefaultCellStyle = dataGridViewCellStyle12;
            this.datagridBadania.EnableHeadersVisualStyles = false;
            this.datagridBadania.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridBadania.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.datagridBadania.HeaderBgColor = System.Drawing.Color.Empty;
            this.datagridBadania.HeaderForeColor = System.Drawing.Color.White;
            this.datagridBadania.Location = new System.Drawing.Point(379, 0);
            this.datagridBadania.Name = "datagridBadania";
            this.datagridBadania.ReadOnly = true;
            this.datagridBadania.RowHeadersVisible = false;
            this.datagridBadania.RowTemplate.Height = 40;
            this.datagridBadania.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridBadania.Size = new System.Drawing.Size(465, 463);
            this.datagridBadania.TabIndex = 34;
            this.datagridBadania.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // iDKARTABADANDataGridViewTextBoxColumn
            // 
            this.iDKARTABADANDataGridViewTextBoxColumn.DataPropertyName = "ID_KARTABADAN";
            this.iDKARTABADANDataGridViewTextBoxColumn.HeaderText = "ID_KARTABADAN";
            this.iDKARTABADANDataGridViewTextBoxColumn.Name = "iDKARTABADANDataGridViewTextBoxColumn";
            this.iDKARTABADANDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDKARTABADANDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDPACJENTADataGridViewTextBoxColumn
            // 
            this.iDPACJENTADataGridViewTextBoxColumn.DataPropertyName = "ID_PACJENTA";
            this.iDPACJENTADataGridViewTextBoxColumn.HeaderText = "ID_PACJENTA";
            this.iDPACJENTADataGridViewTextBoxColumn.Name = "iDPACJENTADataGridViewTextBoxColumn";
            this.iDPACJENTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDBADANIADataGridViewTextBoxColumn
            // 
            this.iDBADANIADataGridViewTextBoxColumn.DataPropertyName = "ID_BADANIA";
            this.iDBADANIADataGridViewTextBoxColumn.HeaderText = "ID_BADANIA";
            this.iDBADANIADataGridViewTextBoxColumn.Name = "iDBADANIADataGridViewTextBoxColumn";
            this.iDBADANIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAREJESTRACJIDataGridViewTextBoxColumn
            // 
            this.dATAREJESTRACJIDataGridViewTextBoxColumn.DataPropertyName = "DATA_REJESTRACJI";
            this.dATAREJESTRACJIDataGridViewTextBoxColumn.HeaderText = "DATA_REJESTRACJI";
            this.dATAREJESTRACJIDataGridViewTextBoxColumn.Name = "dATAREJESTRACJIDataGridViewTextBoxColumn";
            this.dATAREJESTRACJIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tERMINBADANIADataGridViewTextBoxColumn
            // 
            this.tERMINBADANIADataGridViewTextBoxColumn.DataPropertyName = "TERMIN_BADANIA";
            this.tERMINBADANIADataGridViewTextBoxColumn.HeaderText = "TERMIN_BADANIA";
            this.tERMINBADANIADataGridViewTextBoxColumn.Name = "tERMINBADANIADataGridViewTextBoxColumn";
            this.tERMINBADANIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kARTABADANTAPIWYSWIETLKARTEBADANBindingSource
            // 
            this.kARTABADANTAPIWYSWIETLKARTEBADANBindingSource.DataMember = "KARTABADAN_TAPI_WYSWIETL_KARTEBADAN";
            this.kARTABADANTAPIWYSWIETLKARTEBADANBindingSource.DataSource = this.przychodniaSet1;
            // 
            // przychodniaSet1
            // 
            this.przychodniaSet1.DataSetName = "PrzychodniaSet";
            this.przychodniaSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usunKartaBadan
            // 
            this.usunKartaBadan.Active = false;
            this.usunKartaBadan.Activecolor = System.Drawing.Color.DarkRed;
            this.usunKartaBadan.BackColor = System.Drawing.Color.DarkRed;
            this.usunKartaBadan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usunKartaBadan.BorderRadius = 0;
            this.usunKartaBadan.ButtonText = "Usuń";
            this.usunKartaBadan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usunKartaBadan.DisabledColor = System.Drawing.Color.Gray;
            this.usunKartaBadan.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.usunKartaBadan.Iconcolor = System.Drawing.Color.Transparent;
            this.usunKartaBadan.Iconimage = null;
            this.usunKartaBadan.Iconimage_right = null;
            this.usunKartaBadan.Iconimage_right_Selected = null;
            this.usunKartaBadan.Iconimage_Selected = null;
            this.usunKartaBadan.IconMarginLeft = 0;
            this.usunKartaBadan.IconMarginRight = 0;
            this.usunKartaBadan.IconRightVisible = true;
            this.usunKartaBadan.IconRightZoom = 0D;
            this.usunKartaBadan.IconVisible = true;
            this.usunKartaBadan.IconZoom = 90D;
            this.usunKartaBadan.IsTab = false;
            this.usunKartaBadan.Location = new System.Drawing.Point(645, 496);
            this.usunKartaBadan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.usunKartaBadan.Name = "usunKartaBadan";
            this.usunKartaBadan.Normalcolor = System.Drawing.Color.DarkRed;
            this.usunKartaBadan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usunKartaBadan.OnHoverTextColor = System.Drawing.Color.White;
            this.usunKartaBadan.selected = false;
            this.usunKartaBadan.Size = new System.Drawing.Size(118, 50);
            this.usunKartaBadan.TabIndex = 35;
            this.usunKartaBadan.Text = "Usuń";
            this.usunKartaBadan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usunKartaBadan.Textcolor = System.Drawing.Color.White;
            this.usunKartaBadan.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunKartaBadan.Click += new System.EventHandler(this.usunKartaBadan_Click);
            // 
            // edytujKartaBadan
            // 
            this.edytujKartaBadan.Active = false;
            this.edytujKartaBadan.Activecolor = System.Drawing.Color.Orange;
            this.edytujKartaBadan.BackColor = System.Drawing.Color.Orange;
            this.edytujKartaBadan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edytujKartaBadan.BorderRadius = 0;
            this.edytujKartaBadan.ButtonText = "Edytuj";
            this.edytujKartaBadan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edytujKartaBadan.DisabledColor = System.Drawing.Color.Gray;
            this.edytujKartaBadan.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.edytujKartaBadan.Iconcolor = System.Drawing.Color.Transparent;
            this.edytujKartaBadan.Iconimage = null;
            this.edytujKartaBadan.Iconimage_right = null;
            this.edytujKartaBadan.Iconimage_right_Selected = null;
            this.edytujKartaBadan.Iconimage_Selected = null;
            this.edytujKartaBadan.IconMarginLeft = 0;
            this.edytujKartaBadan.IconMarginRight = 0;
            this.edytujKartaBadan.IconRightVisible = true;
            this.edytujKartaBadan.IconRightZoom = 0D;
            this.edytujKartaBadan.IconVisible = true;
            this.edytujKartaBadan.IconZoom = 90D;
            this.edytujKartaBadan.IsTab = false;
            this.edytujKartaBadan.Location = new System.Drawing.Point(500, 496);
            this.edytujKartaBadan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.edytujKartaBadan.Name = "edytujKartaBadan";
            this.edytujKartaBadan.Normalcolor = System.Drawing.Color.Orange;
            this.edytujKartaBadan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.edytujKartaBadan.OnHoverTextColor = System.Drawing.Color.White;
            this.edytujKartaBadan.selected = false;
            this.edytujKartaBadan.Size = new System.Drawing.Size(118, 50);
            this.edytujKartaBadan.TabIndex = 36;
            this.edytujKartaBadan.Text = "Edytuj";
            this.edytujKartaBadan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edytujKartaBadan.Textcolor = System.Drawing.Color.White;
            this.edytujKartaBadan.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            // 
            // idpacjentaLabel
            // 
            this.idpacjentaLabel.AutoSize = true;
            this.idpacjentaLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idpacjentaLabel.Location = new System.Drawing.Point(57, 126);
            this.idpacjentaLabel.Name = "idpacjentaLabel";
            this.idpacjentaLabel.Size = new System.Drawing.Size(118, 22);
            this.idpacjentaLabel.TabIndex = 37;
            this.idpacjentaLabel.Text = "Id pacjenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(57, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Id badania";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(57, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Data rejestacji";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(57, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Data badania";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // idPacjentaCB
            // 
            this.idPacjentaCB.DataSource = this.pACJENCIBindingSource;
            this.idPacjentaCB.DisplayMember = "ID_PACJENTA";
            this.idPacjentaCB.FormattingEnabled = true;
            this.idPacjentaCB.Location = new System.Drawing.Point(203, 130);
            this.idPacjentaCB.Name = "idPacjentaCB";
            this.idPacjentaCB.Size = new System.Drawing.Size(121, 21);
            this.idPacjentaCB.TabIndex = 38;
            // 
            // pACJENCIBindingSource
            // 
            this.pACJENCIBindingSource.DataMember = "PACJENCI";
            this.pACJENCIBindingSource.DataSource = this.przychodniaSet1;
            // 
            // idBadaniaCB
            // 
            this.idBadaniaCB.DataSource = this.bADANIABindingSource;
            this.idBadaniaCB.DisplayMember = "ID_BADANIA";
            this.idBadaniaCB.FormattingEnabled = true;
            this.idBadaniaCB.Location = new System.Drawing.Point(203, 170);
            this.idBadaniaCB.Name = "idBadaniaCB";
            this.idBadaniaCB.Size = new System.Drawing.Size(121, 21);
            this.idBadaniaCB.TabIndex = 38;
            // 
            // lekarzeTableAdapter1
            // 
            this.lekarzeTableAdapter1.ClearBeforeFill = true;
            // 
            // pACJENCITableAdapter
            // 
            this.pACJENCITableAdapter.ClearBeforeFill = true;
            // 
            // lEKARZEBindingSource
            // 
            this.lEKARZEBindingSource.DataMember = "LEKARZE";
            this.lEKARZEBindingSource.DataSource = this.przychodniaSet1;
            // 
            // kARTABADAN_TAPI_WYSWIETL_KARTEBADANTableAdapter
            // 
            this.kARTABADAN_TAPI_WYSWIETL_KARTEBADANTableAdapter.ClearBeforeFill = true;
            // 
            // bADANIABindingSource
            // 
            this.bADANIABindingSource.DataMember = "BADANIA";
            this.bADANIABindingSource.DataSource = this.przychodniaSet1;
            // 
            // bADANIATableAdapter
            // 
            this.bADANIATableAdapter.ClearBeforeFill = true;
            // 
            // KartaBadanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.idBadaniaCB);
            this.Controls.Add(this.idPacjentaCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idpacjentaLabel);
            this.Controls.Add(this.usunKartaBadan);
            this.Controls.Add(this.edytujKartaBadan);
            this.Controls.Add(this.datagridBadania);
            this.Controls.Add(this.BadaniaLabel);
            this.Controls.Add(this.dodajKartaBadan);
            this.Controls.Add(this.DataBadania);
            this.Controls.Add(this.DataRejestracjiBadania);
            this.Name = "KartaBadanControl";
            this.Size = new System.Drawing.Size(844, 575);
            ((System.ComponentModel.ISupportInitialize)(this.datagridBadania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kARTABADANTAPIWYSWIETLKARTEBADANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENCIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEKARZEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bADANIABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDatepicker DataRejestracjiBadania;
        private Bunifu.Framework.UI.BunifuDatepicker DataBadania;
        private Bunifu.Framework.UI.BunifuFlatButton dodajKartaBadan;
        private System.Windows.Forms.Label BadaniaLabel;
        private Bunifu.UI.WinForms.BunifuDataGridView datagridBadania;
        private Bunifu.Framework.UI.BunifuFlatButton usunKartaBadan;
        private Bunifu.Framework.UI.BunifuFlatButton edytujKartaBadan;
        private System.Windows.Forms.Label idpacjentaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox idPacjentaCB;
        private System.Windows.Forms.ComboBox idBadaniaCB;
        private PrzychodniaSet przychodniaSet1;
        private PrzychodniaSetTableAdapters.LEKARZETableAdapter lekarzeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKARTABADANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPACJENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBADANIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAREJESTRACJIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tERMINBADANIADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kARTABADANTAPIWYSWIETLKARTEBADANBindingSource;
        private System.Windows.Forms.BindingSource pACJENCIBindingSource;
        private PrzychodniaSetTableAdapters.PACJENCITableAdapter pACJENCITableAdapter;
        private System.Windows.Forms.BindingSource lEKARZEBindingSource;
        private PrzychodniaSetTableAdapters.KARTABADAN_TAPI_WYSWIETL_KARTEBADANTableAdapter kARTABADAN_TAPI_WYSWIETL_KARTEBADANTableAdapter;
        private System.Windows.Forms.BindingSource bADANIABindingSource;
        private PrzychodniaSetTableAdapters.BADANIATableAdapter bADANIATableAdapter;
        private PrzychodniaSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}
