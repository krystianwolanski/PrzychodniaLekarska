namespace PrzychodniaLekarska3
{
    partial class LekarzeControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LekarzeControl));
            this.LekarzeLabel = new System.Windows.Forms.Label();
            this.dodajLekarza = new Bunifu.Framework.UI.BunifuFlatButton();
            this.specjalizacjaLekarzaTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nazwiskoLekarzaTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.imieLekarzaTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.datagridLekarze5 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.iDLEKARZADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieLekarza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoLekarza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specjalizacjaLekarza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEKARZETAPIWYSWIETLLEKARZY1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaSet = new PrzychodniaLekarska3.PrzychodniaSet();
            this.usunLekarza = new Bunifu.Framework.UI.BunifuFlatButton();
            this.edytujLekarza = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LekarzSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.queriesTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.QueriesTableAdapter();
            this.lEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.LEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridLekarze5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEKARZETAPIWYSWIETLLEKARZY1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LekarzeLabel
            // 
            this.LekarzeLabel.AutoSize = true;
            this.LekarzeLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LekarzeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.LekarzeLabel.Location = new System.Drawing.Point(51, 62);
            this.LekarzeLabel.Name = "LekarzeLabel";
            this.LekarzeLabel.Size = new System.Drawing.Size(122, 36);
            this.LekarzeLabel.TabIndex = 25;
            this.LekarzeLabel.Text = "Lekarze";
            // 
            // dodajLekarza
            // 
            this.dodajLekarza.Active = false;
            this.dodajLekarza.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajLekarza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajLekarza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dodajLekarza.BorderRadius = 0;
            this.dodajLekarza.ButtonText = "Dodaj";
            this.dodajLekarza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajLekarza.DisabledColor = System.Drawing.Color.Gray;
            this.dodajLekarza.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.dodajLekarza.Iconcolor = System.Drawing.Color.Transparent;
            this.dodajLekarza.Iconimage = null;
            this.dodajLekarza.Iconimage_right = null;
            this.dodajLekarza.Iconimage_right_Selected = null;
            this.dodajLekarza.Iconimage_Selected = null;
            this.dodajLekarza.IconMarginLeft = 0;
            this.dodajLekarza.IconMarginRight = 0;
            this.dodajLekarza.IconRightVisible = true;
            this.dodajLekarza.IconRightZoom = 0D;
            this.dodajLekarza.IconVisible = true;
            this.dodajLekarza.IconZoom = 90D;
            this.dodajLekarza.IsTab = false;
            this.dodajLekarza.Location = new System.Drawing.Point(57, 365);
            this.dodajLekarza.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dodajLekarza.Name = "dodajLekarza";
            this.dodajLekarza.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajLekarza.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dodajLekarza.OnHoverTextColor = System.Drawing.Color.White;
            this.dodajLekarza.selected = false;
            this.dodajLekarza.Size = new System.Drawing.Size(118, 50);
            this.dodajLekarza.TabIndex = 24;
            this.dodajLekarza.Text = "Dodaj";
            this.dodajLekarza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dodajLekarza.Textcolor = System.Drawing.Color.White;
            this.dodajLekarza.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajLekarza.Click += new System.EventHandler(this.dodajLekarza_Click);
            // 
            // specjalizacjaLekarzaTB
            // 
            this.specjalizacjaLekarzaTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.specjalizacjaLekarzaTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.specjalizacjaLekarzaTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.specjalizacjaLekarzaTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.specjalizacjaLekarzaTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.specjalizacjaLekarzaTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.specjalizacjaLekarzaTB.HintForeColor = System.Drawing.Color.Empty;
            this.specjalizacjaLekarzaTB.HintText = "Specjalizacja";
            this.specjalizacjaLekarzaTB.isPassword = false;
            this.specjalizacjaLekarzaTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.specjalizacjaLekarzaTB.LineIdleColor = System.Drawing.Color.Gray;
            this.specjalizacjaLekarzaTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.specjalizacjaLekarzaTB.LineThickness = 4;
            this.specjalizacjaLekarzaTB.Location = new System.Drawing.Point(57, 276);
            this.specjalizacjaLekarzaTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.specjalizacjaLekarzaTB.MaxLength = 32767;
            this.specjalizacjaLekarzaTB.Name = "specjalizacjaLekarzaTB";
            this.specjalizacjaLekarzaTB.Size = new System.Drawing.Size(335, 43);
            this.specjalizacjaLekarzaTB.TabIndex = 21;
            this.specjalizacjaLekarzaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.specjalizacjaLekarzaTB.OnValueChanged += new System.EventHandler(this.spejcalizacjaLekarzaTB_OnValueChanged);
            // 
            // nazwiskoLekarzaTB
            // 
            this.nazwiskoLekarzaTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nazwiskoLekarzaTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nazwiskoLekarzaTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nazwiskoLekarzaTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nazwiskoLekarzaTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwiskoLekarzaTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.nazwiskoLekarzaTB.HintForeColor = System.Drawing.Color.Empty;
            this.nazwiskoLekarzaTB.HintText = "Nazwisko";
            this.nazwiskoLekarzaTB.isPassword = false;
            this.nazwiskoLekarzaTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.nazwiskoLekarzaTB.LineIdleColor = System.Drawing.Color.Gray;
            this.nazwiskoLekarzaTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.nazwiskoLekarzaTB.LineThickness = 4;
            this.nazwiskoLekarzaTB.Location = new System.Drawing.Point(57, 211);
            this.nazwiskoLekarzaTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.nazwiskoLekarzaTB.MaxLength = 32767;
            this.nazwiskoLekarzaTB.Name = "nazwiskoLekarzaTB";
            this.nazwiskoLekarzaTB.Size = new System.Drawing.Size(335, 43);
            this.nazwiskoLekarzaTB.TabIndex = 22;
            this.nazwiskoLekarzaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nazwiskoLekarzaTB.OnValueChanged += new System.EventHandler(this.nazwiskoLekarzaTB_OnValueChanged);
            // 
            // imieLekarzaTB
            // 
            this.imieLekarzaTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.imieLekarzaTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.imieLekarzaTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.imieLekarzaTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imieLekarzaTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imieLekarzaTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.imieLekarzaTB.HintForeColor = System.Drawing.Color.Empty;
            this.imieLekarzaTB.HintText = "Imię";
            this.imieLekarzaTB.isPassword = false;
            this.imieLekarzaTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.imieLekarzaTB.LineIdleColor = System.Drawing.Color.Gray;
            this.imieLekarzaTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.imieLekarzaTB.LineThickness = 4;
            this.imieLekarzaTB.Location = new System.Drawing.Point(57, 147);
            this.imieLekarzaTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.imieLekarzaTB.MaxLength = 32767;
            this.imieLekarzaTB.Name = "imieLekarzaTB";
            this.imieLekarzaTB.Size = new System.Drawing.Size(335, 43);
            this.imieLekarzaTB.TabIndex = 23;
            this.imieLekarzaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // datagridLekarze5
            // 
            this.datagridLekarze5.AllowCustomTheming = true;
            this.datagridLekarze5.AllowUserToAddRows = false;
            this.datagridLekarze5.AllowUserToDeleteRows = false;
            this.datagridLekarze5.AllowUserToResizeColumns = false;
            this.datagridLekarze5.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.datagridLekarze5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridLekarze5.AutoGenerateColumns = false;
            this.datagridLekarze5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridLekarze5.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagridLekarze5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridLekarze5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridLekarze5.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridLekarze5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridLekarze5.ColumnHeadersHeight = 40;
            this.datagridLekarze5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDLEKARZADataGridViewTextBoxColumn,
            this.imieLekarza,
            this.nazwiskoLekarza,
            this.specjalizacjaLekarza});
            this.datagridLekarze5.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridLekarze5.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.datagridLekarze5.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridLekarze5.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridLekarze5.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridLekarze5.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.datagridLekarze5.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridLekarze5.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.datagridLekarze5.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.datagridLekarze5.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridLekarze5.CurrentTheme.Name = null;
            this.datagridLekarze5.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridLekarze5.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.datagridLekarze5.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridLekarze5.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridLekarze5.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridLekarze5.DataSource = this.lEKARZETAPIWYSWIETLLEKARZY1BindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridLekarze5.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridLekarze5.EnableHeadersVisualStyles = false;
            this.datagridLekarze5.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridLekarze5.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.datagridLekarze5.HeaderBgColor = System.Drawing.Color.Empty;
            this.datagridLekarze5.HeaderForeColor = System.Drawing.Color.White;
            this.datagridLekarze5.Location = new System.Drawing.Point(446, 0);
            this.datagridLekarze5.Name = "datagridLekarze5";
            this.datagridLekarze5.ReadOnly = true;
            this.datagridLekarze5.RowHeadersVisible = false;
            this.datagridLekarze5.RowTemplate.Height = 40;
            this.datagridLekarze5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridLekarze5.Size = new System.Drawing.Size(378, 463);
            this.datagridLekarze5.TabIndex = 26;
            this.datagridLekarze5.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.datagridLekarze5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridLekarze5_CellContentClick);
            // 
            // iDLEKARZADataGridViewTextBoxColumn
            // 
            this.iDLEKARZADataGridViewTextBoxColumn.DataPropertyName = "ID_LEKARZA";
            this.iDLEKARZADataGridViewTextBoxColumn.HeaderText = "ID_LEKARZA";
            this.iDLEKARZADataGridViewTextBoxColumn.Name = "iDLEKARZADataGridViewTextBoxColumn";
            this.iDLEKARZADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDLEKARZADataGridViewTextBoxColumn.Visible = false;
            // 
            // imieLekarza
            // 
            this.imieLekarza.DataPropertyName = "IMIĘ";
            this.imieLekarza.HeaderText = "IMIĘ";
            this.imieLekarza.Name = "imieLekarza";
            this.imieLekarza.ReadOnly = true;
            // 
            // nazwiskoLekarza
            // 
            this.nazwiskoLekarza.DataPropertyName = "NAZWISKO";
            this.nazwiskoLekarza.HeaderText = "NAZWISKO";
            this.nazwiskoLekarza.Name = "nazwiskoLekarza";
            this.nazwiskoLekarza.ReadOnly = true;
            // 
            // specjalizacjaLekarza
            // 
            this.specjalizacjaLekarza.DataPropertyName = "SPECJALIZACJA";
            this.specjalizacjaLekarza.HeaderText = "SPECJALIZACJA";
            this.specjalizacjaLekarza.Name = "specjalizacjaLekarza";
            this.specjalizacjaLekarza.ReadOnly = true;
            // 
            // lEKARZETAPIWYSWIETLLEKARZY1BindingSource
            // 
            this.lEKARZETAPIWYSWIETLLEKARZY1BindingSource.DataMember = "LEKARZE_TAPI_WYSWIETL_LEKARZY1";
            this.lEKARZETAPIWYSWIETLLEKARZY1BindingSource.DataSource = this.przychodniaSet;
            // 
            // przychodniaSet
            // 
            this.przychodniaSet.DataSetName = "PrzychodniaSet";
            this.przychodniaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usunLekarza
            // 
            this.usunLekarza.Active = false;
            this.usunLekarza.Activecolor = System.Drawing.Color.DarkRed;
            this.usunLekarza.BackColor = System.Drawing.Color.DarkRed;
            this.usunLekarza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usunLekarza.BorderRadius = 0;
            this.usunLekarza.ButtonText = "Usuń";
            this.usunLekarza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usunLekarza.DisabledColor = System.Drawing.Color.Gray;
            this.usunLekarza.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.usunLekarza.Iconcolor = System.Drawing.Color.Transparent;
            this.usunLekarza.Iconimage = null;
            this.usunLekarza.Iconimage_right = null;
            this.usunLekarza.Iconimage_right_Selected = null;
            this.usunLekarza.Iconimage_Selected = null;
            this.usunLekarza.IconMarginLeft = 0;
            this.usunLekarza.IconMarginRight = 0;
            this.usunLekarza.IconRightVisible = true;
            this.usunLekarza.IconRightZoom = 0D;
            this.usunLekarza.IconVisible = true;
            this.usunLekarza.IconZoom = 90D;
            this.usunLekarza.IsTab = false;
            this.usunLekarza.Location = new System.Drawing.Point(653, 490);
            this.usunLekarza.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.usunLekarza.Name = "usunLekarza";
            this.usunLekarza.Normalcolor = System.Drawing.Color.DarkRed;
            this.usunLekarza.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usunLekarza.OnHoverTextColor = System.Drawing.Color.White;
            this.usunLekarza.selected = false;
            this.usunLekarza.Size = new System.Drawing.Size(118, 50);
            this.usunLekarza.TabIndex = 27;
            this.usunLekarza.Text = "Usuń";
            this.usunLekarza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usunLekarza.Textcolor = System.Drawing.Color.White;
            this.usunLekarza.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunLekarza.Click += new System.EventHandler(this.usunLekarza_Click);
            // 
            // edytujLekarza
            // 
            this.edytujLekarza.Active = false;
            this.edytujLekarza.Activecolor = System.Drawing.Color.Orange;
            this.edytujLekarza.BackColor = System.Drawing.Color.Orange;
            this.edytujLekarza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edytujLekarza.BorderRadius = 0;
            this.edytujLekarza.ButtonText = "Edytuj";
            this.edytujLekarza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edytujLekarza.DisabledColor = System.Drawing.Color.Gray;
            this.edytujLekarza.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.edytujLekarza.Iconcolor = System.Drawing.Color.Transparent;
            this.edytujLekarza.Iconimage = null;
            this.edytujLekarza.Iconimage_right = null;
            this.edytujLekarza.Iconimage_right_Selected = null;
            this.edytujLekarza.Iconimage_Selected = null;
            this.edytujLekarza.IconMarginLeft = 0;
            this.edytujLekarza.IconMarginRight = 0;
            this.edytujLekarza.IconRightVisible = true;
            this.edytujLekarza.IconRightZoom = 0D;
            this.edytujLekarza.IconVisible = true;
            this.edytujLekarza.IconZoom = 90D;
            this.edytujLekarza.IsTab = false;
            this.edytujLekarza.Location = new System.Drawing.Point(508, 490);
            this.edytujLekarza.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.edytujLekarza.Name = "edytujLekarza";
            this.edytujLekarza.Normalcolor = System.Drawing.Color.Orange;
            this.edytujLekarza.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.edytujLekarza.OnHoverTextColor = System.Drawing.Color.White;
            this.edytujLekarza.selected = false;
            this.edytujLekarza.Size = new System.Drawing.Size(118, 50);
            this.edytujLekarza.TabIndex = 28;
            this.edytujLekarza.Text = "Edytuj";
            this.edytujLekarza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edytujLekarza.Textcolor = System.Drawing.Color.White;
            this.edytujLekarza.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujLekarza.Click += new System.EventHandler(this.edytujLekarza_Click_1);
            // 
            // LekarzSearch
            // 
            this.LekarzSearch.AcceptsReturn = false;
            this.LekarzSearch.AcceptsTab = false;
            this.LekarzSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LekarzSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LekarzSearch.BackColor = System.Drawing.Color.Transparent;
            this.LekarzSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LekarzSearch.BackgroundImage")));
            this.LekarzSearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.LekarzSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.LekarzSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.LekarzSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.LekarzSearch.BorderRadius = 1;
            this.LekarzSearch.BorderThickness = 2;
            this.LekarzSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LekarzSearch.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LekarzSearch.DefaultText = "";
            this.LekarzSearch.FillColor = System.Drawing.Color.White;
            this.LekarzSearch.HideSelection = true;
            this.LekarzSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("LekarzSearch.IconLeft")));
            this.LekarzSearch.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LekarzSearch.IconPadding = 10;
            this.LekarzSearch.IconRight = null;
            this.LekarzSearch.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LekarzSearch.Location = new System.Drawing.Point(335, 505);
            this.LekarzSearch.MaxLength = 32767;
            this.LekarzSearch.MinimumSize = new System.Drawing.Size(100, 35);
            this.LekarzSearch.Modified = false;
            this.LekarzSearch.Name = "LekarzSearch";
            this.LekarzSearch.PasswordChar = '\0';
            this.LekarzSearch.ReadOnly = false;
            this.LekarzSearch.SelectedText = "";
            this.LekarzSearch.SelectionLength = 0;
            this.LekarzSearch.SelectionStart = 0;
            this.LekarzSearch.ShortcutsEnabled = true;
            this.LekarzSearch.Size = new System.Drawing.Size(123, 35);
            this.LekarzSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.LekarzSearch.TabIndex = 29;
            this.LekarzSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LekarzSearch.TextMarginLeft = 5;
            this.LekarzSearch.TextPlaceholder = "Lekarz";
            this.LekarzSearch.UseSystemPasswordChar = false;
            this.LekarzSearch.TextChange += new System.EventHandler(this.LekarzSearch_TextChange);
            // 
            // lEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter
            // 
            this.lEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter.ClearBeforeFill = true;
            // 
            // LekarzeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.LekarzSearch);
            this.Controls.Add(this.usunLekarza);
            this.Controls.Add(this.edytujLekarza);
            this.Controls.Add(this.datagridLekarze5);
            this.Controls.Add(this.LekarzeLabel);
            this.Controls.Add(this.dodajLekarza);
            this.Controls.Add(this.specjalizacjaLekarzaTB);
            this.Controls.Add(this.nazwiskoLekarzaTB);
            this.Controls.Add(this.imieLekarzaTB);
            this.Name = "LekarzeControl";
            this.Size = new System.Drawing.Size(824, 575);
            ((System.ComponentModel.ISupportInitialize)(this.datagridLekarze5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEKARZETAPIWYSWIETLLEKARZY1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LekarzeLabel;
        private Bunifu.Framework.UI.BunifuFlatButton dodajLekarza;
        private Bunifu.Framework.UI.BunifuMaterialTextbox specjalizacjaLekarzaTB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nazwiskoLekarzaTB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox imieLekarzaTB;

        private Bunifu.Framework.UI.BunifuFlatButton usunLekarza;
        private Bunifu.Framework.UI.BunifuFlatButton edytujLekarza;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox LekarzSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMIĘDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWISKODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPECJALIZACJADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLEKARZADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieLekarza;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoLekarza;
        private System.Windows.Forms.DataGridViewTextBoxColumn specjalizacjaLekarza;
        private System.Windows.Forms.BindingSource lEKARZETAPIWYSWIETLLEKARZY1BindingSource;
        private PrzychodniaSet przychodniaSet;
        private PrzychodniaSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private PrzychodniaSetTableAdapters.LEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter lEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter;
        public Bunifu.UI.WinForms.BunifuDataGridView datagridLekarze5;
    }
}
