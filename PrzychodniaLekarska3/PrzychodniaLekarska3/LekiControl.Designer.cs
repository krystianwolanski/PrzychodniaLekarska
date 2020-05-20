namespace PrzychodniaLekarska3
{
    partial class LekiControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LekiControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.opisLekuTB = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.LekiLabel = new System.Windows.Forms.Label();
            this.dodajLek = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nazwaLekuTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.datagridLeki = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.usunLek = new Bunifu.Framework.UI.BunifuFlatButton();
            this.edytujLek = new Bunifu.Framework.UI.BunifuFlatButton();
            this.iDLEKARSTWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEKITAPIWYSWIETLLEKIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaSet = new PrzychodniaLekarska3.PrzychodniaSet();
            this.lEKI_TAPI_WYSWIETL_LEKITableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.LEKI_TAPI_WYSWIETL_LEKITableAdapter();
            this.queriesTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridLeki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEKITAPIWYSWIETLLEKIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).BeginInit();
            this.SuspendLayout();
            // 
            // opisLekuTB
            // 
            this.opisLekuTB.AcceptsReturn = false;
            this.opisLekuTB.AcceptsTab = false;
            this.opisLekuTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.opisLekuTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.opisLekuTB.BackColor = System.Drawing.Color.White;
            this.opisLekuTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("opisLekuTB.BackgroundImage")));
            this.opisLekuTB.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.opisLekuTB.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.opisLekuTB.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.opisLekuTB.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.opisLekuTB.BorderRadius = 1;
            this.opisLekuTB.BorderThickness = 2;
            this.opisLekuTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.opisLekuTB.DefaultFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisLekuTB.DefaultText = "";
            this.opisLekuTB.FillColor = System.Drawing.Color.White;
            this.opisLekuTB.HideSelection = true;
            this.opisLekuTB.IconLeft = null;
            this.opisLekuTB.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.opisLekuTB.IconPadding = 10;
            this.opisLekuTB.IconRight = null;
            this.opisLekuTB.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.opisLekuTB.Location = new System.Drawing.Point(57, 210);
            this.opisLekuTB.MaxLength = 32767;
            this.opisLekuTB.MinimumSize = new System.Drawing.Size(100, 35);
            this.opisLekuTB.Modified = false;
            this.opisLekuTB.Name = "opisLekuTB";
            this.opisLekuTB.PasswordChar = '\0';
            this.opisLekuTB.ReadOnly = false;
            this.opisLekuTB.SelectedText = "";
            this.opisLekuTB.SelectionLength = 0;
            this.opisLekuTB.SelectionStart = 0;
            this.opisLekuTB.ShortcutsEnabled = true;
            this.opisLekuTB.Size = new System.Drawing.Size(335, 147);
            this.opisLekuTB.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.opisLekuTB.TabIndex = 44;
            this.opisLekuTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.opisLekuTB.TextMarginLeft = 5;
            this.opisLekuTB.TextPlaceholder = "Opis";
            this.opisLekuTB.UseSystemPasswordChar = false;
            // 
            // LekiLabel
            // 
            this.LekiLabel.AutoSize = true;
            this.LekiLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LekiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.LekiLabel.Location = new System.Drawing.Point(51, 62);
            this.LekiLabel.Name = "LekiLabel";
            this.LekiLabel.Size = new System.Drawing.Size(69, 36);
            this.LekiLabel.TabIndex = 43;
            this.LekiLabel.Text = "Leki";
            // 
            // dodajLek
            // 
            this.dodajLek.Active = false;
            this.dodajLek.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajLek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajLek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dodajLek.BorderRadius = 0;
            this.dodajLek.ButtonText = "Dodaj";
            this.dodajLek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajLek.DisabledColor = System.Drawing.Color.Gray;
            this.dodajLek.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.dodajLek.Iconcolor = System.Drawing.Color.Transparent;
            this.dodajLek.Iconimage = null;
            this.dodajLek.Iconimage_right = null;
            this.dodajLek.Iconimage_right_Selected = null;
            this.dodajLek.Iconimage_Selected = null;
            this.dodajLek.IconMarginLeft = 0;
            this.dodajLek.IconMarginRight = 0;
            this.dodajLek.IconRightVisible = true;
            this.dodajLek.IconRightZoom = 0D;
            this.dodajLek.IconVisible = true;
            this.dodajLek.IconZoom = 90D;
            this.dodajLek.IsTab = false;
            this.dodajLek.Location = new System.Drawing.Point(57, 377);
            this.dodajLek.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dodajLek.Name = "dodajLek";
            this.dodajLek.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajLek.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dodajLek.OnHoverTextColor = System.Drawing.Color.White;
            this.dodajLek.selected = false;
            this.dodajLek.Size = new System.Drawing.Size(118, 50);
            this.dodajLek.TabIndex = 42;
            this.dodajLek.Text = "Dodaj";
            this.dodajLek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dodajLek.Textcolor = System.Drawing.Color.White;
            this.dodajLek.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajLek.Click += new System.EventHandler(this.dodajLek_Click);
            // 
            // nazwaLekuTB
            // 
            this.nazwaLekuTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nazwaLekuTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nazwaLekuTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nazwaLekuTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nazwaLekuTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaLekuTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.nazwaLekuTB.HintForeColor = System.Drawing.Color.Empty;
            this.nazwaLekuTB.HintText = "Nazwa";
            this.nazwaLekuTB.isPassword = false;
            this.nazwaLekuTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.nazwaLekuTB.LineIdleColor = System.Drawing.Color.Gray;
            this.nazwaLekuTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.nazwaLekuTB.LineThickness = 4;
            this.nazwaLekuTB.Location = new System.Drawing.Point(57, 147);
            this.nazwaLekuTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.nazwaLekuTB.MaxLength = 32767;
            this.nazwaLekuTB.Name = "nazwaLekuTB";
            this.nazwaLekuTB.Size = new System.Drawing.Size(335, 43);
            this.nazwaLekuTB.TabIndex = 41;
            this.nazwaLekuTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // datagridLeki
            // 
            this.datagridLeki.AllowCustomTheming = true;
            this.datagridLeki.AllowUserToAddRows = false;
            this.datagridLeki.AllowUserToDeleteRows = false;
            this.datagridLeki.AllowUserToResizeColumns = false;
            this.datagridLeki.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.datagridLeki.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridLeki.AutoGenerateColumns = false;
            this.datagridLeki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridLeki.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagridLeki.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridLeki.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridLeki.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridLeki.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridLeki.ColumnHeadersHeight = 40;
            this.datagridLeki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDLEKARSTWADataGridViewTextBoxColumn,
            this.nAZWADataGridViewTextBoxColumn,
            this.oPISDataGridViewTextBoxColumn});
            this.datagridLeki.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridLeki.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.datagridLeki.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridLeki.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridLeki.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridLeki.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.datagridLeki.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridLeki.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.datagridLeki.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.datagridLeki.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridLeki.CurrentTheme.Name = null;
            this.datagridLeki.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridLeki.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.datagridLeki.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridLeki.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridLeki.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridLeki.DataSource = this.lEKITAPIWYSWIETLLEKIBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridLeki.DefaultCellStyle = dataGridViewCellStyle6;
            this.datagridLeki.EnableHeadersVisualStyles = false;
            this.datagridLeki.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridLeki.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.datagridLeki.HeaderBgColor = System.Drawing.Color.Empty;
            this.datagridLeki.HeaderForeColor = System.Drawing.Color.White;
            this.datagridLeki.Location = new System.Drawing.Point(446, 0);
            this.datagridLeki.Name = "datagridLeki";
            this.datagridLeki.ReadOnly = true;
            this.datagridLeki.RowHeadersVisible = false;
            this.datagridLeki.RowTemplate.Height = 40;
            this.datagridLeki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridLeki.Size = new System.Drawing.Size(378, 463);
            this.datagridLeki.TabIndex = 45;
            this.datagridLeki.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // usunLek
            // 
            this.usunLek.Active = false;
            this.usunLek.Activecolor = System.Drawing.Color.DarkRed;
            this.usunLek.BackColor = System.Drawing.Color.DarkRed;
            this.usunLek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usunLek.BorderRadius = 0;
            this.usunLek.ButtonText = "Usuń";
            this.usunLek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usunLek.DisabledColor = System.Drawing.Color.Gray;
            this.usunLek.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.usunLek.Iconcolor = System.Drawing.Color.Transparent;
            this.usunLek.Iconimage = null;
            this.usunLek.Iconimage_right = null;
            this.usunLek.Iconimage_right_Selected = null;
            this.usunLek.Iconimage_Selected = null;
            this.usunLek.IconMarginLeft = 0;
            this.usunLek.IconMarginRight = 0;
            this.usunLek.IconRightVisible = true;
            this.usunLek.IconRightZoom = 0D;
            this.usunLek.IconVisible = true;
            this.usunLek.IconZoom = 90D;
            this.usunLek.IsTab = false;
            this.usunLek.Location = new System.Drawing.Point(650, 493);
            this.usunLek.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.usunLek.Name = "usunLek";
            this.usunLek.Normalcolor = System.Drawing.Color.DarkRed;
            this.usunLek.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usunLek.OnHoverTextColor = System.Drawing.Color.White;
            this.usunLek.selected = false;
            this.usunLek.Size = new System.Drawing.Size(118, 50);
            this.usunLek.TabIndex = 46;
            this.usunLek.Text = "Usuń";
            this.usunLek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usunLek.Textcolor = System.Drawing.Color.White;
            this.usunLek.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunLek.Click += new System.EventHandler(this.usunLek_Click);
            // 
            // edytujLek
            // 
            this.edytujLek.Active = false;
            this.edytujLek.Activecolor = System.Drawing.Color.Orange;
            this.edytujLek.BackColor = System.Drawing.Color.Orange;
            this.edytujLek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edytujLek.BorderRadius = 0;
            this.edytujLek.ButtonText = "Edytuj";
            this.edytujLek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edytujLek.DisabledColor = System.Drawing.Color.Gray;
            this.edytujLek.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.edytujLek.Iconcolor = System.Drawing.Color.Transparent;
            this.edytujLek.Iconimage = null;
            this.edytujLek.Iconimage_right = null;
            this.edytujLek.Iconimage_right_Selected = null;
            this.edytujLek.Iconimage_Selected = null;
            this.edytujLek.IconMarginLeft = 0;
            this.edytujLek.IconMarginRight = 0;
            this.edytujLek.IconRightVisible = true;
            this.edytujLek.IconRightZoom = 0D;
            this.edytujLek.IconVisible = true;
            this.edytujLek.IconZoom = 90D;
            this.edytujLek.IsTab = false;
            this.edytujLek.Location = new System.Drawing.Point(505, 493);
            this.edytujLek.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.edytujLek.Name = "edytujLek";
            this.edytujLek.Normalcolor = System.Drawing.Color.Orange;
            this.edytujLek.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.edytujLek.OnHoverTextColor = System.Drawing.Color.White;
            this.edytujLek.selected = false;
            this.edytujLek.Size = new System.Drawing.Size(118, 50);
            this.edytujLek.TabIndex = 47;
            this.edytujLek.Text = "Edytuj";
            this.edytujLek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edytujLek.Textcolor = System.Drawing.Color.White;
            this.edytujLek.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujLek.Click += new System.EventHandler(this.edytujLek_Click);
            // 
            // iDLEKARSTWADataGridViewTextBoxColumn
            // 
            this.iDLEKARSTWADataGridViewTextBoxColumn.DataPropertyName = "ID_LEKARSTWA";
            this.iDLEKARSTWADataGridViewTextBoxColumn.HeaderText = "ID_LEKARSTWA";
            this.iDLEKARSTWADataGridViewTextBoxColumn.Name = "iDLEKARSTWADataGridViewTextBoxColumn";
            this.iDLEKARSTWADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDLEKARSTWADataGridViewTextBoxColumn.Visible = false;
            // 
            // nAZWADataGridViewTextBoxColumn
            // 
            this.nAZWADataGridViewTextBoxColumn.DataPropertyName = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.HeaderText = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.Name = "nAZWADataGridViewTextBoxColumn";
            this.nAZWADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oPISDataGridViewTextBoxColumn
            // 
            this.oPISDataGridViewTextBoxColumn.DataPropertyName = "OPIS";
            this.oPISDataGridViewTextBoxColumn.HeaderText = "OPIS";
            this.oPISDataGridViewTextBoxColumn.Name = "oPISDataGridViewTextBoxColumn";
            this.oPISDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lEKITAPIWYSWIETLLEKIBindingSource
            // 
            this.lEKITAPIWYSWIETLLEKIBindingSource.DataMember = "LEKI_TAPI_WYSWIETL_LEKI";
            this.lEKITAPIWYSWIETLLEKIBindingSource.DataSource = this.przychodniaSet;
            // 
            // przychodniaSet
            // 
            this.przychodniaSet.DataSetName = "PrzychodniaSet";
            this.przychodniaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lEKI_TAPI_WYSWIETL_LEKITableAdapter
            // 
            this.lEKI_TAPI_WYSWIETL_LEKITableAdapter.ClearBeforeFill = true;
            // 
            // LekiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.usunLek);
            this.Controls.Add(this.edytujLek);
            this.Controls.Add(this.datagridLeki);
            this.Controls.Add(this.opisLekuTB);
            this.Controls.Add(this.LekiLabel);
            this.Controls.Add(this.dodajLek);
            this.Controls.Add(this.nazwaLekuTB);
            this.Name = "LekiControl";
            this.Size = new System.Drawing.Size(824, 575);
            ((System.ComponentModel.ISupportInitialize)(this.datagridLeki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEKITAPIWYSWIETLLEKIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox opisLekuTB;
        private System.Windows.Forms.Label LekiLabel;
        private Bunifu.Framework.UI.BunifuFlatButton dodajLek;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nazwaLekuTB;
        private Bunifu.UI.WinForms.BunifuDataGridView datagridLeki;
        private Bunifu.Framework.UI.BunifuFlatButton usunLek;
        private Bunifu.Framework.UI.BunifuFlatButton edytujLek;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLEKARSTWADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPISDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lEKITAPIWYSWIETLLEKIBindingSource;
        private PrzychodniaSet przychodniaSet;
        private PrzychodniaSetTableAdapters.LEKI_TAPI_WYSWIETL_LEKITableAdapter lEKI_TAPI_WYSWIETL_LEKITableAdapter;
        private PrzychodniaSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}
