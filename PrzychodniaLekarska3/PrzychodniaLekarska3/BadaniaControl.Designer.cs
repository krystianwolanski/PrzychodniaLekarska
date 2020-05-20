namespace PrzychodniaLekarska3
{
    partial class BadaniaControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BadaniaLabel = new System.Windows.Forms.Label();
            this.dodajBadanie = new Bunifu.Framework.UI.BunifuFlatButton();
            this.podtypBadaniaTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.typBadaniaTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGridBadania = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.iDBADANIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pODTYPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bADANIATAPIWYSWIETLBADANIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaSet = new PrzychodniaLekarska3.PrzychodniaSet();
            this.usunBadanie = new Bunifu.Framework.UI.BunifuFlatButton();
            this.edytujBadanie = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bADANIA_TAPI_WYSWIETL_BADANIATableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.BADANIA_TAPI_WYSWIETL_BADANIATableAdapter();
            this.queriesTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.QueriesTableAdapter();
            this.NazwaBadaniaTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CenaBadaniaTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBadania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bADANIATAPIWYSWIETLBADANIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BadaniaLabel
            // 
            this.BadaniaLabel.AutoSize = true;
            this.BadaniaLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BadaniaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BadaniaLabel.Location = new System.Drawing.Point(51, 62);
            this.BadaniaLabel.Name = "BadaniaLabel";
            this.BadaniaLabel.Size = new System.Drawing.Size(137, 36);
            this.BadaniaLabel.TabIndex = 30;
            this.BadaniaLabel.Text = "Badania";
            // 
            // dodajBadanie
            // 
            this.dodajBadanie.Active = false;
            this.dodajBadanie.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajBadanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajBadanie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dodajBadanie.BorderRadius = 0;
            this.dodajBadanie.ButtonText = "Dodaj";
            this.dodajBadanie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajBadanie.DisabledColor = System.Drawing.Color.Gray;
            this.dodajBadanie.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.dodajBadanie.Iconcolor = System.Drawing.Color.Transparent;
            this.dodajBadanie.Iconimage = null;
            this.dodajBadanie.Iconimage_right = null;
            this.dodajBadanie.Iconimage_right_Selected = null;
            this.dodajBadanie.Iconimage_Selected = null;
            this.dodajBadanie.IconMarginLeft = 0;
            this.dodajBadanie.IconMarginRight = 0;
            this.dodajBadanie.IconRightVisible = true;
            this.dodajBadanie.IconRightZoom = 0D;
            this.dodajBadanie.IconVisible = true;
            this.dodajBadanie.IconZoom = 90D;
            this.dodajBadanie.IsTab = false;
            this.dodajBadanie.Location = new System.Drawing.Point(57, 453);
            this.dodajBadanie.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dodajBadanie.Name = "dodajBadanie";
            this.dodajBadanie.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajBadanie.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dodajBadanie.OnHoverTextColor = System.Drawing.Color.White;
            this.dodajBadanie.selected = false;
            this.dodajBadanie.Size = new System.Drawing.Size(118, 50);
            this.dodajBadanie.TabIndex = 29;
            this.dodajBadanie.Text = "Dodaj";
            this.dodajBadanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dodajBadanie.Textcolor = System.Drawing.Color.White;
            this.dodajBadanie.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajBadanie.Click += new System.EventHandler(this.dodajBadanie_Click);
            // 
            // podtypBadaniaTB
            // 
            this.podtypBadaniaTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.podtypBadaniaTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.podtypBadaniaTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.podtypBadaniaTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.podtypBadaniaTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podtypBadaniaTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.podtypBadaniaTB.HintForeColor = System.Drawing.Color.Empty;
            this.podtypBadaniaTB.HintText = "Podtyp";
            this.podtypBadaniaTB.isPassword = false;
            this.podtypBadaniaTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.podtypBadaniaTB.LineIdleColor = System.Drawing.Color.Gray;
            this.podtypBadaniaTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.podtypBadaniaTB.LineThickness = 4;
            this.podtypBadaniaTB.Location = new System.Drawing.Point(57, 215);
            this.podtypBadaniaTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.podtypBadaniaTB.MaxLength = 32767;
            this.podtypBadaniaTB.Name = "podtypBadaniaTB";
            this.podtypBadaniaTB.Size = new System.Drawing.Size(335, 43);
            this.podtypBadaniaTB.TabIndex = 27;
            this.podtypBadaniaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // typBadaniaTB
            // 
            this.typBadaniaTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.typBadaniaTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.typBadaniaTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.typBadaniaTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.typBadaniaTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typBadaniaTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.typBadaniaTB.HintForeColor = System.Drawing.Color.Empty;
            this.typBadaniaTB.HintText = "Typ";
            this.typBadaniaTB.isPassword = false;
            this.typBadaniaTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.typBadaniaTB.LineIdleColor = System.Drawing.Color.Gray;
            this.typBadaniaTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.typBadaniaTB.LineThickness = 4;
            this.typBadaniaTB.Location = new System.Drawing.Point(57, 147);
            this.typBadaniaTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.typBadaniaTB.MaxLength = 32767;
            this.typBadaniaTB.Name = "typBadaniaTB";
            this.typBadaniaTB.Size = new System.Drawing.Size(335, 43);
            this.typBadaniaTB.TabIndex = 28;
            this.typBadaniaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dataGridBadania
            // 
            this.dataGridBadania.AllowCustomTheming = true;
            this.dataGridBadania.AllowUserToAddRows = false;
            this.dataGridBadania.AllowUserToDeleteRows = false;
            this.dataGridBadania.AllowUserToResizeColumns = false;
            this.dataGridBadania.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridBadania.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridBadania.AutoGenerateColumns = false;
            this.dataGridBadania.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBadania.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridBadania.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridBadania.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridBadania.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBadania.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridBadania.ColumnHeadersHeight = 40;
            this.dataGridBadania.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBADANIADataGridViewTextBoxColumn,
            this.tYPDataGridViewTextBoxColumn,
            this.pODTYPDataGridViewTextBoxColumn,
            this.nAZWADataGridViewTextBoxColumn,
            this.cENADataGridViewTextBoxColumn});
            this.dataGridBadania.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridBadania.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dataGridBadania.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridBadania.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.dataGridBadania.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridBadania.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridBadania.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.dataGridBadania.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dataGridBadania.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dataGridBadania.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridBadania.CurrentTheme.Name = null;
            this.dataGridBadania.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridBadania.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dataGridBadania.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridBadania.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.dataGridBadania.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridBadania.DataSource = this.bADANIATAPIWYSWIETLBADANIABindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBadania.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridBadania.EnableHeadersVisualStyles = false;
            this.dataGridBadania.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.dataGridBadania.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dataGridBadania.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridBadania.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridBadania.Location = new System.Drawing.Point(446, 0);
            this.dataGridBadania.Name = "dataGridBadania";
            this.dataGridBadania.ReadOnly = true;
            this.dataGridBadania.RowHeadersVisible = false;
            this.dataGridBadania.RowTemplate.Height = 40;
            this.dataGridBadania.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBadania.Size = new System.Drawing.Size(378, 463);
            this.dataGridBadania.TabIndex = 33;
            this.dataGridBadania.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // iDBADANIADataGridViewTextBoxColumn
            // 
            this.iDBADANIADataGridViewTextBoxColumn.DataPropertyName = "ID_BADANIA";
            this.iDBADANIADataGridViewTextBoxColumn.HeaderText = "ID_BADANIA";
            this.iDBADANIADataGridViewTextBoxColumn.Name = "iDBADANIADataGridViewTextBoxColumn";
            this.iDBADANIADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDBADANIADataGridViewTextBoxColumn.Visible = false;
            // 
            // tYPDataGridViewTextBoxColumn
            // 
            this.tYPDataGridViewTextBoxColumn.DataPropertyName = "TYP";
            this.tYPDataGridViewTextBoxColumn.HeaderText = "TYP";
            this.tYPDataGridViewTextBoxColumn.Name = "tYPDataGridViewTextBoxColumn";
            this.tYPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pODTYPDataGridViewTextBoxColumn
            // 
            this.pODTYPDataGridViewTextBoxColumn.DataPropertyName = "PODTYP";
            this.pODTYPDataGridViewTextBoxColumn.HeaderText = "PODTYP";
            this.pODTYPDataGridViewTextBoxColumn.Name = "pODTYPDataGridViewTextBoxColumn";
            this.pODTYPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAZWADataGridViewTextBoxColumn
            // 
            this.nAZWADataGridViewTextBoxColumn.DataPropertyName = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.HeaderText = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.Name = "nAZWADataGridViewTextBoxColumn";
            this.nAZWADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cENADataGridViewTextBoxColumn
            // 
            this.cENADataGridViewTextBoxColumn.DataPropertyName = "CENA";
            this.cENADataGridViewTextBoxColumn.HeaderText = "CENA";
            this.cENADataGridViewTextBoxColumn.Name = "cENADataGridViewTextBoxColumn";
            this.cENADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bADANIATAPIWYSWIETLBADANIABindingSource
            // 
            this.bADANIATAPIWYSWIETLBADANIABindingSource.DataMember = "BADANIA_TAPI_WYSWIETL_BADANIA";
            this.bADANIATAPIWYSWIETLBADANIABindingSource.DataSource = this.przychodniaSet;
            // 
            // przychodniaSet
            // 
            this.przychodniaSet.DataSetName = "PrzychodniaSet";
            this.przychodniaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usunBadanie
            // 
            this.usunBadanie.Active = false;
            this.usunBadanie.Activecolor = System.Drawing.Color.DarkRed;
            this.usunBadanie.BackColor = System.Drawing.Color.DarkRed;
            this.usunBadanie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usunBadanie.BorderRadius = 0;
            this.usunBadanie.ButtonText = "Usuń";
            this.usunBadanie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usunBadanie.DisabledColor = System.Drawing.Color.Gray;
            this.usunBadanie.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.usunBadanie.Iconcolor = System.Drawing.Color.Transparent;
            this.usunBadanie.Iconimage = null;
            this.usunBadanie.Iconimage_right = null;
            this.usunBadanie.Iconimage_right_Selected = null;
            this.usunBadanie.Iconimage_Selected = null;
            this.usunBadanie.IconMarginLeft = 0;
            this.usunBadanie.IconMarginRight = 0;
            this.usunBadanie.IconRightVisible = true;
            this.usunBadanie.IconRightZoom = 0D;
            this.usunBadanie.IconVisible = true;
            this.usunBadanie.IconZoom = 90D;
            this.usunBadanie.IsTab = false;
            this.usunBadanie.Location = new System.Drawing.Point(647, 489);
            this.usunBadanie.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.usunBadanie.Name = "usunBadanie";
            this.usunBadanie.Normalcolor = System.Drawing.Color.DarkRed;
            this.usunBadanie.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usunBadanie.OnHoverTextColor = System.Drawing.Color.White;
            this.usunBadanie.selected = false;
            this.usunBadanie.Size = new System.Drawing.Size(118, 50);
            this.usunBadanie.TabIndex = 34;
            this.usunBadanie.Text = "Usuń";
            this.usunBadanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usunBadanie.Textcolor = System.Drawing.Color.White;
            this.usunBadanie.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunBadanie.Click += new System.EventHandler(this.usunBadanie_Click);
            // 
            // edytujBadanie
            // 
            this.edytujBadanie.Active = false;
            this.edytujBadanie.Activecolor = System.Drawing.Color.Orange;
            this.edytujBadanie.BackColor = System.Drawing.Color.Orange;
            this.edytujBadanie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edytujBadanie.BorderRadius = 0;
            this.edytujBadanie.ButtonText = "Edytuj";
            this.edytujBadanie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edytujBadanie.DisabledColor = System.Drawing.Color.Gray;
            this.edytujBadanie.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.edytujBadanie.Iconcolor = System.Drawing.Color.Transparent;
            this.edytujBadanie.Iconimage = null;
            this.edytujBadanie.Iconimage_right = null;
            this.edytujBadanie.Iconimage_right_Selected = null;
            this.edytujBadanie.Iconimage_Selected = null;
            this.edytujBadanie.IconMarginLeft = 0;
            this.edytujBadanie.IconMarginRight = 0;
            this.edytujBadanie.IconRightVisible = true;
            this.edytujBadanie.IconRightZoom = 0D;
            this.edytujBadanie.IconVisible = true;
            this.edytujBadanie.IconZoom = 90D;
            this.edytujBadanie.IsTab = false;
            this.edytujBadanie.Location = new System.Drawing.Point(502, 489);
            this.edytujBadanie.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.edytujBadanie.Name = "edytujBadanie";
            this.edytujBadanie.Normalcolor = System.Drawing.Color.Orange;
            this.edytujBadanie.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.edytujBadanie.OnHoverTextColor = System.Drawing.Color.White;
            this.edytujBadanie.selected = false;
            this.edytujBadanie.Size = new System.Drawing.Size(118, 50);
            this.edytujBadanie.TabIndex = 35;
            this.edytujBadanie.Text = "Edytuj";
            this.edytujBadanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edytujBadanie.Textcolor = System.Drawing.Color.White;
            this.edytujBadanie.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujBadanie.Click += new System.EventHandler(this.edytujBadanie_Click);
            // 
            // bADANIA_TAPI_WYSWIETL_BADANIATableAdapter
            // 
            this.bADANIA_TAPI_WYSWIETL_BADANIATableAdapter.ClearBeforeFill = true;
            // 
            // NazwaBadaniaTB
            // 
            this.NazwaBadaniaTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NazwaBadaniaTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NazwaBadaniaTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NazwaBadaniaTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NazwaBadaniaTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaBadaniaTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.NazwaBadaniaTB.HintForeColor = System.Drawing.Color.Empty;
            this.NazwaBadaniaTB.HintText = "Nazwa";
            this.NazwaBadaniaTB.isPassword = false;
            this.NazwaBadaniaTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.NazwaBadaniaTB.LineIdleColor = System.Drawing.Color.Gray;
            this.NazwaBadaniaTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.NazwaBadaniaTB.LineThickness = 4;
            this.NazwaBadaniaTB.Location = new System.Drawing.Point(57, 281);
            this.NazwaBadaniaTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NazwaBadaniaTB.MaxLength = 32767;
            this.NazwaBadaniaTB.Name = "NazwaBadaniaTB";
            this.NazwaBadaniaTB.Size = new System.Drawing.Size(335, 43);
            this.NazwaBadaniaTB.TabIndex = 28;
            this.NazwaBadaniaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CenaBadaniaTB
            // 
            this.CenaBadaniaTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CenaBadaniaTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CenaBadaniaTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CenaBadaniaTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CenaBadaniaTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CenaBadaniaTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.CenaBadaniaTB.HintForeColor = System.Drawing.Color.Empty;
            this.CenaBadaniaTB.HintText = "Cena";
            this.CenaBadaniaTB.isPassword = false;
            this.CenaBadaniaTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.CenaBadaniaTB.LineIdleColor = System.Drawing.Color.Gray;
            this.CenaBadaniaTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.CenaBadaniaTB.LineThickness = 4;
            this.CenaBadaniaTB.Location = new System.Drawing.Point(57, 349);
            this.CenaBadaniaTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CenaBadaniaTB.MaxLength = 32767;
            this.CenaBadaniaTB.Name = "CenaBadaniaTB";
            this.CenaBadaniaTB.Size = new System.Drawing.Size(335, 43);
            this.CenaBadaniaTB.TabIndex = 27;
            this.CenaBadaniaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BadaniaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usunBadanie);
            this.Controls.Add(this.edytujBadanie);
            this.Controls.Add(this.dataGridBadania);
            this.Controls.Add(this.BadaniaLabel);
            this.Controls.Add(this.dodajBadanie);
            this.Controls.Add(this.CenaBadaniaTB);
            this.Controls.Add(this.NazwaBadaniaTB);
            this.Controls.Add(this.podtypBadaniaTB);
            this.Controls.Add(this.typBadaniaTB);
            this.Name = "BadaniaControl";
            this.Size = new System.Drawing.Size(824, 575);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBadania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bADANIATAPIWYSWIETLBADANIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BadaniaLabel;
        private Bunifu.Framework.UI.BunifuFlatButton dodajBadanie;
        private Bunifu.Framework.UI.BunifuMaterialTextbox podtypBadaniaTB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox typBadaniaTB;
        public Bunifu.UI.WinForms.BunifuDataGridView dataGridBadania;
        private Bunifu.Framework.UI.BunifuFlatButton usunBadanie;
        private Bunifu.Framework.UI.BunifuFlatButton edytujBadanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAREJESTRACJIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATABADANIADataGridViewTextBoxColumn;
        private PrzychodniaSet przychodniaSet;
        private PrzychodniaSetTableAdapters.BADANIA_TAPI_WYSWIETL_BADANIATableAdapter bADANIA_TAPI_WYSWIETL_BADANIATableAdapter;
        private PrzychodniaSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBADANIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pODTYPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bADANIATAPIWYSWIETLBADANIABindingSource;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NazwaBadaniaTB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CenaBadaniaTB;
    }
}
