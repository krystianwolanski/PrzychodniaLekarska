namespace PrzychodniaLekarska3
{
    partial class PacjenciControl
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
            this.usunPacjenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.edytujPacjenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.datagridPacjenci = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.iDPACJENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMIĘDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWISKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pACJENCITAPIWYSWIETLPACJENTOWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaSet = new PrzychodniaLekarska3.PrzychodniaSet();
            this.PacjenciLabel = new System.Windows.Forms.Label();
            this.dodajPacjenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.peselPacjentaTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nazwiskoPacjentaTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.imiePacjentaTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pACJENCI_TAPI_WYSWIETL_PACJENTOWTableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.PACJENCI_TAPI_WYSWIETL_PACJENTOWTableAdapter();
            this.queriesTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPacjenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENCITAPIWYSWIETLPACJENTOWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usunPacjenta
            // 
            this.usunPacjenta.Active = false;
            this.usunPacjenta.Activecolor = System.Drawing.Color.DarkRed;
            this.usunPacjenta.BackColor = System.Drawing.Color.DarkRed;
            this.usunPacjenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usunPacjenta.BorderRadius = 0;
            this.usunPacjenta.ButtonText = "Usuń";
            this.usunPacjenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usunPacjenta.DisabledColor = System.Drawing.Color.Gray;
            this.usunPacjenta.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.usunPacjenta.Iconcolor = System.Drawing.Color.Transparent;
            this.usunPacjenta.Iconimage = null;
            this.usunPacjenta.Iconimage_right = null;
            this.usunPacjenta.Iconimage_right_Selected = null;
            this.usunPacjenta.Iconimage_Selected = null;
            this.usunPacjenta.IconMarginLeft = 0;
            this.usunPacjenta.IconMarginRight = 0;
            this.usunPacjenta.IconRightVisible = true;
            this.usunPacjenta.IconRightZoom = 0D;
            this.usunPacjenta.IconVisible = true;
            this.usunPacjenta.IconZoom = 90D;
            this.usunPacjenta.IsTab = false;
            this.usunPacjenta.Location = new System.Drawing.Point(656, 490);
            this.usunPacjenta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.usunPacjenta.Name = "usunPacjenta";
            this.usunPacjenta.Normalcolor = System.Drawing.Color.DarkRed;
            this.usunPacjenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usunPacjenta.OnHoverTextColor = System.Drawing.Color.White;
            this.usunPacjenta.selected = false;
            this.usunPacjenta.Size = new System.Drawing.Size(118, 50);
            this.usunPacjenta.TabIndex = 35;
            this.usunPacjenta.Text = "Usuń";
            this.usunPacjenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usunPacjenta.Textcolor = System.Drawing.Color.White;
            this.usunPacjenta.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunPacjenta.Click += new System.EventHandler(this.usunPacjenta_Click);
            // 
            // edytujPacjenta
            // 
            this.edytujPacjenta.Active = false;
            this.edytujPacjenta.Activecolor = System.Drawing.Color.Orange;
            this.edytujPacjenta.BackColor = System.Drawing.Color.Orange;
            this.edytujPacjenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edytujPacjenta.BorderRadius = 0;
            this.edytujPacjenta.ButtonText = "Edytuj";
            this.edytujPacjenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edytujPacjenta.DisabledColor = System.Drawing.Color.Gray;
            this.edytujPacjenta.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.edytujPacjenta.Iconcolor = System.Drawing.Color.Transparent;
            this.edytujPacjenta.Iconimage = null;
            this.edytujPacjenta.Iconimage_right = null;
            this.edytujPacjenta.Iconimage_right_Selected = null;
            this.edytujPacjenta.Iconimage_Selected = null;
            this.edytujPacjenta.IconMarginLeft = 0;
            this.edytujPacjenta.IconMarginRight = 0;
            this.edytujPacjenta.IconRightVisible = true;
            this.edytujPacjenta.IconRightZoom = 0D;
            this.edytujPacjenta.IconVisible = true;
            this.edytujPacjenta.IconZoom = 90D;
            this.edytujPacjenta.IsTab = false;
            this.edytujPacjenta.Location = new System.Drawing.Point(511, 490);
            this.edytujPacjenta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.edytujPacjenta.Name = "edytujPacjenta";
            this.edytujPacjenta.Normalcolor = System.Drawing.Color.Orange;
            this.edytujPacjenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.edytujPacjenta.OnHoverTextColor = System.Drawing.Color.White;
            this.edytujPacjenta.selected = false;
            this.edytujPacjenta.Size = new System.Drawing.Size(118, 50);
            this.edytujPacjenta.TabIndex = 36;
            this.edytujPacjenta.Text = "Edytuj";
            this.edytujPacjenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edytujPacjenta.Textcolor = System.Drawing.Color.White;
            this.edytujPacjenta.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujPacjenta.Click += new System.EventHandler(this.edytujPacjenta_Click);
            // 
            // datagridPacjenci
            // 
            this.datagridPacjenci.AllowCustomTheming = true;
            this.datagridPacjenci.AllowUserToAddRows = false;
            this.datagridPacjenci.AllowUserToDeleteRows = false;
            this.datagridPacjenci.AllowUserToResizeColumns = false;
            this.datagridPacjenci.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.datagridPacjenci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridPacjenci.AutoGenerateColumns = false;
            this.datagridPacjenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridPacjenci.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagridPacjenci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridPacjenci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridPacjenci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridPacjenci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridPacjenci.ColumnHeadersHeight = 40;
            this.datagridPacjenci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPACJENTADataGridViewTextBoxColumn,
            this.iMIĘDataGridViewTextBoxColumn,
            this.nAZWISKODataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn});
            this.datagridPacjenci.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridPacjenci.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.datagridPacjenci.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridPacjenci.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridPacjenci.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridPacjenci.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.datagridPacjenci.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridPacjenci.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.datagridPacjenci.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.datagridPacjenci.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridPacjenci.CurrentTheme.Name = null;
            this.datagridPacjenci.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridPacjenci.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.datagridPacjenci.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridPacjenci.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridPacjenci.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridPacjenci.DataSource = this.pACJENCITAPIWYSWIETLPACJENTOWBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridPacjenci.DefaultCellStyle = dataGridViewCellStyle6;
            this.datagridPacjenci.EnableHeadersVisualStyles = false;
            this.datagridPacjenci.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridPacjenci.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.datagridPacjenci.HeaderBgColor = System.Drawing.Color.Empty;
            this.datagridPacjenci.HeaderForeColor = System.Drawing.Color.White;
            this.datagridPacjenci.Location = new System.Drawing.Point(446, 0);
            this.datagridPacjenci.Name = "datagridPacjenci";
            this.datagridPacjenci.ReadOnly = true;
            this.datagridPacjenci.RowHeadersVisible = false;
            this.datagridPacjenci.RowTemplate.Height = 40;
            this.datagridPacjenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridPacjenci.Size = new System.Drawing.Size(378, 463);
            this.datagridPacjenci.TabIndex = 34;
            this.datagridPacjenci.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // iDPACJENTADataGridViewTextBoxColumn
            // 
            this.iDPACJENTADataGridViewTextBoxColumn.DataPropertyName = "ID_PACJENTA";
            this.iDPACJENTADataGridViewTextBoxColumn.HeaderText = "ID_PACJENTA";
            this.iDPACJENTADataGridViewTextBoxColumn.Name = "iDPACJENTADataGridViewTextBoxColumn";
            this.iDPACJENTADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPACJENTADataGridViewTextBoxColumn.Visible = false;
            // 
            // iMIĘDataGridViewTextBoxColumn
            // 
            this.iMIĘDataGridViewTextBoxColumn.DataPropertyName = "IMIĘ";
            this.iMIĘDataGridViewTextBoxColumn.HeaderText = "IMIĘ";
            this.iMIĘDataGridViewTextBoxColumn.Name = "iMIĘDataGridViewTextBoxColumn";
            this.iMIĘDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAZWISKODataGridViewTextBoxColumn
            // 
            this.nAZWISKODataGridViewTextBoxColumn.DataPropertyName = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn.HeaderText = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn.Name = "nAZWISKODataGridViewTextBoxColumn";
            this.nAZWISKODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            this.pESELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pACJENCITAPIWYSWIETLPACJENTOWBindingSource
            // 
            this.pACJENCITAPIWYSWIETLPACJENTOWBindingSource.DataMember = "PACJENCI_TAPI_WYSWIETL_PACJENTOW";
            this.pACJENCITAPIWYSWIETLPACJENTOWBindingSource.DataSource = this.przychodniaSet;
            // 
            // przychodniaSet
            // 
            this.przychodniaSet.DataSetName = "PrzychodniaSet";
            this.przychodniaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PacjenciLabel
            // 
            this.PacjenciLabel.AutoSize = true;
            this.PacjenciLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PacjenciLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.PacjenciLabel.Location = new System.Drawing.Point(51, 62);
            this.PacjenciLabel.Name = "PacjenciLabel";
            this.PacjenciLabel.Size = new System.Drawing.Size(141, 36);
            this.PacjenciLabel.TabIndex = 33;
            this.PacjenciLabel.Text = "Pacjenci";
            // 
            // dodajPacjenta
            // 
            this.dodajPacjenta.Active = false;
            this.dodajPacjenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajPacjenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajPacjenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dodajPacjenta.BorderRadius = 0;
            this.dodajPacjenta.ButtonText = "Dodaj";
            this.dodajPacjenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajPacjenta.DisabledColor = System.Drawing.Color.Gray;
            this.dodajPacjenta.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.dodajPacjenta.Iconcolor = System.Drawing.Color.Transparent;
            this.dodajPacjenta.Iconimage = null;
            this.dodajPacjenta.Iconimage_right = null;
            this.dodajPacjenta.Iconimage_right_Selected = null;
            this.dodajPacjenta.Iconimage_Selected = null;
            this.dodajPacjenta.IconMarginLeft = 0;
            this.dodajPacjenta.IconMarginRight = 0;
            this.dodajPacjenta.IconRightVisible = true;
            this.dodajPacjenta.IconRightZoom = 0D;
            this.dodajPacjenta.IconVisible = true;
            this.dodajPacjenta.IconZoom = 90D;
            this.dodajPacjenta.IsTab = false;
            this.dodajPacjenta.Location = new System.Drawing.Point(57, 365);
            this.dodajPacjenta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dodajPacjenta.Name = "dodajPacjenta";
            this.dodajPacjenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajPacjenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dodajPacjenta.OnHoverTextColor = System.Drawing.Color.White;
            this.dodajPacjenta.selected = false;
            this.dodajPacjenta.Size = new System.Drawing.Size(118, 50);
            this.dodajPacjenta.TabIndex = 32;
            this.dodajPacjenta.Text = "Dodaj";
            this.dodajPacjenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dodajPacjenta.Textcolor = System.Drawing.Color.White;
            this.dodajPacjenta.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajPacjenta.Click += new System.EventHandler(this.dodajPacjenta_Click);
            // 
            // peselPacjentaTB
            // 
            this.peselPacjentaTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.peselPacjentaTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.peselPacjentaTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.peselPacjentaTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.peselPacjentaTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peselPacjentaTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.peselPacjentaTB.HintForeColor = System.Drawing.Color.Empty;
            this.peselPacjentaTB.HintText = "Pesel";
            this.peselPacjentaTB.isPassword = false;
            this.peselPacjentaTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.peselPacjentaTB.LineIdleColor = System.Drawing.Color.Gray;
            this.peselPacjentaTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.peselPacjentaTB.LineThickness = 4;
            this.peselPacjentaTB.Location = new System.Drawing.Point(57, 276);
            this.peselPacjentaTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.peselPacjentaTB.MaxLength = 32767;
            this.peselPacjentaTB.Name = "peselPacjentaTB";
            this.peselPacjentaTB.Size = new System.Drawing.Size(335, 43);
            this.peselPacjentaTB.TabIndex = 29;
            this.peselPacjentaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nazwiskoPacjentaTB
            // 
            this.nazwiskoPacjentaTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nazwiskoPacjentaTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nazwiskoPacjentaTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nazwiskoPacjentaTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nazwiskoPacjentaTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwiskoPacjentaTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.nazwiskoPacjentaTB.HintForeColor = System.Drawing.Color.Empty;
            this.nazwiskoPacjentaTB.HintText = "Nazwisko";
            this.nazwiskoPacjentaTB.isPassword = false;
            this.nazwiskoPacjentaTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.nazwiskoPacjentaTB.LineIdleColor = System.Drawing.Color.Gray;
            this.nazwiskoPacjentaTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.nazwiskoPacjentaTB.LineThickness = 4;
            this.nazwiskoPacjentaTB.Location = new System.Drawing.Point(57, 211);
            this.nazwiskoPacjentaTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.nazwiskoPacjentaTB.MaxLength = 32767;
            this.nazwiskoPacjentaTB.Name = "nazwiskoPacjentaTB";
            this.nazwiskoPacjentaTB.Size = new System.Drawing.Size(335, 43);
            this.nazwiskoPacjentaTB.TabIndex = 30;
            this.nazwiskoPacjentaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // imiePacjentaTB
            // 
            this.imiePacjentaTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.imiePacjentaTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.imiePacjentaTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.imiePacjentaTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imiePacjentaTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imiePacjentaTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.imiePacjentaTB.HintForeColor = System.Drawing.Color.Empty;
            this.imiePacjentaTB.HintText = "Imię";
            this.imiePacjentaTB.isPassword = false;
            this.imiePacjentaTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.imiePacjentaTB.LineIdleColor = System.Drawing.Color.Gray;
            this.imiePacjentaTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.imiePacjentaTB.LineThickness = 4;
            this.imiePacjentaTB.Location = new System.Drawing.Point(57, 147);
            this.imiePacjentaTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.imiePacjentaTB.MaxLength = 32767;
            this.imiePacjentaTB.Name = "imiePacjentaTB";
            this.imiePacjentaTB.Size = new System.Drawing.Size(335, 43);
            this.imiePacjentaTB.TabIndex = 31;
            this.imiePacjentaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pACJENCI_TAPI_WYSWIETL_PACJENTOWTableAdapter
            // 
            this.pACJENCI_TAPI_WYSWIETL_PACJENTOWTableAdapter.ClearBeforeFill = true;
            // 
            // PacjenciControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usunPacjenta);
            this.Controls.Add(this.edytujPacjenta);
            this.Controls.Add(this.datagridPacjenci);
            this.Controls.Add(this.PacjenciLabel);
            this.Controls.Add(this.dodajPacjenta);
            this.Controls.Add(this.peselPacjentaTB);
            this.Controls.Add(this.nazwiskoPacjentaTB);
            this.Controls.Add(this.imiePacjentaTB);
            this.Name = "PacjenciControl";
            this.Size = new System.Drawing.Size(824, 575);
            ((System.ComponentModel.ISupportInitialize)(this.datagridPacjenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENCITAPIWYSWIETLPACJENTOWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton usunPacjenta;
        private Bunifu.Framework.UI.BunifuFlatButton edytujPacjenta;
        private Bunifu.UI.WinForms.BunifuDataGridView datagridPacjenci;
        private System.Windows.Forms.Label PacjenciLabel;
        private Bunifu.Framework.UI.BunifuFlatButton dodajPacjenta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox peselPacjentaTB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nazwiskoPacjentaTB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox imiePacjentaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPACJENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMIĘDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWISKODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pACJENCITAPIWYSWIETLPACJENTOWBindingSource;
        private PrzychodniaSet przychodniaSet;
        private PrzychodniaSetTableAdapters.PACJENCI_TAPI_WYSWIETL_PACJENTOWTableAdapter pACJENCI_TAPI_WYSWIETL_PACJENTOWTableAdapter;
        private PrzychodniaSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}
